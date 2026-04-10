using LTQL_DOAN.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LTQL
{
    public partial class frmquanlytacgia : Form
    {
        private int selectedId = -1;

        public frmquanlytacgia()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmquanlytacgia_Resize(object sender, EventArgs e)
        {
           
            int totalWidth = groupBox1.Width + btnthem.Width + 20; 
            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int bottomY = this.ClientSize.Height - groupBox1.Height - 10;

            if (startX < 0) startX = 10;
            if (bottomY < dataGridView1.Bottom + 10) bottomY = dataGridView1.Bottom + 10;

            groupBox1.Location = new Point(startX, bottomY);
            
            int btnX = startX + groupBox1.Width + 10;
            btnthem.Location = new Point(btnX, bottomY + 10);
            btnxoa.Location = new Point(btnX, bottomY + 91);
            btnthoat.Location = new Point(btnX, bottomY + 172);
        }

        private void frmquanlytacgia_Load(object sender, EventArgs e)
        {
            LoadTacGia();
            ResetForm();
        }

        private void LoadTacGia()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns["ID"].DataPropertyName = "ID";
                    dataGridView1.Columns["MaTacGia"].DataPropertyName = "MaTacGia";
                    dataGridView1.Columns["TenTacGia"].DataPropertyName = "TenTacGia";
                    dataGridView1.Columns["QueQuan"].DataPropertyName = "QueQuan";
                    dataGridView1.Columns["NgaySinh"].DataPropertyName = "NgaySinh";
                    dataGridView1.Columns["NgayMat"].DataPropertyName = "NgayMat";

                    dataGridView1.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dataGridView1.Columns["NgayMat"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dataGridView1.DataSource = db.TacGia.Select(t => new
                    {
                        t.ID,
                        t.MaTacGia,
                        t.TenTacGia,
                        t.QueQuan,
                        t.NgaySinh,
                        t.NgayMat
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            selectedId = -1;
            txtmatacgia.Text = "";
            txttentacgia.Text = "";
            txtquequan.Text = "";
            dtngaysinh.Value = DateTime.Now.Date;
            dtngaymat.Value = DateTime.Now.Date;

            chkquequan.Checked = false;
            chkngaysinh.Checked = false;
            chkngaymat.Checked = false;

            txtmatacgia.Enabled = true;
            btnxoa.Enabled = false;
            btnthem.Text = "Thêm";
            
           
            if (this.Controls.ContainsKey("btnluu")) this.Controls["btnluu"].Visible = false;
            if (this.Controls.ContainsKey("btnchon")) this.Controls["btnchon"].Visible = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    TacGia tg;
                    if (selectedId == -1) 
                    {
                        tg = new TacGia();
                        db.TacGia.Add(tg);
                    }
                    else 
                    {
                        tg = db.TacGia.Find(selectedId);
                        if (tg == null)
                        {
                            MessageBox.Show("Không tìm thấy tác giả để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    tg.MaTacGia = txtmatacgia.Text.Trim();
                    
                 
                    if (selectedId == -1)
                    {
                        if (db.TacGia.Any(t => t.MaTacGia == tg.MaTacGia))
                        {
                            MessageBox.Show("Mã tác giả này đã tồn tại trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    tg.TenTacGia = txttentacgia.Text.Trim();
                 
                    tg.QueQuan = chkquequan.Checked ? string.Empty : txtquequan.Text.Trim();
                    tg.NgaySinh = chkngaysinh.Checked ? (DateTime?)null : dtngaysinh.Value.Date;
                    tg.NgayMat = chkngaymat.Checked ? (DateTime?)null : dtngaymat.Value.Date;

                    db.SaveChanges();
                    MessageBox.Show(selectedId == -1 ? "Thêm mới thành công!" : "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadTacGia();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                string errorMsg = ex.Message;
                if (ex.InnerException != null) 
                {
                    errorMsg += "\nChi tiết: " + ex.InnerException.Message;
                }
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + errorMsg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillFormFromGrid(e.RowIndex);
                btnxoa.Enabled = true;
                txtmatacgia.Enabled = false; 
                btnthem.Text = "Cập Nhật";
            }
            else
            {
                ResetForm();
            }
        }

        private void FillFormFromGrid(int rowIndex)
        {
            var row = dataGridView1.Rows[rowIndex];
            selectedId = Convert.ToInt32(row.Cells["ID"].Value);
            txtmatacgia.Text = row.Cells["MaTacGia"].Value?.ToString();
            txttentacgia.Text = row.Cells["TenTacGia"].Value?.ToString();
            
            string queQuan = row.Cells["QueQuan"].Value?.ToString();
            if (string.IsNullOrEmpty(queQuan))
            {
                chkquequan.Checked = true;
                txtquequan.Text = "";
            }
            else
            {
                chkquequan.Checked = false;
                txtquequan.Text = queQuan;
            }

            if (row.Cells["NgaySinh"].Value != null)
            {
                chkngaysinh.Checked = false;
                dtngaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            }
            else
            {
                chkngaysinh.Checked = true;
            }

            if (row.Cells["NgayMat"].Value != null)
            {
                chkngaymat.Checked = false;
                dtngaymat.Value = Convert.ToDateTime(row.Cells["NgayMat"].Value);
            }
            else
            {
                chkngaymat.Checked = true;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtmatacgia.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmatacgia.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txttentacgia.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentacgia.Focus();
                return false;
            }
            return true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        var tg = db.TacGia.Find(selectedId);
                        if (tg != null)
                        {
                            db.TacGia.Remove(tg);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTacGia();
                            ResetForm();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkquequan_CheckedChanged(object sender, EventArgs e)
        {
            txtquequan.Enabled = !chkquequan.Checked;
            if (chkquequan.Checked) txtquequan.Text = "";
        }

        private void chkngaysinh_CheckedChanged(object sender, EventArgs e)
        {
            dtngaysinh.Enabled = !chkngaysinh.Checked;
        }

        private void chkngaymat_CheckedChanged(object sender, EventArgs e)
        {
            dtngaymat.Enabled = !chkngaymat.Checked;
        }
    }
}
