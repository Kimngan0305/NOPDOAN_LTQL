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

namespace LTQL
{
    public partial class frmquanlynhasach : Form
    {
        public frmquanlynhasach()
        {
            InitializeComponent();
        }

        private void frmquanlynhasach_Load(object sender, EventArgs e)
        {
            lblnguoidung.Text = "Người Dùng: " + NguoiDung.Username;

            if (NguoiDung.Quyen == "NhanVien")
            {
                nhânViênToolStripMenuItem.Enabled = false;
            }
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlysach f = new frmquanlysach();
            f.ShowDialog();

        }

        private void loạiSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlysach f = new frmquanlysach();
            f.ShowDialog();
        }

        private void lĩnhVựcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlyloaisach f = new frmquanlyloaisach();
            f.ShowDialog();
        }

        private void tácGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlytacgia f = new frmquanlytacgia();
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlytacgia f = new frmquanlytacgia();
            f.ShowDialog();
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
        }

        private void hóaĐơnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadon_chitiet f = new frmhoadon_chitiet();
            f.ShowDialog();
        }

    }
}
