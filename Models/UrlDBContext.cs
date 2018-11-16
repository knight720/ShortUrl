using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShortUrl.Models
{
    public partial class UrlDBContext : DbContext
    {
        public UrlDBContext()
        {
        }

        public UrlDBContext(DbContextOptions<UrlDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Url> Url { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=UrlDB;User ID=sa;Password=P@ssw0rd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Url>(entity =>
            {
                entity.Property(e => e.UrlId).HasColumnName("Url_Id");

                entity.Property(e => e.UrlCode)
                    .IsRequired()
                    .HasColumnName("Url_Code")
                    .HasMaxLength(36);

                entity.Property(e => e.UrlUrl)
                    .IsRequired()
                    .HasColumnName("Url_Url")
                    .HasMaxLength(1000);
            });
        }
    }
}
