using LTQL_DOAN.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTQL_DOAN.Data;
using Microsoft.EntityFrameworkCore;
namespace LTQL
{
    public partial class frmquanlynhasach : Form
    {
        public frmquanlynhasach()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmquanlynhasach_Load(object sender, EventArgs e)
        {
            lblnguoidung.Text = "Người Dùng: " + NguoiDung.Username;

            if (NguoiDung.Quyen == "NhanVien")
            {
                nhânViênToolStripMenuItem.Enabled = false;
            }
            // Mặc định dateTimePicker = hôm nay
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;

            LoadDuLieu(DateTime.Today);

        }
        private void LoadDuLieu(DateTime ngay)
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    // ── 1. Load danh sách sách vào dgvsach ──────────────
                    var danhSach = db.Sach
                        .Include(s => s.TacGia)
                        .Include(s => s.LinhVuc)
                        .Include(s => s.Loai)
                        .Include(s => s.NhaXuatBan)
                        .ToList();

                    dgvsach.Rows.Clear();

                    foreach (var s in danhSach)
                    {
                        dgvsach.Rows.Add(
                            s.TenSach,
                            s.TacGia != null ? s.TacGia.TenTacGia : "",
                            s.LinhVuc != null ? s.LinhVuc.TenLinhVuc : "",
                            s.Loai != null ? s.Loai.TenLoai : "",
                            s.GiaBia,
                            s.NhaXuatBan != null ? s.NhaXuatBan.TenNXB : ""
                        );
                    }

                    // ── 2. Doanh thu theo ngày được chọn ────────────────
                   
                    var listDetails = db.ChiTietHoaDon
                        .Include(ct => ct.HoaDon)
                        .Where(ct => ct.HoaDon.NgayLap.Date == ngay.Date)
                        .ToList();

                    var doanhThu = listDetails.Sum(ct => (decimal)ct.ThanhTien);

                    lbldoanhthutrongngay.Text = "Doanh Thu Trong Ngày: "
                                               + doanhThu.ToString("N0") + " VND";

                    // ── 3. Số lượng khách theo ngày được chọn ───────────
                    var soKhach = listDetails
                        .Select(ct => ct.HoaDon.KhachHangID)
                        .Distinct()
                        .Count();

                    lblsoluongkhach.Text = "Số Lượng Khách: " + soKhach + " người";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu:\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlysach f = new frmquanlysach();
            f.ShowDialog();
            LoadDuLieu(dateTimePicker1.Value.Date);
        }

        private void loạiSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlyloaisach f = new frmquanlyloaisach();
            f.ShowDialog();
            LoadDuLieu(dateTimePicker1.Value.Date);
        }

        private void lĩnhVựcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlylinhvuc f = new frmquanlylinhvuc();
            f.ShowDialog();
            LoadDuLieu(dateTimePicker1.Value.Date);
        }

        private void tácGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlytacgia f = new frmquanlytacgia();
            f.ShowDialog();
            LoadDuLieu(dateTimePicker1.Value.Date);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlynhaxuatban f = new frmquanlynhaxuatban();
            f.ShowDialog();
            LoadDuLieu(dateTimePicker1.Value.Date);
        }

        private void khoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlykho f = new frmquanlykho();
            f.ShowDialog();

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang f = new frmkhachhang();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien f = new frmnhanvien();
            f.ShowDialog();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlybaocao f = new frmquanlybaocao();
            f.ShowDialog();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmthongke f = new frmthongke();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadon f = new frmhoadon();
            f.ShowDialog();
            LoadDuLieu(dateTimePicker1.Value.Date);
        }

        private void hóaĐơnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadon_chitiet f = new frmhoadon_chitiet();
            f.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadDuLieu(dateTimePicker1.Value.Date);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Hiển thị thông báo xác nhận Đăng xuất
            DialogResult result = MessageBox.Show(
                "Bạn có chắc là muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            // 2. Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                // Ẩn form quản lý hiện tại
                this.Hide();
                // Tìm và hiển thị lại form đăng nhập đã cấp vùng nhớ từ trước
                bool foundLogin = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f is frmangnhap)
                    {
                        f.Show();
                        foundLogin = true;
                        break;
                    }
                }
                // Đề phòng trường hợp lỗi không tìm thấy form cũ, ta khởi tạo mới
                if (!foundLogin)
                {
                    frmangnhap login = new frmangnhap();
                    login.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
