using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LTQL_DOAN.Data
{
    public class QLBHDbContext : DbContext
    {
        public DbSet<Sach> Sach { get; set; }
        public DbSet<Loai> Loai { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql(
                "server=localhost;database=qlbansach;user=root;password=123456;",
                new MySqlServerVersion(new Version(8, 0, 34))

            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasKey(ct => new { ct.MaHoaDon, ct.MaSach });
        }
    }
}
