using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class TacGia
    {
        public int ID { get; set; }
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string QueQuan { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DateTime? NgayMat { get; set; }

        public ICollection<Sach> Saches { get; set; }
    }
}
