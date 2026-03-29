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
        }
        QUANLYCHSDbContext context = new QUANLYCHSDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
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
            btnluu.Enabled = !giaTri;
            btnhuybo.Enabled = !giaTri;
           
        }
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView1.AutoGenerateColumns = false;

            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();

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

            dataGridView1.DataSource = bindingSource;
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
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtmatkhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.HoVaTen = txthoten.Text;
                        nv.DienThoai = txtdienthoai.Text;
                        nv.DiaChi = txtdiachi.Text;
                        nv.TenDangNhap = txttendangnhap.Text;
                        nv.MatKhau = BC.HashPassword(txtmatkhau.Text);
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                    }
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txthoten.Text;
                        nv.DienThoai = txtdienthoai.Text;
                        nv.DiaChi = txtdiachi.Text;
                        nv.TenDangNhap = txttendangnhap.Text;
                        context.NhanVien.Update(nv);

                        if (string.IsNullOrEmpty(txtmatkhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ 
                        else
                            nv.MatKhau = BC.HashPassword(txtmatkhau.Text);
                        context.SaveChanges();
                    }
                }

                frmnhanvien_Load(sender, e);
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txthoten.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();

                frmnhanvien_Load(sender, e);
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            frmnhanvien_Load(sender, e);
        }
    }
}
