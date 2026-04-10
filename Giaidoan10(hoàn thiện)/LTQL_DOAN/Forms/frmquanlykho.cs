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
            int contentWidth = 1008;
            int startX = (this.ClientSize.Width - contentWidth) / 2;
            if (startX < 0) startX = 0;

            // Row 0: dgvkho — chiều cao chiếm 30% màn hình
            int dgvKhoHeight = (int)(this.ClientSize.Height * 0.30);
            if (dgvKhoHeight < 120) dgvKhoHeight = 120;
            dgvkho.Location = new Point(startX + 23, 3);
            dgvkho.Size = new Size(contentWidth - 35, dgvKhoHeight);

            int startY = dgvkho.Bottom + 15;
            int screenCenter = startX + contentWidth / 2;

            // Row 1: Chọn Sửa | Xóa Sách
            btnchonsua.Location = new Point(startX + 27, startY);
            btnxoasachkho.Location = new Point(startX + 611, startY);

            // Row 2: Mã Sách (edit)
            startY = btnchonsua.Bottom + 8;
            label1.Location = new Point(startX + 37, startY + 4);
            txtmasachkho.Location = new Point(startX + 147, startY);

            // Row 3: Số Lượng (edit) + Lưu
            startY = txtmasachkho.Bottom + 8;
            label2.Location = new Point(startX + 23, startY + 4);
            numsoluongkho.Location = new Point(startX + 147, startY);
            btnluukho.Location = new Point(startX + 554, startY - 4);

            // Row 4: groupBox Chọn Sách
            startY = btnluukho.Bottom + 12;
            int groupBoxH = (int)(this.ClientSize.Height * 0.28);
            if (groupBoxH < 120) groupBoxH = 120;
            groupBox1.Location = new Point(startX + 12, startY);
            groupBox1.Size = new Size(contentWidth - 20, groupBoxH);
            dgvchonsach.Size = new Size(groupBox1.Width - 30, groupBox1.Height - 45);
            dgvchonsach.Location = new Point(15, 30);

            // Row 5: Chọn Thêm
            startY = groupBox1.Bottom + 8;
            btnchonthemkho.Location = new Point(startX + 27, startY);

            // Row 6: Mã Sách (thêm mới)
            startY = btnchonthemkho.Bottom + 8;
            label3.Location = new Point(startX + 23, startY + 4);
            txtmasach.Location = new Point(startX + 132, startY);

            // Row 7: Số Lượng (thêm mới) + Thêm + Thoát
            startY = txtmasach.Bottom + 8;
            label4.Location = new Point(startX + 12, startY + 4);
            numsoluong.Location = new Point(startX + 132, startY);
            btnthemvaokho.Location = new Point(startX + 539, startY - 4);
            button1.Location = new Point(startX + 845, btnchonthemkho.Top);
            button1.Size = new Size(140, startY + btnthemvaokho.Height - btnchonthemkho.Top + 4);
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
            if (dgvchonsach.Columns.Contains("ma")) dgvchonsach.Columns["ma"].DataPropertyName = "MaSach";
            if (dgvchonsach.Columns.Contains("ten")) dgvchonsach.Columns["ten"].DataPropertyName = "TenSach";
            if (dgvchonsach.Columns.Contains("Linhvuc")) dgvchonsach.Columns["Linhvuc"].DataPropertyName = "LinhVuc";
            if (dgvchonsach.Columns.Contains("loai")) dgvchonsach.Columns["loai"].DataPropertyName = "Loai";
            if (dgvchonsach.Columns.Contains("nxb")) dgvchonsach.Columns["nxb"].DataPropertyName = "NhaXuatBan";
            if (dgvchonsach.Columns.Contains("GiaBia"))
            {
                dgvchonsach.Columns["GiaBia"].DataPropertyName = "DonGiaBan";
                dgvchonsach.Columns["GiaBia"].DefaultCellStyle.Format = "N0";
            }
            if (dgvchonsach.Columns.Contains("hangton")) dgvchonsach.Columns["hangton"].DataPropertyName = "SoLuongTon";
            txtmasachkho.ReadOnly = true;
            txtmasach.ReadOnly = true;
            dgvkho.CellClick += dgvkho_CellClick;
            dgvchonsach.CellClick += dgvchonsach_CellClick;

            LoadData();
        }

        private void btnchonsua_Click(object sender, EventArgs e)
        {
            LoadKhoSelection();
        }

        private void btnchonthemkho_Click(object sender, EventArgs e)
        {
            LoadSachSelection();
        }

        private void LoadKhoSelection()
        {
            if (dgvkho.CurrentRow != null && dgvkho.CurrentRow.Index >= 0)
            {
                txtmasachkho.Text = dgvkho.CurrentRow.Cells["MaSach"].Value?.ToString();
                numsoluongkho.Value = Convert.ToDecimal(dgvkho.CurrentRow.Cells["SoLuong"].Value ?? 0);
            }
        }

        private void LoadSachSelection()
        {
            if (dgvchonsach.CurrentRow != null && dgvchonsach.CurrentRow.Index >= 0)
            {
                txtmasach.Text = dgvchonsach.CurrentRow.Cells["ma"].Value?.ToString();
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
                        txtmasachkho.Clear();
                        numsoluongkho.Value = 1;
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
            if (dgvkho.CurrentRow == null || dgvkho.CurrentRow.Index < 0) return;
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
                            txtmasachkho.Clear();
                            numsoluongkho.Value = 1;
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

                    if (sl <= 0)
                    {
                        MessageBox.Show("Số lượng thêm phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var kho = db.Kho.FirstOrDefault(x => x.MaSach == ma);
                    if (kho != null)
                    {
                        kho.SoLuong += sl;
                    }
                    else
                    {
                        var sach = db.Sach.FirstOrDefault(s => s.MaSach == ma);
                        if (sach == null)
                        {
                            MessageBox.Show("Không tìm thấy mã sách hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        db.Kho.Add(new Kho
                        {
                            MaSach = ma,
                            SoLuong = sl,
                            SachID = sach.ID,
                            TenKho = "Chính"
                        });
                    }

                    db.SaveChanges();
                    MessageBox.Show("Đã thêm vào kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txtmasach.Clear();
                    numsoluong.Value = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvkho_CellClick(object sender, DataGridViewCellEventArgs e) 
        { 
            LoadKhoSelection();
        }
        
        private void dgvchonsach_CellClick(object sender, DataGridViewCellEventArgs e) 
        { 
            LoadSachSelection();
        }

        private void dgvkho_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        { 
            LoadKhoSelection();
        }
        
        private void dgvchonsach_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        { 
            LoadSachSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
