using LTQL_DOAN.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LTQL
{
    public partial class frmquanlynhaxuatban : Form
    {
        public frmquanlynhaxuatban()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmquanlynhaxuatban_Resize(object sender, EventArgs e)
        {
            int contentWidth = 1088;
            int startX = (this.ClientSize.Width - contentWidth) / 2;
            if (startX < 0) startX = 12;

            int currentY = 19;
            label1.Location = new Point(startX, currentY);
            currentY = label1.Bottom + 5;

            int bottomControlsHeight = 185;
            int dgvHeight = this.ClientSize.Height - currentY - bottomControlsHeight;
            if (dgvHeight < 150) dgvHeight = 150;

            dataGridView1.Location = new Point(startX, currentY);
            dataGridView1.Size = new Size(contentWidth, dgvHeight);

            int bottomY = dataGridView1.Bottom + 30;

            label2.Location = new Point(startX, bottomY + 5);
            txtthemnhaxuatban.Location = new Point(startX + 177, bottomY);
            txtthemnhaxuatban.Width = 748;
            btnthemnhaxuatban.Location = new Point(txtthemnhaxuatban.Right + 17, bottomY);

            int row2Y = bottomY + 67;
            label3.Location = new Point(startX + 10, row2Y + 5);
            cboxoanhaxuatban.Location = new Point(startX + 180, row2Y);
            cboxoanhaxuatban.Width = 745;
            btnxoanhaxuatban.Location = new Point(cboxoanhaxuatban.Right + 17, row2Y);

            int row3Y = row2Y + 54;
            btnthoat.Location = new Point(cboxoanhaxuatban.Right + 17, row3Y);
        }

        private void frmquanlynhaxuatban_Load(object sender, EventArgs e)
        {
            LoadNhaXuatBan();
        }

        private void LoadNhaXuatBan()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    var data = db.NhaXuatBan.ToList();


                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns["ID"].DataPropertyName = "ID";
                    dataGridView1.Columns["MaNXB"].DataPropertyName = "MaNXB";
                    dataGridView1.Columns["TenNXB"].DataPropertyName = "TenNXB";
                    dataGridView1.DataSource = data.Select(nxb => new
                    {
                        nxb.ID,
                        nxb.MaNXB,
                        nxb.TenNXB
                    }).ToList();

                    cboxoanhaxuatban.DataSource = data;
                    cboxoanhaxuatban.DisplayMember = "TenNXB";
                    cboxoanhaxuatban.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemnhaxuatban_Click(object sender, EventArgs e)
        {
            string tenNXB = txtthemnhaxuatban.Text.Trim();

            if (string.IsNullOrEmpty(tenNXB))
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtthemnhaxuatban.Focus();
                return;
            }

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    NhaXuatBan nxb = new NhaXuatBan();
                    nxb.TenNXB = tenNXB;
                    nxb.DiaChi = "";
                    nxb.DienThoai = "";
                    nxb.Email = "";


                    if (db.NhaXuatBan.Any())
                    {
                        nxb.MaNXB = db.NhaXuatBan.Max(x => x.MaNXB) + 1;
                    }
                    else
                    {
                        nxb.MaNXB = 1;
                    }

                    db.NhaXuatBan.Add(nxb);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtthemnhaxuatban.Clear();
                    LoadNhaXuatBan();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null)
                {
                    msg += "\nChi tiết: " + ex.InnerException.Message;
                }
                MessageBox.Show("Lỗi khi thêm nhà xuất bản: " + msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoanhaxuatban_Click(object sender, EventArgs e)
        {
            if (cboxoanhaxuatban.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)cboxoanhaxuatban.SelectedValue;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        NhaXuatBan nxb = db.NhaXuatBan.Find(id);

                        if (nxb != null)
                        {
                            db.NhaXuatBan.Remove(nxb);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNhaXuatBan();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhà xuất bản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
