using Microsoft.Data.SqlClient;
using LTQL_DOAN.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTQL
{
    public partial class frmthongke : Form
    {
        public frmthongke()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            btnthoat.Click += (s, e) => this.Close();
        }

        private void frmthongke_Resize(object sender, EventArgs e)
        {
           
            int topBarWidth = 1000;
            int startX = (this.ClientSize.Width - topBarWidth) / 2;
            if (startX < 0) startX = 12;

            label1.Location = new Point(startX, 68);
            dtptungay.Location = new Point(startX + 105, 62);
            label2.Location = new Point(startX + 327, 68);
            dtpdenngay.Location = new Point(startX + 447, 62);
            btntimkiem.Location = new Point(startX + 673, 50);

         
            int bottomBtnWidth = btnxuatthongke.Width + btnthoat.Width + 20;
            int startXBottom = (this.ClientSize.Width - bottomBtnWidth) / 2;
            int bottomY = this.ClientSize.Height - 60;

            if (bottomY < dgvthongke.Bottom + 10) bottomY = dgvthongke.Bottom + 10;

            btnxuatthongke.Location = new Point(startXBottom, bottomY);
            btnthoat.Location = new Point(startXBottom + btnxuatthongke.Width + 20, bottomY);
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dgvthongke.AutoGenerateColumns = false;
            
           
            if (dgvthongke.Columns.Contains("ThongKeMaHoaDon")) dgvthongke.Columns["ThongKeMaHoaDon"].DataPropertyName = "MaHDText";
            if (dgvthongke.Columns.Contains("ThongKeTenKhachHang")) dgvthongke.Columns["ThongKeTenKhachHang"].DataPropertyName = "HoVaTenKhachHang";
            if (dgvthongke.Columns.Contains("ThongKeNgayLap"))
            {
                dgvthongke.Columns["ThongKeNgayLap"].DataPropertyName = "NgayLap";
                dgvthongke.Columns["ThongKeNgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
            }
            if (dgvthongke.Columns.Contains("ThongKetongTien"))
            {
                dgvthongke.Columns["ThongKetongTien"].DataPropertyName = "TongTienHoaDon";
                dgvthongke.Columns["ThongKetongTien"].DefaultCellStyle.Format = "N2";
            }

            dtptungay.Value = DateTime.Today.AddMonths(-1);
            dtpdenngay.Value = DateTime.Today;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    DateTime tuNgay = dtptungay.Value.Date;
                    DateTime denNgay = dtpdenngay.Value.Date.AddDays(1).AddSeconds(-1);

                   
                    var rawInvoices = db.HoaDon
                        .Include(h => h.KhachHang)
                        .Include(h => h.ChiTietHoaDon)
                        .Where(h => h.NgayLap >= tuNgay && h.NgayLap <= denNgay)
                        .ToList();

                    
                    var results = rawInvoices.Select(h => new 
                    {
                        h.ID,
                        MaHDText = "HD" + h.ID.ToString("D4"),
                        HoVaTenKhachHang = h.KhachHang != null ? h.KhachHang.HoVaTen : "N/A",
                        h.NgayLap,
                        TongTienHoaDon = (double)h.ChiTietHoaDon.Sum(c => (double)c.SoLuongBan * c.DonGiaBan)
                    }).ToList();

                    dgvthongke.DataSource = results;

                    if (results.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn nào trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxuatthongke_Click(object sender, EventArgs e)
        {
            if (dgvthongke.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            var total = 0.0;
            foreach (DataGridViewRow row in dgvthongke.Rows)
            {
                total += Convert.ToDouble(row.Cells["ThongKetongTien"].Value ?? 0);
            }

            MessageBox.Show($"Đã xuất tổng cộng {dgvthongke.Rows.Count} hóa đơn.\nTổng doanh thu: {total.ToString("N0")} VNĐ", 
                "Xuất báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    

}
