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
using System.Drawing.Printing;

namespace LTQL_DOAN.Forms
{
    public partial class frmhoadon_chitiet : Form
    {
        public frmhoadon_chitiet(int maHoaDon = 0)
        {
            InitializeComponent();
            btnthoat.Click += btnthoat_Click;
            btninhoadon.Click += btninhoadon_Click;
            this.WindowState = FormWindowState.Maximized;
            id = maHoaDon;
        }

        private void frmhoadon_chitiet_Resize(object sender, EventArgs e)
        {
            int screenCenter = this.ClientSize.Width / 2;
            int sectionWidth = 1080;
            int startX = screenCenter - sectionWidth / 2;

            if (startX < 10) startX = 10;

           
            groupBox2.Width = sectionWidth;
            groupBox2.Location = new Point(startX, 10);

            
            groupBox1.Width = sectionWidth;
            groupBox1.Location = new Point(startX, groupBox2.Bottom + 10);
            groupBox1.Height = Math.Max(300, this.ClientSize.Height - groupBox1.Top - 80);

           
            int inputY = 40;
            label4.Location = new Point(15, inputY);
            cbosanpham.Location = new Point(15, inputY + 30);
            
            label5.Location = new Point(275, inputY);
            numdongiaban.Location = new Point(275, inputY + 30);
            
            label6.Location = new Point(475, inputY);
            numsoluong.Location = new Point(475, inputY + 30);
            
            btnxacnhan.Location = new Point(700, inputY + 28);
            btnxoa.Location = new Point(865, inputY + 28);

           
            dataGridView2.Location = new Point(10, inputY + 75);
            dataGridView2.Width = groupBox1.Width - 20;
            dataGridView2.Height = groupBox1.Height - dataGridView2.Top - 15;

           
            int btnGroupWidth = btnluuhoadon.Width + btninhoadon.Width + btnthoat.Width + 40;
            int btnX = screenCenter - btnGroupWidth / 2;
            int btnY = groupBox1.Bottom + 15;

            btnluuhoadon.Location = new Point(btnX, btnY);
            btninhoadon.Location = new Point(btnluuhoadon.Right + 20, btnY);
            btnthoat.Location = new Point(btninhoadon.Right + 20, btnY);
        }
        QUANLYCHSDbContext context = new QUANLYCHSDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        int id;                                         // Lấy mã hóa đơn (dùng cho Sửa và Xóa) 
        BindingList<ChiTietHoaDon> hoaDonChiTiet = new BindingList<ChiTietHoaDon>();

