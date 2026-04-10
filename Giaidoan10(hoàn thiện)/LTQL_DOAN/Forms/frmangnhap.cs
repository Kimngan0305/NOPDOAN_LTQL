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

namespace LTQL
{
    public partial class frmangnhap : Form
    {
        private int soLanDangNhapSai = 0;

        public frmangnhap()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng nhập không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string user = txtusername.Text;
            string pass = txtpassword.Text;

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    // Lấy thông tin nhân viên theo tên đăng nhập trước
                    var nv = db.NhanVien.FirstOrDefault(x => x.TenDangNhap == user);
                    
                    bool isPasswordValid = false;
                    if (nv != null)
                    {
                        try 
                        {
                            // Giải mã và kiểm tra mật khẩu bằng chuẩn BCrypt (vì ở Form Nhân viên bạn có dùng BCrypt.HashPassword)
                            isPasswordValid = BCrypt.Net.BCrypt.Verify(pass, nv.MatKhau);
                        }
                        catch 
                        {
                            // Nếu giải mã bị lỗi (có thể do đoạn dữ liệu cũ hoặc file SQL nạp vào chuỗi thô chưa mã hóa) -> kiểm tra kiểu chuỗi bình thường
                            isPasswordValid = (nv.MatKhau == pass);
                        }
                    }
                    
                    if (nv != null && isPasswordValid)
                    {
                        // Đăng nhập thành công với Database
                        NguoiDung.Username = nv.HoVaTen; // Hiển thị họ tên lên giao diện
                        NguoiDung.Quyen = nv.QuyenHan ? "Admin" : "NhanVien"; // Theo Entity, QuyenHan là bool (true: Admin, false: NhanVien)

                        frmquanlynhasach f = new frmquanlynhasach();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Vẫn giữ lại mật khẩu mặc định "admin - 123" đề phòng Database lỗi kết nối hoặc mất dữ liệu
                        if (user == "admin" && pass == "123")
                        {
                            NguoiDung.Username = "Người Quản Trị";
                            NguoiDung.Quyen = "Admin";

                            frmquanlynhasach f = new frmquanlynhasach();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            soLanDangNhapSai++;
                            if (soLanDangNhapSai >= 3)
                            {
                                MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần. Chương trình sẽ tự động thoát!", "Khoá chương trình", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                            }
                            else
                            {
                                MessageBox.Show($"Sai tài khoản hoặc mật khẩu! Bạn còn {3 - soLanDangNhapSai} lần thử.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmangnhap_Load(object sender, EventArgs e)
        {
            CenterLoginControls();
        }

        private void frmangnhap_Resize(object sender, EventArgs e)
        {
            CenterLoginControls();
        }

        private void CenterLoginControls()
        {
            // Calculate the bounding box of the main login controls to center them as a group
            // Approx bounding box: width=700, height=500
            int contentWidth = 700; 
            int contentHeight = 500;

            int offsetX = (this.ClientSize.Width - contentWidth) / 2;
            int offsetY = (this.ClientSize.Height - contentHeight) / 2;

            if (offsetX < 0) offsetX = 0;
            if (offsetY < 0) offsetY = 0;

            // Adjust positions relative to the new offset
            // Original Title (395, 71) -> rel(194, 0)
            label1.Location = new Point(offsetX + 194, offsetY + 0);
            
            // Original Account Label (201, 207) -> rel(0, 136)
            label2.Location = new Point(offsetX + 0, offsetY + 136);
            txtusername.Location = new Point(offsetX + 180, offsetY + 136);
            
            // Original Password Label (201, 307) -> rel(0, 236)
            label3.Location = new Point(offsetX + 0, offsetY + 236);
            txtpassword.Location = new Point(offsetX + 180, offsetY + 236);
            
            // Original Buttons (297, 457) and (642, 457)
            btndangnhap.Location = new Point(offsetX + 96, offsetY + 386);
            btnthoat.Location = new Point(offsetX + 441, offsetY + 386);
        }
    }
}
