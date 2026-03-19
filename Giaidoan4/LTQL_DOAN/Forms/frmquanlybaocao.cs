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
using Microsoft.EntityFrameworkCore;

namespace LTQL
{
    public partial class frmquanlybaocao : Form
    {
        public frmquanlybaocao()
        {
            InitializeComponent();
        }

        private void frmquanlybaocao_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
        private void LoadBaoCao()
        {
            using (var db = new QUANLYCHSDbContext())
            {
                var data = db.ChiTietHoaDon
                    .Include(ct => ct.Sach)
                    .GroupBy(ct => new { ct.MaSach, ct.Sach.TenSach })
                    .Select(g => new
                    {
                        MaSach = g.Key.MaSach,
                        TenSach = g.Key.TenSach,
                        SoLuongBanRa = g.Sum(x => x.SoLuong),
                        DoanhThu = g.Sum(x => x.SoLuong * x.GiaBan)
                    })
                    .ToList();

                dgvbaocao.DataSource = data;

                decimal tongDoanhThu = data.Sum(x => x.DoanhThu);

                lbltongdoanhthu.Text = "TỔNG DOANH THU: " + tongDoanhThu.ToString("N0") + " VND";

                // Giả sử lợi nhuận = 20% doanh thu
                decimal loiNhuan = tongDoanhThu * 0.2m;

                lblloinhuan.Text = "LỢI NHUẬN: " + loiNhuan.ToString("N0") + " VND";
            }
        }

    }
}
