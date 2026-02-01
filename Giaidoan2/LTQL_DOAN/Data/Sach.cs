using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class Sach
    {
        public int ID { get; set; }
        public int TacGiaID { get; set; }
        public virtual TacGia TacGia { get; set; }

        public int MaSach { get; set; }
        public int MaLoai { get; set; }

        public string TenSach { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }


        public virtual Loai Loai { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; } = new List<ChiTietHoaDon>();
        public virtual ICollection<NhaXuatban> NhaXuatbans { get; set; } = new List<NhaXuatban>();
    }
    }
