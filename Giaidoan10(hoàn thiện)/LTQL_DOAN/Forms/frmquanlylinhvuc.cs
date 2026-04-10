using LTQL_DOAN.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LTQL
{
    public partial class frmquanlylinhvuc : Form
    {
        public frmquanlylinhvuc()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmquanlylinhvuc_Resize(object sender, EventArgs e)
        {
            int contentWidth = 1088;
            int startX = (this.ClientSize.Width - contentWidth) / 2;
            if (startX < 0) startX = 12;

            int currentY = 20;
            label1.Location = new Point(startX, currentY);
            currentY = label1.Bottom + 15;

            int bottomControlsHeight = 180;
            int dgvHeight = this.ClientSize.Height - currentY - bottomControlsHeight;
            if (dgvHeight < 150) dgvHeight = 150; 

            dgvlinhvuc.Location = new Point(startX, currentY);
            dgvlinhvuc.Size = new Size(contentWidth, dgvHeight);

            int bottomY = dgvlinhvuc.Bottom + 30;

            label2.Location = new Point(startX, bottomY + 3);
            txtthemlinhvuc.Location = new Point(startX + 139, bottomY);
            txtthemlinhvuc.Width = 786;
            btnthemlinhvuc.Location = new Point(txtthemlinhvuc.Right + 29, bottomY);

            int row2Y = bottomY + 73; 
            label3.Location = new Point(startX + 14, row2Y + 3);
            cboxoalinhvuc.Location = new Point(startX + 139, row2Y);
            cboxoalinhvuc.Width = 786;
            btnxoalinhvuc.Location = new Point(cboxoalinhvuc.Right + 29, row2Y);

            int row3Y = row2Y + 54; 
            btnthoat.Location = new Point(cboxoalinhvuc.Right + 29, row3Y);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadLinhVuc();
        }

        private void LoadLinhVuc()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    var data = db.LinhVuc.ToList();


                    dgvlinhvuc.AutoGenerateColumns = false;
                    dgvlinhvuc.Columns["ID"].DataPropertyName = "ID";
                    dgvlinhvuc.Columns["MaLinhVuc"].DataPropertyName = "MaLinhVuc";
                    dgvlinhvuc.Columns["TenLinhVuc"].DataPropertyName = "TenLinhVuc";
                    dgvlinhvuc.DataSource = data.Select(lv => new
                    {
                        lv.ID,
                        lv.MaLinhVuc,
                        lv.TenLinhVuc
                    }).ToList();


                    cboxoalinhvuc.DataSource = data;
                    cboxoalinhvuc.DisplayMember = "TenLinhVuc";
                    cboxoalinhvuc.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemlinhvuc_Click(object sender, EventArgs e)
        {
            string tenLinhVuc = txtthemlinhvuc.Text.Trim();

            if (string.IsNullOrEmpty(tenLinhVuc))
            {
                MessageBox.Show("Vui lòng nhập tên lĩnh vực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtthemlinhvuc.Focus();
                return;
            }

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    LinhVuc lv = new LinhVuc();
                    lv.TenLinhVuc = tenLinhVuc;


                    if (db.LinhVuc.Any())
                    {
                        lv.MaLinhVuc = db.LinhVuc.Max(x => x.MaLinhVuc) + 1;
                    }
                    else
                    {
                        lv.MaLinhVuc = 1;
                    }

                    db.LinhVuc.Add(lv);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtthemlinhvuc.Clear();
                    LoadLinhVuc();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lĩnh vực: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoalinhvuc_Click(object sender, EventArgs e)
        {
            if (cboxoalinhvuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lĩnh vực cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)cboxoalinhvuc.SelectedValue;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lĩnh vực này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        LinhVuc lv = db.LinhVuc.Find(id);

                        if (lv != null)
                        {
                            db.LinhVuc.Remove(lv);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLinhVuc();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa lĩnh vực: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

