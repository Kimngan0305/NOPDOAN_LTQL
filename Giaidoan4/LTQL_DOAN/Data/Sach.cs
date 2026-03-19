using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class Sach
    {
        public string MaSach { get; set; }

        public string TenSach { get; set; }

        public int MaTacGia { get; set; }

        public int MaLinhVuc { get; set; }

        public int MaLoai { get; set; }

        public int MaNXB { get; set; }

        public int GiaMua { get; set; }

        public int GiaBia { get; set; }
        public int DonGiaBan { get; set; }

        public int LanTaiBan { get; set; }

        public DateTime NamXB { get; set; }

        public virtual TacGia TacGia { get; set; }

        public virtual LinhVuc LinhVuc { get; set; }

        public virtual Loai Loai { get; set; }

        public virtual NhaXuatBan NhaXuatBan { get; set; }


        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; } = new List<ChiTietHoaDon>();
        public virtual ICollection<NhaXuatBan> NhaXuatbans { get; set; } = new List<NhaXuatBan>();
    }
    }
