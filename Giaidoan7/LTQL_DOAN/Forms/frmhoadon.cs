using LTQL_DOAN.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTQL_DOAN.Forms
{
    public partial class frmhoadon : Form
    {
        public frmhoadon()
        {
            InitializeComponent();
        }
        QUANLYCHSDbContext context = new QUANLYCHSDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        int id;
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            List<HoaDon> hd = new List<HoaDon>();
            hd = context.HoaDon.Select(r => new HoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.ChiTietHoaDon.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView1.DataSource = hd;

        }

        private void btnlaphoadon_Click(object sender, EventArgs e)
        {
            using (frmhoadon_chitiet chiTiet = new frmhoadon_chitiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            using (frmhoadon_chitiet chiTiet = new frmhoadon_chitiet(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }
    }
}
