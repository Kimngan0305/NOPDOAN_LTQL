using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public int MaKH { get; set; }
            public string TenKH { get; set; }
            public string SDT { get; set; }
            public virtual ICollection<HoaDon> HoaDon { get; set; } = new List<HoaDon>();
        
    }
}
