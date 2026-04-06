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
        public int MaKho { get; set; }   
        public string TenKho { get; set; }

        // Mã sách (dùng để hiển thị/tra cứu theo MaSach)
        public string MaSach{ get; set; }

        // Khóa ngoại chuẩn tới Sach.ID để SSMS Diagram bắt được quan hệ FK.
        public int? SachID { get; set; }

        public virtual Sach? Sach { get; set; }

        public int SoLuong { get; set; }
    }
}
