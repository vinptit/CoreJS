﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TMS.API.Models
{
    public partial class TMSContext : DbContext
    {
        public TMSContext()
        {
        }

        public TMSContext(DbContextOptions<TMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApprovalConfig> ApprovalConfig { get; set; }
        public virtual DbSet<Approvement> Approvement { get; set; }
        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<Component> Component { get; set; }
        public virtual DbSet<ComponentGroup> ComponentGroup { get; set; }
        public virtual DbSet<Convertation> Convertation { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityRef> EntityRef { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FeaturePolicy> FeaturePolicy { get; set; }
        public virtual DbSet<FileUpload> FileUpload { get; set; }
        public virtual DbSet<GridPolicy> GridPolicy { get; set; }
        public virtual DbSet<Intro> Intro { get; set; }
        public virtual DbSet<MasterData> MasterData { get; set; }
        public virtual DbSet<RequestLog> RequestLog { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<TaskNotification> TaskNotification { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserSetting> UserSetting { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorService> VendorService { get; set; }
        public virtual DbSet<Webhook> Webhook { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApprovalConfig>(entity =>
            {
                entity.Property(e => e.DataSource).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.MaxAmount).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.MinAmount).HasColumnType("decimal(20, 5)");
            });

            modelBuilder.Entity<Approvement>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.LevelName).HasMaxLength(50);

                entity.Property(e => e.ReasonOfChange).HasMaxLength(200);
            });

            modelBuilder.Entity<Component>(entity =>
            {
                entity.Property(e => e.AddDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CascadeField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChildStyle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateTimeField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultVal).HasMaxLength(500);

                entity.Property(e => e.DescFieldName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DescValue).IsUnicode(false);

                entity.Property(e => e.DisabledExp).HasMaxLength(2000);

                entity.Property(e => e.Events)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExcelFieldName).HasMaxLength(1000);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormatData).HasMaxLength(1500);

                entity.Property(e => e.FormatSumaryField).HasMaxLength(250);

                entity.Property(e => e.GroupBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupEvent)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GroupFormat).HasMaxLength(1500);

                entity.Property(e => e.GroupReferenceName).HasMaxLength(250);

                entity.Property(e => e.HotKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDoubleLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.JoinTable).HasMaxLength(1000);

                entity.Property(e => e.Label).HasMaxLength(50);

                entity.Property(e => e.ListClass).HasMaxLength(250);

                entity.Property(e => e.OrderBySumary).HasMaxLength(250);

                entity.Property(e => e.PlainText).HasMaxLength(250);

                entity.Property(e => e.RefClass)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RefName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqlSelect).HasMaxLength(1000);

                entity.Property(e => e.Style)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.System)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpperCase).HasDefaultValueSql("((0))");

                entity.Property(e => e.Validation).HasMaxLength(1000);

                entity.Property(e => e.VirtualScroll).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ComponentGroup)
                    .WithMany(p => p.Component)
                    .HasForeignKey(d => d.ComponentGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Component_ComponentGroup");

                entity.HasOne(d => d.Reference)
                    .WithMany(p => p.Component)
                    .HasForeignKey(d => d.ReferenceId)
                    .HasConstraintName("FK_Component_Entity");
            });

            modelBuilder.Entity<ComponentGroup>(entity =>
            {
                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.DisabledExp).HasMaxLength(2000);

                entity.Property(e => e.Events)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Icon).HasMaxLength(100);

                entity.Property(e => e.IsCollapsible).HasDefaultValueSql("((0))");

                entity.Property(e => e.Label).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Style)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TabGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.ComponentGroup)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComponentGroup_Feature");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_ComponentGroup_ComponentGroup");
            });

            modelBuilder.Entity<Convertation>(entity =>
            {
                entity.Property(e => e.FromName).HasMaxLength(250);

                entity.Property(e => e.ToName).HasMaxLength(250);
            });

            modelBuilder.Entity<Dictionary>(entity =>
            {
                entity.HasIndex(e => new { e.LangCode, e.Key }, "UQ_Dictionary_Key")
                    .IsUnique();

                entity.Property(e => e.Key).HasMaxLength(250);

                entity.Property(e => e.LangCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.Property(e => e.AliasFor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Namespace)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RefDetailClass)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RefListClass)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntityRef>(entity =>
            {
                entity.Property(e => e.FieldName).HasMaxLength(250);

                entity.Property(e => e.MenuText)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TargetFieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViewClass)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.EntityRef)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_EntityRef_Component");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource).HasMaxLength(2500);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Events)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureGroup).HasMaxLength(50);

                entity.Property(e => e.Icon).HasMaxLength(250);

                entity.Property(e => e.Label).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RequireJS)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Style)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StyleSheet).IsUnicode(false);

                entity.Property(e => e.ViewClass)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_Feature_Entity");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Feature_Parent");
            });

            modelBuilder.Entity<FeaturePolicy>(entity =>
            {
                entity.Property(e => e.Desc).HasMaxLength(200);

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.FeaturePolicy)
                    .HasForeignKey(d => d.FeatureId)
                    .HasConstraintName("FK_FeaturePolicy_Feature");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FeaturePolicy)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_FeaturePolicy_Role");
            });

            modelBuilder.Entity<FileUpload>(entity =>
            {
                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileHost).HasMaxLength(3000);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FilePath).HasMaxLength(3000);
            });

            modelBuilder.Entity<GridPolicy>(entity =>
            {
                entity.Property(e => e.CascadeField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChildStyle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DatabaseName).HasMaxLength(250);

                entity.Property(e => e.DefaultVal).HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DisabledExp).HasMaxLength(2000);

                entity.Property(e => e.Events)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExcelFieldName).HasMaxLength(1000);

                entity.Property(e => e.FieldName).HasMaxLength(100);

                entity.Property(e => e.FilterTemplate)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormatCell).HasMaxLength(250);

                entity.Property(e => e.FormatExcell).HasMaxLength(200);

                entity.Property(e => e.GroupBy)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.GroupReferenceName).HasMaxLength(250);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSumary).HasDefaultValueSql("((0))");

                entity.Property(e => e.JoinTable).HasMaxLength(1000);

                entity.Property(e => e.ListClass).HasMaxLength(250);

                entity.Property(e => e.MaxWidth)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MinWidth)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlainText).HasMaxLength(250);

                entity.Property(e => e.RefClass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDesc).HasMaxLength(50);

                entity.Property(e => e.Style)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Summary).HasMaxLength(50);

                entity.Property(e => e.System)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextAlign)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpperCase).HasDefaultValueSql("((0))");

                entity.Property(e => e.Validation).HasMaxLength(1000);

                entity.Property(e => e.VirtualScroll).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.GridPolicyEntity)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GridPolicy_Entity");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.GridPolicy)
                    .HasForeignKey(d => d.FeatureId)
                    .HasConstraintName("FK_GridPolicy_Feature");

                entity.HasOne(d => d.Reference)
                    .WithMany(p => p.GridPolicyReference)
                    .HasForeignKey(d => d.ReferenceId)
                    .HasConstraintName("FK_GridPolicy_RefEntity");
            });

            modelBuilder.Entity<Intro>(entity =>
            {
                entity.Property(e => e.FieldName).HasMaxLength(250);
            });

            modelBuilder.Entity<MasterData>(entity =>
            {
                entity.Property(e => e.Additional).HasMaxLength(200);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NameEnglish).HasMaxLength(250);

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_MasterData_MasterData");
            });

            modelBuilder.Entity<RequestLog>(entity =>
            {
                entity.Property(e => e.HttpMethod).HasMaxLength(250);

                entity.Property(e => e.Path).HasMaxLength(500);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Path)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ParentRole)
                    .WithMany(p => p.InverseParentRole)
                    .HasForeignKey(d => d.ParentRoleId)
                    .HasConstraintName("FK_Role_ParentRole");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.Property(e => e.CmdType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.Environment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path).HasMaxLength(3000);
            });

            modelBuilder.Entity<TaskNotification>(entity =>
            {
                entity.Property(e => e.Progress).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TimeConsumed).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TimeRemained).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.TaskNotification)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_TaskNotification_Entity");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TaskNotification)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_TaskNotification_Role");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Avatar).HasMaxLength(1000);

                entity.Property(e => e.ContactId).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recover)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Vendor");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefreshToken).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_User");
            });

            modelBuilder.Entity<UserSetting>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Path)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserSetting)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserSetting_Role");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.AddressReport).HasMaxLength(250);

                entity.Property(e => e.BankName).HasMaxLength(250);

                entity.Property(e => e.BankNo).HasMaxLength(250);

                entity.Property(e => e.CityName).HasMaxLength(250);

                entity.Property(e => e.ClassifyName).HasMaxLength(250);

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.CompanyName).HasMaxLength(250);

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Logo).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.NameReport).HasMaxLength(250);

                entity.Property(e => e.NameSys).HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(111)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumberReport).HasMaxLength(250);

                entity.Property(e => e.PositionName).HasMaxLength(250);

                entity.Property(e => e.ReturnRate).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.StaffName).HasMaxLength(250);

                entity.Property(e => e.TaxCode).HasMaxLength(250);

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.VendorNavigation)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Vendor_User");
            });

            modelBuilder.Entity<VendorService>(entity =>
            {
                entity.HasOne(d => d.Service)
                    .WithMany(p => p.VendorService)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_VendorService_MasterData");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorService)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorService_Vendor");
            });

            modelBuilder.Entity<Webhook>(entity =>
            {
                entity.Property(e => e.AccessTokenField)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApiKey)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApiKeyHeader)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubName).HasMaxLength(100);

                entity.Property(e => e.SubPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubUrl).IsUnicode(false);

                entity.Property(e => e.SubUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TokenPrefix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsernameKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
