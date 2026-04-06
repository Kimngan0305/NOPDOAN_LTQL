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
using System.IO;
using System.Drawing.Printing;

namespace LTQL_DOAN.Forms
{
    public partial class frmhoadon : Form
    {
        public frmhoadon()
        {
            InitializeComponent();
            btninhoadon.Click += btninhoadon_Click;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmhoadon_Resize(object sender, EventArgs e)
        {
            
            int totalBtnWidth = btnlaphoadon.Width + btnsua.Width + btninhoadon.Width + btnxuat.Width + btnxoa.Width + btnthoat.Width + 50;
            int startX = (this.ClientSize.Width - totalBtnWidth) / 2;
            
            
            int bottomY = this.ClientSize.Height - 85; 

            if (startX < 0) startX = 12;
            
            
            if (bottomY < groupBox1.Bottom + 10) 
            {
                
            }

            btnlaphoadon.Location = new Point(startX, bottomY);
            btnsua.Location = new Point(btnlaphoadon.Right + 10, bottomY);
            btninhoadon.Location = new Point(btnsua.Right + 10, bottomY);
            btnxuat.Location = new Point(btninhoadon.Right + 10, bottomY);
            btnxoa.Location = new Point(btnxuat.Right + 10, bottomY);
            btnthoat.Location = new Point(btnxoa.Right + 10, bottomY);
        }
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            
          
            if (dataGridView1.Columns.Contains("ID")) dataGridView1.Columns["ID"].DataPropertyName = "ID";
            if (dataGridView1.Columns.Contains("HoVaTenKhachHang")) dataGridView1.Columns["HoVaTenKhachHang"].DataPropertyName = "HoVaTenKhachHang";
            if (dataGridView1.Columns.Contains("NgayLap")) dataGridView1.Columns["NgayLap"].DataPropertyName = "NgayLap";
            if (dataGridView1.Columns.Contains("TongTienHoaDon")) dataGridView1.Columns["TongTienHoaDon"].DataPropertyName = "TongTienHoaDon";
            if (dataGridView1.Columns.Contains("XemChiTiet")) dataGridView1.Columns["XemChiTiet"].DataPropertyName = "XemChiTiet";

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                   
                    var rawInvoices = db.HoaDon
                        .Include(r => r.NhanVien)
                        .Include(r => r.KhachHang)
                        .Include(r => r.ChiTietHoaDon)
                        .ToList(); 
                    var hdList = rawInvoices.Select(r => new HoaDon
                    {
                        ID = r.ID,
                        NhanVienID = r.NhanVienID,
                        HoVaTenNhanVien = r.NhanVien != null ? r.NhanVien.HoVaTen : "N/A",
                        KhachHangID = r.KhachHangID,
                        HoVaTenKhachHang = r.KhachHang != null ? r.KhachHang.HoVaTen : "N/A",
                        NgayLap = r.NgayLap,
                        GhiChuHoaDon = r.GhiChuHoaDon,
                        
                        TongTienHoaDon = r.ChiTietHoaDon.Sum(c => (double)c.SoLuongBan * c.DonGiaBan),
                        XemChiTiet = "Xem chi tiết"
                    }).ToList();

                    dataGridView1.DataSource = hdList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlaphoadon_Click(object sender, EventArgs e)
        {
            using (frmhoadon_chitiet chiTiet = new frmhoadon_chitiet())
            {
                if (chiTiet.ShowDialog() == DialogResult.OK || chiTiet.DialogResult == DialogResult.Cancel)
                {
                    LoadData(); 
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            using (frmhoadon_chitiet chiTiet = new frmhoadon_chitiet(id))
            {
                chiTiet.ShowDialog();
                LoadData();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này và tất cả chi tiết liên quan?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        var hoadon = db.HoaDon.Find(id);
                        if (hoadon != null)
                        {
                            db.HoaDon.Remove(hoadon);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel CSV Files|*.csv";
            saveFileDialog.Title = "Lưu danh sách hóa đơn";
            saveFileDialog.FileName = "DanhSachHoaDon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, new UTF8Encoding(true)))
                    {
                        var headerList = new List<string>();
                        for (int j = 1; j < dataGridView1.Columns.Count; j++)
                        {
                            headerList.Add(dataGridView1.Columns[j].HeaderText);
                        }
                        sw.WriteLine(string.Join(",", headerList));

                       
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cellList = new List<string>();
                                for (int j = 1; j < dataGridView1.Columns.Count; j++)
                                {
                                    string value = row.Cells[j].Value?.ToString() ?? "";
                                  
                                    cellList.Add("\"" + value.Replace("\"", "\"\"") + "\"");
                                }
                                sw.WriteLine(string.Join(",", cellList));
                            }
                        }
                    }

                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (dataGridView1.Columns[e.ColumnIndex].Name == "XemChiTiet" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                using (frmhoadon_chitiet chiTiet = new frmhoadon_chitiet(id))
                {
                    chiTiet.ShowDialog();
                    LoadData(); 
                }
            }
        }

        private HoaDon documentHoaDonToPrint = null;
        private List<ChiTietHoaDon> documentChiTietToPrint = null;

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    // Lấy thông tin hóa đơn và chi tiết
                    documentHoaDonToPrint = db.HoaDon
                                              .Include(h => h.NhanVien)
                                              .Include(h => h.KhachHang)
                                              .FirstOrDefault(h => h.ID == id);

                    if (documentHoaDonToPrint == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    documentChiTietToPrint = db.ChiTietHoaDon
                                               .Include(c => c.Sach)
                                               .Where(c => c.HoaDonID == id)
                                               .ToList();
                }

                // Show Print Preview
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintInvoice_PrintPage);

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDocument;
                previewDialog.Width = 800;
                previewDialog.Height = 600;
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu in: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintInvoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (documentHoaDonToPrint == null || documentChiTietToPrint == null) return;

            Graphics g = e.Graphics;
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fontNormal = new Font("Courier New", 10, FontStyle.Regular);
            Font fontNormalBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontItalic = new Font("Arial", 10, FontStyle.Italic);

            int yPos = 60;
            int xPos = 50;

           
            g.DrawString("CỬA HÀNG SÁCH Phan Kim Ngân", fontHeader, Brushes.Black, xPos, yPos);
            yPos += 20;
            g.DrawString("Địa chỉ: Đại học An Giang, TP. Long Xuyên", fontNormal, Brushes.Black, xPos, yPos);
            yPos += 40;

           
            string title = "HÓA ĐƠN BÁN HÀNG";
            SizeF titleSize = g.MeasureString(title, fontTitle);
            g.DrawString(title, fontTitle, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, yPos);
            yPos += 40;

           
            string invoiceIdText = documentHoaDonToPrint.ID.ToString();
            g.DrawString($"Số HD       : {invoiceIdText}", fontNormal, Brushes.Black, xPos, yPos);
            yPos += 20;
            
            string invoiceDate = documentHoaDonToPrint.NgayLap.ToString("dd/MM/yyyy HH:mm");
            g.DrawString($"Ngày lập    : {invoiceDate}", fontNormal, Brushes.Black, xPos, yPos);
            yPos += 20;

            string tenNhanVien = documentHoaDonToPrint.HoVaTenNhanVien;
            if(string.IsNullOrEmpty(tenNhanVien) && documentHoaDonToPrint.NhanVien != null)
                tenNhanVien = documentHoaDonToPrint.NhanVien.HoVaTen;

            string tenKhachHang = documentHoaDonToPrint.HoVaTenKhachHang;
            if(string.IsNullOrEmpty(tenKhachHang) && documentHoaDonToPrint.KhachHang != null)
                tenKhachHang = documentHoaDonToPrint.KhachHang.HoVaTen;

            g.DrawString($"Thu ngân    : {tenNhanVien}", fontNormal, Brushes.Black, xPos, yPos);
            yPos += 20;
            g.DrawString($"Khách hàng  : {tenKhachHang}", fontNormal, Brushes.Black, xPos, yPos);
            yPos += 40;

           
            int col1 = xPos;
            int col2 = xPos + 380; // SL
            int col3 = xPos + 480; // Đơn giá
            int col4 = xPos + 620; // Thành tiền

            
            g.DrawLine(new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }, xPos, yPos, e.PageBounds.Width - xPos, yPos);
            yPos += 15;

            g.DrawString("Tên Sản Phẩm", fontNormalBold, Brushes.Black, col1, yPos);
            g.DrawString("SL", fontNormalBold, Brushes.Black, col2, yPos);
            g.DrawString("Đơn Giá", fontNormalBold, Brushes.Black, col3, yPos);
            g.DrawString("Thành Tiền", fontNormalBold, Brushes.Black, col4, yPos);
            yPos += 25;

        
            g.DrawLine(new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }, xPos, yPos, e.PageBounds.Width - xPos, yPos);
            yPos += 20;

           
            foreach (var item in documentChiTietToPrint)
            {
                string tenSp = item.TenSach;
                if(string.IsNullOrEmpty(tenSp) && item.Sach != null)
                    tenSp = item.Sach.TenSach;

                if (tenSp.Length > 40) tenSp = tenSp.Substring(0, 40) + "...";

                g.DrawString(tenSp, fontNormal, Brushes.Black, col1, yPos);
                g.DrawString(item.SoLuongBan.ToString(), fontNormal, Brushes.Black, col2, yPos);
                g.DrawString(item.DonGiaBan.ToString("N0"), fontNormal, Brushes.Black, col3, yPos);
                
                int thanhTien = item.ThanhTien;
                if (thanhTien == 0) thanhTien = (int)(item.SoLuongBan * item.DonGiaBan);
                g.DrawString(thanhTien.ToString("N0"), fontNormal, Brushes.Black, col4, yPos);
                yPos += 30;
            }

           
            yPos += 5;
            g.DrawLine(new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }, xPos, yPos, e.PageBounds.Width - xPos, yPos);
            yPos += 20;

           
            double total = documentChiTietToPrint.Sum(x => {
                if (x.ThanhTien > 0) return x.ThanhTien;
                return (double)x.SoLuongBan * x.DonGiaBan;
            });
            Font fontTotal = new Font("Arial", 11, FontStyle.Bold);
            
            g.DrawString("TỔNG CỘNG:", fontTotal, Brushes.Black, col3 - 40, yPos);
            g.DrawString($"{total:N0} VNĐ", fontTotal, Brushes.Black, col4, yPos);

            yPos += 60;

            string footerText = "Cảm ơn quý khách & Hẹn gặp lại!";
            SizeF footerSize = g.MeasureString(footerText, fontItalic);
            g.DrawString(footerText, fontItalic, Brushes.Black, (e.PageBounds.Width - footerSize.Width) / 2, yPos);
        }
    }
}
