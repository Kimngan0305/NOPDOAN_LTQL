using LTQL_DOAN.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LTQL
{
    public partial class frmquanlyloaisach : Form
    {
        public frmquanlyloaisach()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmquanlyloaisach_Resize(object sender, EventArgs e)
        {
            
            int contentWidth = 1100;
            int startX = (this.ClientSize.Width - contentWidth) / 2;
            int bottomY = this.ClientSize.Height - 150;

            if (startX < 0) startX = 12;
            if (bottomY < dgvloaisach.Bottom + 10) bottomY = dgvloaisach.Bottom + 10;

            label2.Location = new Point(startX, bottomY);
            txtthemloaisach.Location = new Point(startX + 194, bottomY - 3);
            btnthemloaisach.Location = new Point(startX + 956, bottomY - 3);
            
            label3.Location = new Point(startX + 14, bottomY + 70);
            cboxoaloaisach.Location = new Point(startX + 194, bottomY + 67);
            btnxoaloaisach.Location = new Point(startX + 956, bottomY + 67);
        }

        private void frmquanlyloaisach_Load(object sender, EventArgs e)
        {
            LoadLoai();
        }

        private void LoadLoai()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    var data = db.Loai.ToList();

                 
                    dgvloaisach.AutoGenerateColumns = false;
                    dgvloaisach.Columns["ID"].DataPropertyName = "ID";
                    dgvloaisach.Columns["MaLoai"].DataPropertyName = "MaLoai";
                    dgvloaisach.Columns["TenLoai"].DataPropertyName = "TenLoai";
                    dgvloaisach.DataSource = data.Select(l => new
                    {
                        l.ID,
                        l.MaLoai,
                        l.TenLoai
                    }).ToList();

                    
                    cboxoaloaisach.DataSource = data;
                    cboxoaloaisach.DisplayMember = "TenLoai";
                    cboxoaloaisach.ValueMember = "ID"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemloaisach_Click(object sender, EventArgs e)
        {
            string tenLoai = txtthemloaisach.Text.Trim();

            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập tên loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtthemloaisach.Focus();
                return;
            }

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    Loai l = new Loai();
                    l.TenLoai = tenLoai;

                    
                    if (db.Loai.Any())
                    {
                        l.MaLoai = db.Loai.Max(x => x.MaLoai) + 1;
                    }
                    else
                    {
                        l.MaLoai = 1;
                    }

                    db.Loai.Add(l);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtthemloaisach.Clear();
                    LoadLoai();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại sách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoaloaisach_Click(object sender, EventArgs e)
        {
            if (cboxoaloaisach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)cboxoaloaisach.SelectedValue;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        Loai l = db.Loai.Find(id);

                        if (l != null)
                        {
                            db.Loai.Remove(l);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLoai();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa loại sách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
