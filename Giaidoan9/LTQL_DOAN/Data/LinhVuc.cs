using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LTQL_DOAN.Data
{
    
    public class LinhVuc
    {
        public int ID { get; set; }
        public int MaLinhVuc { get; set; }
        public string TenLinhVuc { get; set; }
    }
}
