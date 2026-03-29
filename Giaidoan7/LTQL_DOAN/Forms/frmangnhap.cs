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
        public frmangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpassword.Text;

            // tài khoản giả để test
            if (user == "admin" && pass == "123")
            {
                NguoiDung.Username = user;
                NguoiDung.Quyen = "Admin";
            }
            else if (user == "nv01" && pass == "123")
            {
                NguoiDung.Username = user;
                NguoiDung.Quyen = "NhanVien";
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                return;
            }

            frmquanlynhasach f = new frmquanlynhasach();
            f.Show();
            this.Hide();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
