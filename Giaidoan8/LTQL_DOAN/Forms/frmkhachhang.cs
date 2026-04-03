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

namespace LTQL_DOAN.Forms
{
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmkhachhang_Resize(object sender, EventArgs e)
        {
            
            int startX = (this.ClientSize.Width - groupBox1.Width) / 2;
            if (startX < 0) startX = 17;
            
            groupBox1.Location = new Point(startX, 12);
            
            groupBox2.Location = new Point(17, groupBox1.Bottom + 10);
            groupBox2.Size = new Size(this.ClientSize.Width - 34, this.ClientSize.Height - groupBox1.Height - 40);
        }
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;
        private void BatTatChucNang(bool giaTri)
        {

            txthoten.Enabled = giaTri;
            txtdienthoai.Enabled = giaTri;
            txtdiachi.Enabled = giaTri;

            btnthem.Enabled = !giaTri;
            btnsua.Enabled = !giaTri;
            btnxoa.Enabled = !giaTri;
            btnluu.Enabled = giaTri;
            btnhuybo.Enabled = giaTri;
        }
        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    List<KhachHang> kh = db.KhachHang.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = kh;

                    txthoten.DataBindings.Clear();
                    txthoten.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

                    txtdienthoai.DataBindings.Clear();
                    txtdienthoai.DataBindings.Add("Text", bindingSource, "SDT", false, DataSourceUpdateMode.Never);

                    txtdiachi.DataBindings.Clear();
                    txtdiachi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = bindingSource;
                    
                    if (dataGridView1.Columns.Count > 0)
                    {
                        if (dataGridView1.Columns.Contains("ID")) dataGridView1.Columns["ID"].DataPropertyName = "ID";
                        if (dataGridView1.Columns.Contains("HoVaTen")) dataGridView1.Columns["HoVaTen"].DataPropertyName = "HoVaTen";
                        if (dataGridView1.Columns.Contains("DienThoai")) dataGridView1.Columns["DienThoai"].DataPropertyName = "SDT";
                        if (dataGridView1.Columns.Contains("DiaChi")) dataGridView1.Columns["DiaChi"].DataPropertyName = "DiaChi";
                    }
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
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    if (xuLyThem)
                    {
                        KhachHang kh = new KhachHang();
                        kh.HoVaTen = txthoten.Text;
                        kh.SDT = txtdienthoai.Text;
                        kh.DiaChi = txtdiachi.Text;
                        db.KhachHang.Add(kh);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        KhachHang kh = db.KhachHang.Find(id);
                        if (kh != null)
                        {
                            kh.HoVaTen = txthoten.Text;
                            kh.SDT = txtdienthoai.Text;
                            kh.DiaChi = txtdiachi.Text;
                            db.KhachHang.Update(kh);
                            db.SaveChanges();
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                frmkhachhang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa khách hàng " + txthoten.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                    using (var db = new QUANLYCHSDbContext())
                    {
                        KhachHang kh = db.KhachHang.Find(id);
                        if (kh != null)
                        {
                            db.KhachHang.Remove(kh);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    frmkhachhang_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            frmkhachhang_Load(sender, e);
        }
    }
}
