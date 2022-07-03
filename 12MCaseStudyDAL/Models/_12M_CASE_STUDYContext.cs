using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace _12MCaseStudyDAL.Models
{
    public partial class _12M_CASE_STUDYContext : DbContext
    {

        public _12M_CASE_STUDYContext(DbContextOptions<_12M_CASE_STUDYContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sti> Stis { get; set; }
        public virtual DbSet<Stk> Stks { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_100_CI_AS");

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => new { e.SiraNo });
            });

            modelBuilder.Entity<Sti>(entity =>
            {
                entity.HasKey(e => new { e.EvrakNo, e.Tarih, e.IslemTur })
                    .HasName("pkSTI");

                entity.ToTable("STI");

                entity.Property(e => e.EvrakNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Birim)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Fiyat).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MalKodu)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Miktar).HasColumnType("numeric(25, 6)");

                entity.Property(e => e.Tutar).HasColumnType("numeric(25, 6)");
            });

            modelBuilder.Entity<Stk>(entity =>
            {
                entity.HasKey(e => e.MalKodu)
                    .HasName("pkSTK");

                entity.ToTable("STK");

                entity.Property(e => e.MalKodu)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MalAdi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
