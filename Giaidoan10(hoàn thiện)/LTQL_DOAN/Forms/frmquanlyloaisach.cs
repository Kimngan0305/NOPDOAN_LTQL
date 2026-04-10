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
            int contentWidth = 1085;
            int startX = (this.ClientSize.Width - contentWidth) / 2;
            if (startX < 0) startX = 12;

            int currentY = 20;
            label1.Location = new Point(startX, currentY);
            currentY = label1.Bottom + 15;

            int bottomControlsHeight = 180;
            int dgvHeight = this.ClientSize.Height - currentY - bottomControlsHeight;
            if (dgvHeight < 150) dgvHeight = 150; 

            dgvloaisach.Location = new Point(startX, currentY);
            dgvloaisach.Size = new Size(contentWidth, dgvHeight);

            int bottomY = dgvloaisach.Bottom + 30;

            label2.Location = new Point(startX, bottomY + 5);
            txtthemloaisach.Location = new Point(startX + 150, bottomY);
            txtthemloaisach.Width = 789;
            btnthemloaisach.Location = new Point(txtthemloaisach.Right + 17, bottomY);

            int row2Y = bottomY + 64; 
            label3.Location = new Point(startX + 14, row2Y + 5);
            cboxoaloaisach.Location = new Point(startX + 150, row2Y);
            cboxoaloaisach.Width = 789;
            btnxoaloaisach.Location = new Point(cboxoaloaisach.Right + 17, row2Y);

            int row3Y = row2Y + 56; 
            btnthoat.Location = new Point(cboxoaloaisach.Right + 17, row3Y);
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

