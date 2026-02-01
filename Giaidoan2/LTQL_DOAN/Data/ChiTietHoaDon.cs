using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LTQL_DOAN.Data
{
    public class ChiTietHoaDon
    {
        public int ID { get; set; }
        public int MaCTHD { get; set; }

        public int MaHoaDon { get; set; }
        public int MaSach { get; set; }

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public HoaDon HoaDon { get; set; }
        public Sach Sach { get; set; }
    }
}
