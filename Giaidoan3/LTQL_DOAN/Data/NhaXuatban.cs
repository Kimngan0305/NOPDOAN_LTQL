using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class NhaXuatban
    {
        public int ID { get; set; }
        public int MaNXB { get; set; }

        public string TenNXB { get; set; }
        
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }

        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
            = new List<PhieuNhap>();
    }
}
