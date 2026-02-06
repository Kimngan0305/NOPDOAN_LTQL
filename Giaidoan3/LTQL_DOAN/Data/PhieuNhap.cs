using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class PhieuNhap
    {
        public int ID { get; set; }
        public int MaPN { get; set; }  

        public DateTime NgayNhap { get; set; }

        public int MaNV { get; set; }   // Nhân viên lập phiếu
        public int MaNXB { get; set; }  // Nhà xuất bản 

        public NhanVien NhanVien { get; set; }
        public NhaXuatban NhaXuatBan { get; set; }

        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
            = new List<ChiTietPhieuNhap>();
    }
}
