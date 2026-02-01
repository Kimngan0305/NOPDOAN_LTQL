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

        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public int ID { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get => hoaDon; set => hoaDon = value; }
    }
}
