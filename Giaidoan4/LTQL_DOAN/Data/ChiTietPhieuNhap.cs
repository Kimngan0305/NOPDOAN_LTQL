using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class ChiTietPhieuNhap
    {
        public int ID { get; set; }
        public int MaCTPN { get; set; }   

        public int MaPN { get; set; }     
        public int MaSach { get; set; }  

        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal ThanhTien
        {
            get { return SoLuong * DonGiaNhap; }
        }

        public PhieuNhap PhieuNhap { get; set; }
        public Sach Sach { get; set; }
    }
}
