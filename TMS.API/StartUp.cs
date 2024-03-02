using Core.Exceptions;
using Core.Extensions;
using Core.ViewModels;
using Hangfire;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Security.Claims;
using System.Text;
using TMS.API.Extensions;
using TMS.API.Models;
using TMS.API.Services;
using TMS.API.Websocket;

namespace TMS.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });
            services.AddLogging(config =>
            {
                config.ClearProviders();
                config.AddConfiguration(_configuration.GetSection("Logging"));
                config.AddDebug();
                config.AddEventSourceLogger();
            });
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
            });
            services.AddWebSocketManager();
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            })
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new IgnoreNullOrEmptyEnumResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
            });
            services.AddDbContext<HistoryContext>((serviceProvider, options) =>
            {
                options.UseSqlServer(_configuration.GetConnectionString($"History"));
#if DEBUG
                options.EnableSensitiveDataLogging();
#endif
            }, ServiceLifetime.Scoped);
            services.AddDbContext<LogContext>((serviceProvider, options) =>
            {
                options.UseSqlServer(_configuration.GetConnectionString($"LOG"));
#if DEBUG
                options.EnableSensitiveDataLogging();
#endif
            }, ServiceLifetime.Scoped);
            services.AddDbContext<TMSContext>((serviceProvider, options) =>
            {
                string connectionStr = GetConnectionString(serviceProvider, _configuration, "Acc");
                options.UseSqlServer(connectionStr);
#if DEBUG
                options.EnableSensitiveDataLogging();
#endif
            }, ServiceLifetime.Scoped);

            services.AddHangfire(configuration => configuration.UseSqlServerStorage(_configuration.GetConnectionString($"Log")));
            services.AddOData();
            var tokenOptions = new TokenValidationParameters()
            {
                ValidIssuer = _configuration["Tokens:Issuer"],
                ValidAudience = _configuration["Tokens:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"])),
                ClockSkew = TimeSpan.Zero
            };
            services.AddSingleton(tokenOptions);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = tokenOptions;

            });
            services.AddDistributedMemoryCache();
            services.AddHttpContextAccessor();

            // the instance created for each request
            services.AddSingleton<EntityService>();
            services.AddScoped<UserService>();
            services.AddScoped<TaskService>();
            services.AddScoped<VendorSvc>();
        }

        public static string GetConnectionString(IServiceProvider serviceProvider, IConfiguration _configuration, string system)
        {
            string tenantCode = GetTanentCode(serviceProvider);
            var connectionStr = _configuration.GetConnectionString($"{system}{tenantCode}")
                ?? _configuration.GetConnectionString(system);
            if (!tenantCode.IsNullOrWhiteSpace())
            {
                connectionStr = connectionStr.Replace($"{system}_Yeni", $"{system}_{tenantCode ?? "Yeni"}");
            }
            return connectionStr;
        }

        public static TMSContext GetTMSContext(string conStr, bool subVendor = false)
        {
            if (conStr.IsNullOrWhiteSpace())
            {
                return null;
            }
            var vendorConnStr = conStr;
            if (subVendor)
            {
                var connStr = JsonConvert.DeserializeObject<List<VendorConnStrVM>>(conStr);
                vendorConnStr = connStr.FirstOrDefault(x => x.Name == "Acc").ConStr;
            }
            var builder = new DbContextOptionsBuilder<TMSContext>().UseSqlServer(vendorConnStr).Options;
            var context = new TMSContext(builder);
            return context;
        }

        private static string GetTanentCode(IServiceProvider serviceProvider)
        {
            var httpContext = serviceProvider.GetService<IHttpContextAccessor>();
            string tenantCode = null;
            if (httpContext?.HttpContext is not null)
            {
                var claim = httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.PrimaryGroupSid);
                if (claim is not null)
                {
                    tenantCode = claim.Value.ToUpper();
                }
                if (tenantCode.IsNullOrWhiteSpace())
                {
                    var a = httpContext.HttpContext.Request.Query[Utils.TenantField].ToString();
                    tenantCode = a.IsNullOrEmpty() ? httpContext.HttpContext.Request.Query["tenant"].ToString() : a;
                }
            }
            return tenantCode;
        }

        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TMSContext tms, EntityService entity)
        {
            if (entity.Entities.Nothing())
            {
                entity.Entities = tms.Entity.ToDictionary(x => x.Id, x =>
                {
                    var res = new Core.Models.Entity();
                    res.CopyPropFrom(x);
                    return res;
                });
            }
            app.UseCors("MyPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseHttpStatusCodeExceptionMiddleware();
            }
            else
            {
                app.UseHttpStatusCodeExceptionMiddleware();
                app.UseHsts();
            }
            app.UseHangfireDashboard();
            app.UseHangfireServer();
            app.UseMiddleware<RequestLoggingMiddleware>();
            app.UseHttpsRedirection();
            var options = new DefaultFilesOptions();
            app.UseResponseCompression();
            app.UseWebSockets();
            var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var serviceProvider = serviceScopeFactory.CreateScope().ServiceProvider;
            app.MapWebSocketManager("/task", serviceProvider.GetService<RealtimeService>());

            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("index.html");
            app.UseDefaultFiles(options);
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(builder =>
            {
                builder.EnableDependencyInjection();
            });
            app.UseRouting();
        }
    }
}
