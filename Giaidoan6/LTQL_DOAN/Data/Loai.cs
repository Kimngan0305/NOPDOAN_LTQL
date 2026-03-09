using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class Loai
    {
        public int ID { get; set; }
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<Sach> Sach { get; set; } = new List<Sach>();
    }
}