        public void LayNhanVienVaoComboBox()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    cbonhanvien.ValueMember = "ID";
                    cbonhanvien.DisplayMember = "HoVaTen";
                    cbonhanvien.DataSource = db.NhanVien.ToList();
                }
            }
            catch { }
        }

        public void LayKhachHangVaoComboBox()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    cbokhachhang.ValueMember = "ID";
                    cbokhachhang.DisplayMember = "HoVaTen";
                    cbokhachhang.DataSource = db.KhachHang.ToList();
                }
            }
            catch { }
        }

        public void LaySanPhamVaoComboBox()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    cbosanpham.ValueMember = "ID";
                    cbosanpham.DisplayMember = "TenSach";
                    cbosanpham.DataSource = db.Sach.ToList();
                }
            }
            catch { }
        }

        public void BatTatChucNang()
        {
            if (id == 0 && hoaDonChiTiet.Count == 0)
            {
                cbokhachhang.SelectedIndex = -1;
                cbonhanvien.SelectedIndex = -1;
                cbosanpham.SelectedIndex = -1;
                numsoluong.Value = 1;
                numdongiaban.Value = 0;
            }

            btnluuhoadon.Enabled = hoaDonChiTiet.Count > 0;
            btnxoa.Enabled = hoaDonChiTiet.Count > 0;
        }

        private void frmhoadon_chitiet_Load(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = false;
            
           
            if (dataGridView2.Columns.Contains("ChitietMaHoaDon")) dataGridView2.Columns["ChitietMaHoaDon"].DataPropertyName = "HoaDonID";
            if (dataGridView2.Columns.Contains("ChiTietSanPham")) dataGridView2.Columns["ChiTietSanPham"].DataPropertyName = "TenSach";
            if (dataGridView2.Columns.Contains("ChiTietSoLuong")) dataGridView2.Columns["ChiTietSoLuong"].DataPropertyName = "SoLuongBan";
            if (dataGridView2.Columns.Contains("DonGiaBan")) dataGridView2.Columns["DonGiaBan"].DataPropertyName = "DonGiaBan";
            if (dataGridView2.Columns.Contains("ThanhTien")) dataGridView2.Columns["ThanhTien"].DataPropertyName = "ThanhTien";

            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();

            if (id != 0)
            {
                try
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        var hoaDon = db.HoaDon.Find(id);
                        if (hoaDon != null)
                        {
                            cbonhanvien.SelectedValue = hoaDon.NhanVienID;
                            cbokhachhang.SelectedValue = hoaDon.KhachHangID;
                            txtghichu.Text = hoaDon.GhiChuHoaDon;

                            var ct = db.ChiTietHoaDon.Where(r => r.HoaDonID == id).Select(r => new ChiTietHoaDon
                            {
                                ID = r.ID,
                                HoaDonID = r.HoaDonID,
                                SanPhamID = r.SanPhamID,
                                TenSach = r.Sach.TenSach,
                                SoLuongBan = r.SoLuongBan,
                                DonGiaBan = r.DonGiaBan,
                                ThanhTien = (int)(r.SoLuongBan * r.DonGiaBan)
                            }).ToList();

                            hoaDonChiTiet = new BindingList<ChiTietHoaDon>(ct);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải chi tiết hóa đơn: " + ex.Message);
                }
            }

            dataGridView2.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;

            var item = (ChiTietHoaDon)dataGridView2.CurrentRow.DataBoundItem;
            if (item != null)
            {
                hoaDonChiTiet.Remove(item);
                BatTatChucNang();
            }
        }

        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            if (cbonhanvien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbokhachhang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    HoaDon hd;
                    bool isNew = id == 0;

                    if (!isNew)
                    {
                        hd = db.HoaDon.Include(h => h.ChiTietHoaDon).FirstOrDefault(h => h.ID == id);
                        if (hd == null) return;
                        
                        
                        db.ChiTietHoaDon.RemoveRange(hd.ChiTietHoaDon);
                    }
                    else
                    {
                        hd = new HoaDon();
                        hd.NgayLap = DateTime.Now;
                        db.HoaDon.Add(hd);
                    }

                 
                    hd.NhanVienID = (int)cbonhanvien.SelectedValue;
                    hd.KhachHangID = (int)cbokhachhang.SelectedValue;
                    hd.GhiChuHoaDon = txtghichu.Text;
                    
                    
                    hd.HoVaTenNhanVien = cbonhanvien.GetItemText(cbonhanvien.SelectedItem);
                    hd.HoVaTenKhachHang = cbokhachhang.GetItemText(cbokhachhang.SelectedItem);
                   
                    if (string.IsNullOrEmpty(hd.HoVaTenNhanVien)) hd.HoVaTenNhanVien = "NV_" + hd.NhanVienID;
                    if (string.IsNullOrEmpty(hd.HoVaTenKhachHang)) hd.HoVaTenKhachHang = "KH_" + hd.KhachHangID;

                   
                    foreach (var item in hoaDonChiTiet)
                    {
                        var ct = new ChiTietHoaDon
                        {
                           
                            SanPhamID = item.SanPhamID,
                            SachID = item.SanPhamID, 
                            SoLuongBan = item.SoLuongBan,
                            SoLuong = item.SoLuongBan,
                            
                            DonGiaBan = item.DonGiaBan,
                            GiaBan = item.DonGiaBan,
                            
                            TenSach = !string.IsNullOrEmpty(item.TenSach) ? item.TenSach : "Sách",
                            ThanhTien = item.ThanhTien,
                            
                            MaCTHD = 0,
                            MaHoaDon = 0, 
                            MaSach = item.SanPhamID
                        };
                        hd.ChiTietHoaDon.Add(ct);
                    }

                   
                    db.SaveChanges();
                    
                    MessageBox.Show("Đã lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Lỗi khi lưu hóa đơn:");
                sb.AppendLine("- Message: " + ex.Message);
                
                if (ex.InnerException != null)
                {
                    sb.AppendLine("- Inner Exception: " + ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        sb.AppendLine("- Deep Inner: " + ex.InnerException.InnerException.Message);
                    }
                }

                MessageBox.Show(sb.ToString(), "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbosanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbosanpham.SelectedValue == null || cbosanpham.SelectedValue is Sach) return;

            try
            {
                int maSach = (int)cbosanpham.SelectedValue;
                using (var db = new QUANLYCHSDbContext())
                {
                    var sach = db.Sach.Find(maSach);
                    if (sach != null)
                    {
                        numdongiaban.Value = sach.DonGiaBan;
                    }
                }
            }
            catch { }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (cbosanpham.SelectedValue == null || cbosanpham.SelectedValue is Sach)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSanPham = (int)cbosanpham.SelectedValue;
            var existing = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);

            if (existing != null)
            {
                existing.SoLuongBan = (short)numsoluong.Value;
                existing.DonGiaBan = (int)numdongiaban.Value;
                existing.ThanhTien = (int)(numsoluong.Value * numdongiaban.Value);
                dataGridView2.Refresh();
            }
            else
            {
                hoaDonChiTiet.Add(new ChiTietHoaDon
                {
                    HoaDonID = id,
                    SanPhamID = maSanPham,
                    TenSach = cbosanpham.Text,
                    SoLuongBan = (short)numsoluong.Value,
                    DonGiaBan = (int)numdongiaban.Value,
                    ThanhTien = (int)(numsoluong.Value * numdongiaban.Value)
                });
            }
            BatTatChucNang();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0 || hoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu chi tiết hóa đơn để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintInvoice_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.Width = 800;
            previewDialog.Height = 600;
            previewDialog.ShowDialog();
        }

        private void PrintInvoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fontNormal = new Font("Courier New", 10, FontStyle.Regular); // Courier New looks closer to receipt alignment
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

           
            string invoiceIdText = id > 0 ? id.ToString() : "Mới";
            g.DrawString($"Số HD       : {invoiceIdText}", fontNormal, Brushes.Black, xPos, yPos);
            yPos += 20;
            
            string invoiceDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            try
            {
                if (id > 0)
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        var hd = db.HoaDon.Find(id);
                        if(hd != null) invoiceDate = hd.NgayLap.ToString("dd/MM/yyyy HH:mm");
                    }
                }
            } catch { }

            g.DrawString($"Ngày lập    : {invoiceDate}", fontNormal, Brushes.Black, xPos, yPos);
            yPos += 20;
            g.DrawString($"Thu ngân    : {cbonhanvien.Text}", fontNormal, Brushes.Black, xPos, yPos);
            yPos += 20;
            g.DrawString($"Khách hàng  : {cbokhachhang.Text}", fontNormal, Brushes.Black, xPos, yPos);
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

            foreach (var item in hoaDonChiTiet)
            {
                string tenSp = item.TenSach;
                if (tenSp.Length > 40) tenSp = tenSp.Substring(0, 40) + "...";

                g.DrawString(tenSp, fontNormal, Brushes.Black, col1, yPos);
                g.DrawString(item.SoLuongBan.ToString(), fontNormal, Brushes.Black, col2, yPos);
                g.DrawString(item.DonGiaBan.ToString("N0"), fontNormal, Brushes.Black, col3, yPos);
                g.DrawString(item.ThanhTien.ToString("N0"), fontNormal, Brushes.Black, col4, yPos);
                yPos += 30;
            }

            
            yPos += 5;
            g.DrawLine(new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }, xPos, yPos, e.PageBounds.Width - xPos, yPos);
            yPos += 20;

            double total = hoaDonChiTiet.Sum(x => x.ThanhTien);
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
