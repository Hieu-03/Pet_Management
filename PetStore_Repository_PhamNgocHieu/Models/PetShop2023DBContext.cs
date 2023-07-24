using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace PetStore_Repository_PhamNgocHieu.Models
{
    public partial class PetShop2023DBContext : DbContext
    {
        public PetShop2023DBContext()
        {
        }

        public PetShop2023DBContext(DbContextOptions<PetShop2023DBContext> options)
            : base(options)
        {
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
            var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];

            return strConn;
        }

        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<PetGroup> PetGroups { get; set; }
        public virtual DbSet<PetShopMember> PetShopMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database= PetShop2023DB;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>(entity =>
            {
                entity.ToTable("Pet");

                entity.Property(e => e.PetId).ValueGeneratedNever();

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.PetDescription).HasMaxLength(220);

                entity.Property(e => e.PetGroupId).HasMaxLength(20);

                entity.Property(e => e.PetName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.PetGroup)
                    .WithMany(p => p.Pets)
                    .HasForeignKey(d => d.PetGroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Pet__PetGroupId__29572725");
            });

            modelBuilder.Entity<PetGroup>(entity =>
            {
                entity.ToTable("PetGroup");

                entity.Property(e => e.PetGroupId).HasMaxLength(20);

                entity.Property(e => e.GroupDescription).HasMaxLength(150);

                entity.Property(e => e.OriginalSource).HasMaxLength(60);

                entity.Property(e => e.PetGroupName)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<PetShopMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__PetShopM__0CF04B38829A8150");

                entity.ToTable("PetShopMember");

                entity.HasIndex(e => e.EmailAddress, "UQ__PetShopM__49A1474003E5CDD8")
                    .IsUnique();

                entity.Property(e => e.MemberId)
                    .HasMaxLength(20)
                    .HasColumnName("MemberID");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MemberPassword)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
