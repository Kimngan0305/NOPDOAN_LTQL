using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_DOAN.Data
{
    public class Kho
    {
        public int ID { get; set; }
        public int MaKho { get; set; }   // khóa chính
        public string TenKho { get; set; }

        public string MaSach{ get; set; }
        
        public int SoLuong { get; set; }
    }
}
