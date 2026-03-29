using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LTQL_DOAN.Data
{
    public class QUANLYCHSDbContext : DbContext
    {
        public DbSet<Sach> Sach { get; set; }
        public DbSet<Kho> Kho { get; set; }
        public DbSet<LinhVuc> LinhVuc { get; set; }
        public DbSet<Loai> Loai { get; set; }
        public DbSet<TacGia> TacGia { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                (
                    @"Server=DESKTOP-N0KKONM\SQLEXPRESS;Database=QLCHS;Integrated Security=True;TrustServerCertificate=True",
                    providerOptions => providerOptions.EnableRetryOnFailure()
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kho>()
                .HasOne(k => k.Sach)
                .WithMany(s => s.Khos)
                .HasForeignKey(k => k.SachID)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
