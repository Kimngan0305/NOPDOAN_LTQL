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
           
            int contentWidth = 1100;
            int startX = (this.ClientSize.Width - contentWidth) / 2;
            int bottomY = this.ClientSize.Height - 150;

            if (startX < 0) startX = 12;
            if (bottomY < dgvlinhvuc.Bottom + 10) bottomY = dgvlinhvuc.Bottom + 10;

            label2.Location = new Point(startX, bottomY);
            txtthemlinhvuc.Location = new Point(startX + 174, bottomY - 3);
            btnthemlinhvuc.Location = new Point(startX + 954, bottomY - 3);
            
            label3.Location = new Point(startX + 14, bottomY + 70);
            cboxoalinhvuc.Location = new Point(startX + 174, bottomY + 67);
            btnxoalinhvuc.Location = new Point(startX + 954, bottomY + 67);
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
    }
}
