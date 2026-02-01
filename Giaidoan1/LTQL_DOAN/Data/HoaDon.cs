using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


namespace LTQL_DOAN.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int MaHoaDon { get; set; }   

        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }

        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }

        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
