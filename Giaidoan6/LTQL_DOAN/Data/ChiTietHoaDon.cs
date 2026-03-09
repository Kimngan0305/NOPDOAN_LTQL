using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class ChiTietHoaDon
    {
      
        public int MaCTHD { get; set; }

        public int MaHoaDon { get; set; }
        public int MaSach { get; set; }

        public int SoLuong { get; set; }
        public int DonGiaBan { get; set; }

        public HoaDon HoaDon { get; set; }
        public Sach Sach { get; set; }
        public int GiaBan { get; set; }
        
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public string TenSach{ get; set; } // Thêm 
        public short SoLuongBan { get; set; }
       
        public int ThanhTien { get; set; }
    }

}