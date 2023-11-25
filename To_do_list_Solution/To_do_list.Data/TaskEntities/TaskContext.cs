using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace To_do_list.Data.TaskEntities
{
    public partial class TaskContext : DbContext
    {
        public TaskContext()
        {
        }

        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorytbl> Categorytbls { get; set; } = null!;
        public virtual DbSet<Tasktbl> Tasktbls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-5CF1PETR\\SQLEXPRESS;Database=Task;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorytbl>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Category__19093A0B0CAFFC35");

                entity.ToTable("Categorytbl");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tasktbl>(entity =>
            {
                entity.HasKey(e => e.Title)
                    .HasName("PK__Tasktbl__2CB664DD936B5540");

                entity.ToTable("Tasktbl");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Tasktbls)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_aa");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
