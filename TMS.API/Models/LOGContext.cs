using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TMS.API.Models
{
    public partial class LogContext : DbContext
    {
        public LogContext()
        {
        }

        public LogContext(DbContextOptions<LogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RequestLog> RequestLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestLog>(entity =>
            {
                entity.Property(e => e.HttpMethod).HasMaxLength(250);

                entity.Property(e => e.Path).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
