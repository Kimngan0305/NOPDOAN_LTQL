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
    public partial class frmquanlykho : Form
    {
        public frmquanlykho()
        {
            InitializeComponent();
        }
        QUANLYCHSDbContext db = new QUANLYCHSDbContext();
        private void dgvkho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtmasachkho.Text = dgvkho.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                numsoluongkho.Text = dgvkho.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            }
        }

        private void frmquanlykho_Load(object sender, EventArgs e)
        {
            dgvchonsach.DataSource = db.Sach.ToList();
            dgvkho.DataSource = db.Kho.ToList();
        }

        private void dgvchonsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtmasach.Text = dgvchonsach.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
            }
        }

        private void btnluukho_Click(object sender, EventArgs e)
        {
            string ma = txtmasachkho.Text;

            var k = db.Kho.FirstOrDefault(x => x.MaSach == ma);

            if (k != null)
            {
                k.SoLuong = int.Parse(numsoluongkho.Text);
                db.SaveChanges();
                dgvkho.DataSource = db.Kho.ToList();
            }
        }

        private void btnxoasachkho_Click(object sender, EventArgs e)
        {
            string ma = txtmasach.Text;

            var k = db.Kho.FirstOrDefault(x => x.MaSach == ma);

            if (k != null)
            {
                k.SoLuong = int.Parse(numsoluongkho.Text);
                db.SaveChanges();
                dgvkho.DataSource = db.Kho.ToList();
            }
        }

        private void btnchonthemkho_Click(object sender, EventArgs e)
        {
            if (dgvchonsach.CurrentRow != null)
            {
                txtmasach.Text =
                    dgvchonsach.CurrentRow.Cells["MaSach"].Value.ToString();
            }

        }

        private void btnthemvaokho_Click(object sender, EventArgs e)
        {
            string ma = txtmasach.Text;
            int sl = int.Parse(numsoluong.Text);

            var kho = db.Kho.FirstOrDefault(x => x.MaSach == ma);

            if (kho != null)
            {
                kho.SoLuong += sl;   // đã có thì cộng thêm
            }
            else
            {
                Kho k = new Kho();
                k.MaSach = ma;
                k.SoLuong = sl;
                db.Kho.Add(k);
            }

            db.SaveChanges();
            dgvkho.DataSource = db.Kho.ToList();
        }
    }
}
