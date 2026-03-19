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
            string tk = txttaikhoan.Text.Trim();
            string mk = txtmatkhau.Text.Trim();

            if (tk == "admin" && mk == "123")
            {
                // Mở Form Main
                frmquanlynhasach f = new frmquanlynhasach(txttaikhoan.Text);
                f.Show();

                // Ẩn form đăng nhập
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Sai tài khoản hoặc mật khẩu!",
                    "Lỗi đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
