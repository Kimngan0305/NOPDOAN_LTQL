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
            this.WindowState = FormWindowState.Maximized;
            btnthoat.Click += (s, e) => this.Close();
        }

        private void frmquanlybaocao_Resize(object sender, EventArgs e)
        {
         
            int contentWidth = 600;
            int startX = (this.ClientSize.Width - contentWidth) / 2;
            int bottomY = this.ClientSize.Height - 120;

            if (startX < 0) startX = 12;
            if (bottomY < dgvbaocao.Bottom + 10) bottomY = dgvbaocao.Bottom + 10;

            label1.Location = new Point(startX, bottomY);
            lbltongdoanhthu.Location = new Point(startX + 195, bottomY);
            
            label2.Location = new Point(startX + 68, bottomY + 37);
            lblloinhuan.Location = new Point(startX + 195, bottomY + 37);
            
            btnthoat.Location = new Point(startX + 443, bottomY - 6);
        }

        private void frmquanlybaocao_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
        private void LoadBaoCao()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                   
                    var rawDetails = db.ChiTietHoaDon
                        .Include(ct => ct.Sach)
                        .ToList();

                   
                    var reportData = rawDetails
                        .GroupBy(ct => new { ct.MaSach, ct.Sach?.TenSach })
                        .Select(g => new
                        {
                            MaSach = g.Key.MaSach,
                            TenSach = g.Key.TenSach ?? "N/A",
                            SoLuongBanRa = g.Sum(x => x.SoLuong),
                            DoanhThu = g.Sum(x => (decimal)(x.SoLuong * x.GiaBan))
                        })
                        .OrderByDescending(x => x.DoanhThu)
                        .ToList();

                    dgvbaocao.AutoGenerateColumns = false;
                    
                   
                    if (dgvbaocao.Columns.Contains("MaSachBanRa")) dgvbaocao.Columns["MaSachBanRa"].DataPropertyName = "MaSach";
                    if (dgvbaocao.Columns.Contains("TenSachBanRa")) dgvbaocao.Columns["TenSachBanRa"].DataPropertyName = "TenSach";
                    if (dgvbaocao.Columns.Contains("SoLuongBanRa")) dgvbaocao.Columns["SoLuongBanRa"].DataPropertyName = "SoLuongBanRa";
                    
                    
                    if (!dgvbaocao.Columns.Contains("DoanhThuCol"))
                    {
                        var col = new DataGridViewTextBoxColumn();
                        col.Name = "DoanhThuCol";
                        col.HeaderText = "Doanh Thu";
                        col.DataPropertyName = "DoanhThu";
                        col.DefaultCellStyle.Format = "N0";
                        dgvbaocao.Columns.Add(col);
                    }

                    dgvbaocao.DataSource = reportData;

                    decimal tongDoanhThu = reportData.Sum(x => x.DoanhThu);
                    lbltongdoanhthu.Text = tongDoanhThu.ToString("N0") + " VND";

                    // Giả sử lợi nhuận = 20% doanh thu
                    decimal loiNhuan = tongDoanhThu * 0.2m;
                    lblloinhuan.Text = loiNhuan.ToString("N0") + " VND";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
