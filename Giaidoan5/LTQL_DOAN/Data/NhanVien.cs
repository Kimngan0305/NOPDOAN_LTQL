using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        private ICollection<HoaDon> hoaDon = new List<HoaDon>();

        public string HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool QuyenHan { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get => hoaDon; set => hoaDon = value; }
    }
}
