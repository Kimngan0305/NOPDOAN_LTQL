using LTQL_DOAN.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace LTQL_DOAN.Forms
{
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmnhanvien_Resize(object sender, EventArgs e)
        {

            int startX = (this.ClientSize.Width - groupBox1.Width) / 2;
            if (startX < 0) startX = 16;

            groupBox1.Location = new Point(startX, 12);


            groupBox2.Location = new Point(16, groupBox1.Bottom + 10);
            groupBox2.Size = new Size(this.ClientSize.Width - 32, this.ClientSize.Height - groupBox1.Height - 40);
        }

        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;
        private void BatTatChucNang(bool giaTri)
        {

            txthoten.Enabled = giaTri;
            txtdienthoai.Enabled = giaTri;
            txtdiachi.Enabled = giaTri;
            txttendangnhap.Enabled = giaTri;
            txtmatkhau.Enabled = giaTri;

            btnthem.Enabled = !giaTri;
            btnsua.Enabled = !giaTri;
            btnxoa.Enabled = !giaTri;
            btnluu.Enabled = giaTri;
            btnhuybo.Enabled = giaTri;

        }
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    List<NhanVien> nv = db.NhanVien.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = nv;

                    txthoten.DataBindings.Clear();
                    txthoten.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

                    txtdienthoai.DataBindings.Clear();
                    txtdienthoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                    txtdiachi.DataBindings.Clear();
                    txtdiachi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                    txttendangnhap.DataBindings.Clear();
                    txttendangnhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

                    dataGridView1.AutoGenerateColumns = false;
                    if (dataGridView1.Columns.Count > 0)
                    {
                        dataGridView1.Columns["ID"].DataPropertyName = "ID";
                        dataGridView1.Columns["HoVaTen"].DataPropertyName = "HoVaTen";
                        dataGridView1.Columns["DienThoai"].DataPropertyName = "DienThoai";
                        dataGridView1.Columns["DiaChi"].DataPropertyName = "DiaChi";
                        dataGridView1.Columns["TenDangNhap"].DataPropertyName = "TenDangNhap";
                    }

                    dataGridView1.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txthoten.Clear();
            txtdienthoai.Clear();
            txtdiachi.Clear();
            txttendangnhap.Clear();
            txtmatkhau.Clear();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthoten.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txttendangnhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    using (var db = new QUANLYCHSDbContext())
                    {
                        if (xuLyThem)
                        {
                            if (string.IsNullOrWhiteSpace(txtmatkhau.Text))
                            {
                                MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            NhanVien nv = new NhanVien();
                            nv.HoVaTen = txthoten.Text;
                            nv.DienThoai = txtdienthoai.Text;
                            nv.DiaChi = txtdiachi.Text;
                            nv.TenDangNhap = txttendangnhap.Text;
                            nv.MatKhau = BC.HashPassword(txtmatkhau.Text);
                            db.NhanVien.Add(nv);
                            db.SaveChanges();
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            NhanVien nv = db.NhanVien.Find(id);
                            if (nv != null)
                            {
                                nv.HoVaTen = txthoten.Text;
                                nv.DienThoai = txtdienthoai.Text;
                                nv.DiaChi = txtdiachi.Text;
                                nv.TenDangNhap = txttendangnhap.Text;

                                if (!string.IsNullOrEmpty(txtmatkhau.Text))
                                    nv.MatKhau = BC.HashPassword(txtmatkhau.Text);

                                db.NhanVien.Update(nv);
                                db.SaveChanges();
                                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    frmnhanvien_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa nhân viên " + txthoten.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                    using (var db = new QUANLYCHSDbContext())
                    {
                        NhanVien nv = db.NhanVien.Find(id);
                        if (nv != null)
                        {
                            db.NhanVien.Remove(nv);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    frmnhanvien_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            frmnhanvien_Load(sender, e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
