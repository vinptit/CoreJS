using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TMS.API.Models
{
    public partial class HistoryContext : DbContext
    {
        public HistoryContext()
        {
        }

        public HistoryContext(DbContextOptions<HistoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ACC_History> ACC_History { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACC_History>(entity =>
            {
                entity.Property(e => e.OldValueText).HasMaxLength(500);

                entity.Property(e => e.ReasonOfChange)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TanentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValueText).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
