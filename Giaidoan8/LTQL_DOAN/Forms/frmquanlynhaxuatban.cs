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
            // Center the add/delete sections (~1100px width total)
            int contentWidth = 1100;
            int startX = (this.ClientSize.Width - contentWidth) / 2;
            int bottomY = this.ClientSize.Height - 150;

            if (startX < 0) startX = 12;
            if (bottomY < dataGridView1.Bottom + 10) bottomY = dataGridView1.Bottom + 10;

            label2.Location = new Point(startX, bottomY);
            txtthemnhaxuatban.Location = new Point(startX + 237, bottomY - 3);
            btnthemnhaxuatban.Location = new Point(startX + 946, bottomY - 3);
            
            label3.Location = new Point(startX + 14, bottomY + 70);
            cboxoanhaxuatban.Location = new Point(startX + 237, bottomY + 67);
            btnxoanhaxuatban.Location = new Point(startX + 946, bottomY + 67);
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
    }
}

