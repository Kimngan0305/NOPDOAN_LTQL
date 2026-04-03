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
    public partial class frmquanlykho : Form
    {
        public frmquanlykho()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            btnchonsua.Click += btnchonsua_Click;
        }

        private void frmquanlykho_Resize(object sender, EventArgs e)
        {
            dgvkho.Location = new Point(12, 10);
            dgvkho.Size = new Size(this.ClientSize.Width - 24, (int)(this.ClientSize.Height * 0.35));

            int startY = dgvkho.Bottom + 15;
            int screenCenter = this.ClientSize.Width / 2;

           
            // Actions: Chọn sửa, Xóa
            int gap = 20;
            int editBtnGroupWidth = btnchonsua.Width + btnxoasachkho.Width + gap;
            btnchonsua.Location = new Point(screenCenter - editBtnGroupWidth / 2, startY);
            btnxoasachkho.Location = new Point(btnchonsua.Right + gap, startY);

            // Inputs: Ma Sach
            startY = btnchonsua.Bottom + 15;
            int rowMaWidth = label1.Width + txtmasachkho.Width + 10;
            label1.Location = new Point(screenCenter - rowMaWidth / 2, startY + 5);
            txtmasachkho.Location = new Point(label1.Right + 5, startY);

            // Inputs: So Luong, Luu
            startY = txtmasachkho.Bottom + 10;
            int rowSoLuongWidth = label2.Width + numsoluongkho.Width + btnluukho.Width + 25;
            label2.Location = new Point(screenCenter - rowSoLuongWidth / 2, startY + 5);
            numsoluongkho.Location = new Point(label2.Right + 5, startY);
            btnluukho.Location = new Point(numsoluongkho.Right + 15, startY - 3);

           
            startY = btnluukho.Bottom + 20;
            btnchonthemkho.Location = new Point(screenCenter - btnchonthemkho.Width / 2, startY);

            startY = btnchonthemkho.Bottom + 10;
            groupBox1.Width = Math.Min(this.ClientSize.Width - 40, 1050);
            groupBox1.Location = new Point(screenCenter - groupBox1.Width / 2, startY);
            groupBox1.Height = Math.Max(120, this.ClientSize.Height - groupBox1.Top - 85);
            
            
            dgvchonsach.Size = new Size(groupBox1.Width - 30, groupBox1.Height - 45);
            dgvchonsach.Location = new Point(15, 30);

           
            startY = groupBox1.Bottom + 10;
            int addInputRowWidth = label3.Width + txtmasach.Width + label4.Width + numsoluong.Width + btnthemvaokho.Width + 50;
            
            if (addInputRowWidth > this.ClientSize.Width - 20)
            {
                
                label3.Location = new Point(screenCenter - 250, startY + 5);
                txtmasach.Location = new Point(label3.Right + 5, startY);
                startY = txtmasach.Bottom + 5;
                int subRow = label4.Width + numsoluong.Width + btnthemvaokho.Width + 20;
                label4.Location = new Point(screenCenter - subRow/2, startY + 5);
                numsoluong.Location = new Point(label4.Right + 5, startY);
                btnthemvaokho.Location = new Point(numsoluong.Right + 10, startY - 3);
            }
            else
            {
                label3.Location = new Point(screenCenter - addInputRowWidth / 2, startY + 5);
                txtmasach.Location = new Point(label3.Right + 5, startY);
                label4.Location = new Point(txtmasach.Right + 15, startY + 5);
                numsoluong.Location = new Point(label4.Right + 5, startY);
                btnthemvaokho.Location = new Point(numsoluong.Right + 15, startY - 3);
            }
        }

        private void LoadData()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                  
                    var khoData = db.Kho.Include(k => k.Sach).Select(k => new
                    {
                        k.MaSach,
                        TenSach = k.Sach != null ? k.Sach.TenSach : "N/A",
                        k.SoLuong
                    }).ToList();
                    dgvkho.DataSource = khoData;

                    var sachData = db.Sach
                        .Include(s => s.TacGia)
                        .Include(s => s.LinhVuc)
                        .Include(s => s.Loai)
                        .Include(s => s.NhaXuatBan)
                        .Include(s => s.Khos)
                        .Select(s => new
                        {
                            s.MaSach,
                            s.TenSach,
                            TacGia = s.TacGia != null ? s.TacGia.TenTacGia : "N/A",
                            LinhVuc = s.LinhVuc != null ? s.LinhVuc.TenLinhVuc : "N/A",
                            Loai = s.Loai != null ? s.Loai.TenLoai : "N/A",
                            NhaXuatBan = s.NhaXuatBan != null ? s.NhaXuatBan.TenNXB : "N/A",
                            s.DonGiaBan,
                            SoLuongTon = s.Khos.Sum(k => k.SoLuong)
                        })
                        .ToList();
                    dgvchonsach.DataSource = sachData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmquanlykho_Load(object sender, EventArgs e)
        {
            dgvkho.AutoGenerateColumns = false;
            dgvchonsach.AutoGenerateColumns = false;

            // Map dgvkho columns
            if (dgvkho.Columns.Contains("MaSach")) dgvkho.Columns["MaSach"].DataPropertyName = "MaSach";
            if (dgvkho.Columns.Contains("TenSach")) dgvkho.Columns["TenSach"].DataPropertyName = "TenSach";
            if (dgvkho.Columns.Contains("SoLuong")) dgvkho.Columns["SoLuong"].DataPropertyName = "SoLuong";

            // Map dgvchonsach columns
            if (dgvchonsach.Columns.Contains("ChonMaSach")) dgvchonsach.Columns["ChonMaSach"].DataPropertyName = "MaSach";
            if (dgvchonsach.Columns.Contains("ChonTenSach")) dgvchonsach.Columns["ChonTenSach"].DataPropertyName = "TenSach";
            if (dgvchonsach.Columns.Contains("TenTacGia")) dgvchonsach.Columns["TenTacGia"].DataPropertyName = "TacGia";
            if (dgvchonsach.Columns.Contains("TenLinhVuc")) dgvchonsach.Columns["TenLinhVuc"].DataPropertyName = "LinhVuc";
            if (dgvchonsach.Columns.Contains("TenLoai")) dgvchonsach.Columns["TenLoai"].DataPropertyName = "Loai";
            if (dgvchonsach.Columns.Contains("TenNXB")) dgvchonsach.Columns["TenNXB"].DataPropertyName = "NhaXuatBan";
            if (dgvchonsach.Columns.Contains("GiaBan")) 
            {
                dgvchonsach.Columns["GiaBan"].DataPropertyName = "DonGiaBan";
                dgvchonsach.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
            }
            if (dgvchonsach.Columns.Contains("SoLuongTon")) dgvchonsach.Columns["SoLuongTon"].DataPropertyName = "SoLuongTon";

            LoadData();
        }

        private void btnchonsua_Click(object sender, EventArgs e)
        {
            if (dgvkho.CurrentRow != null)
            {
                txtmasachkho.Text = dgvkho.CurrentRow.Cells["MaSach"].Value?.ToString();
                numsoluongkho.Value = Convert.ToDecimal(dgvkho.CurrentRow.Cells["SoLuong"].Value ?? 0);
            }
        }

        private void btnchonthemkho_Click(object sender, EventArgs e)
        {
            if (dgvchonsach.CurrentRow != null)
            {
                txtmasach.Text = dgvchonsach.CurrentRow.Cells["ChonMaSach"].Value?.ToString();
                numsoluong.Value = 1;
            }
        }

        private void btnluukho_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmasachkho.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    string ma = txtmasachkho.Text;
                    var k = db.Kho.FirstOrDefault(x => x.MaSach == ma);

                    if (k != null)
                    {
                        k.SoLuong = (int)numsoluongkho.Value;
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật số lượng kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoasachkho_Click(object sender, EventArgs e)
        {
            if (dgvkho.CurrentRow == null) return;
            string ma = dgvkho.CurrentRow.Cells["MaSach"].Value?.ToString();
            
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show($"Bạn có chắc muốn xóa sách {ma} khỏi kho?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        var k = db.Kho.FirstOrDefault(x => x.MaSach == ma);
                        if (k != null)
                        {
                            db.Kho.Remove(k);
                            db.SaveChanges();
                            MessageBox.Show("Đã xóa khỏi kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthemvaokho_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmasach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    string ma = txtmasach.Text;
                    int sl = (int)numsoluong.Value;

                    var kho = db.Kho.FirstOrDefault(x => x.MaSach == ma);
                    if (kho != null)
                    {
                        kho.SoLuong += sl;
                    }
                    else
                    {
                        // Lấy SachID thực tế từ bảng Sach dựa trên MaSach
                        var sach = db.Sach.FirstOrDefault(s => s.MaSach == ma);
                        if (sach == null)
                        {
                            MessageBox.Show("Không tìm thấy mã sách hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                        db.Kho.Add(new Kho { 
                            MaSach = ma, 
                            SoLuong = sl,
                            SachID = sach.ID,
                            TenKho = "Chính" 
                        });
                    }

                    db.SaveChanges();
                    MessageBox.Show("Đã thêm vào kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvkho_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvchonsach_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
