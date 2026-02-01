using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTQL
{
    public partial class frmquanlynhasach : Form
    {
        public string TenDangNhap { get; set; }
        public frmquanlynhasach()
        {
            InitializeComponent();
        }

        private void frmquanlynhasach_Load(object sender, EventArgs e)
        {
            LoadDanhSachSach();

            dateTimePicker1.Value = DateTime.Now;

            lbldoanhthu.Text = "2920000 VND";
            lblsoluong.Text = "5 người";

        }
        private void LoadDanhSachSach()
        {
            dgvsach.Rows.Clear();

            dgvsach.Rows.Add("Tiếng Anh  12", "Nguyễn Văn Nam ", "Sách tham khảo", "Sách Tiếng Việt", 70000);
            dgvsach.Rows.Add("Conan", "Trần Văn A", "Truyện Tranh", "Sách Nước Ngoài", 50000);
            dgvsach.Rows.Add("Dế Mèn Phiêu Lưu Kí ", "Lê Thị Thu ", "Tiểu Thuyết ", "Sách Tiếng Việt", 120000);
            dgvsach.Rows.Add("Đại Số  10", "Nguyễn Văn Nam ", "Sách Giáo Khoa ", "Sách Tiếng Việt ", 40000);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbldoanhthutrongngay.Text = "2920000 VND";
            lblsoluongkhach.Text = "5 người";
        }

        public frmquanlynhasach(string tenNguoiDung)
        {
            InitializeComponent();
            lblten.Text = tenNguoiDung;
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadSach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Tác giả");
            dt.Columns.Add("Lĩnh vực");
            dt.Columns.Add("Loại sách");
            dt.Columns.Add("Giá bìa");

            dt.Rows.Add("Tiếng Anh 12", "Nguyễn Văn Nam", "Sách tham khảo", "Sách Tiếng Việt", "70000");
            dt.Rows.Add("Conan", "Trần Văn A", "Truyện tranh", "Sách Nước Ngoài", "50000");
            dt.Rows.Add("Dế Mèn phiêu lưu ký", "Lê Thị Thu", "Tiểu thuyết", "Sách Tiếng Việt", "120000");

            dgvsach.DataSource = dt;
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlysach f = new frmquanlysach();
            f.ShowDialog();
        }

        private void lĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlylinhvuc f = new frmquanlylinhvuc();
            f.ShowDialog();
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlyloaisach f = new frmquanlyloaisach();
            f.ShowDialog();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlytacgia f = new frmquanlytacgia();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlyhoadon f = new frmquanlyhoadon();
            f.ShowDialog();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlykho f = new frmquanlykho();
            f.ShowDialog();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlynhaxuatban f = new frmquanlynhaxuatban();
            f.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongke f = new frmthongke();
            f.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlybaocao f = new frmquanlybaocao();
            f.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongtintaikhoan f = new frmthongtintaikhoan();
            f.ShowDialog();
        }
        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlynhasach f = new frmquanlynhasach();
            f.ShowDialog();
        }
        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            // demo dữ liệu giả
            lbldoanhthutrongngay.Text = "Doanh Thu Trong Ngày: 2,500,000 VND";
            lblsoluongkhach.Text = "Số Lượng Khách: 15";
        }

        private void FormQuanLyNhaSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
