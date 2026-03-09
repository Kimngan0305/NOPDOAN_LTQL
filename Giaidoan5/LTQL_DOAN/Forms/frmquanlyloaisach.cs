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
    public partial class frmquanlyloaisach : Form
    {
        public frmquanlyloaisach()
        {
            InitializeComponent();
        }
        QUANLYCHSDbContext db = new QUANLYCHSDbContext();
        private void frmquanlyloaisach_Load(object sender, EventArgs e)
        {
            LoadLoai();
        }
        void LoadLoai()
        {
            dgvloaisach.DataSource = db.Loai
                                    .Select(l => new
                                    {
                                        l.MaLoai,
                                        l.TenLoai
                                    }).ToList();

            cboxoaloaisach.DataSource = db.Loai.ToList();
            cboxoaloaisach.DisplayMember = "TenLoai";
            cboxoaloaisach.ValueMember = "MaLoai";
        }

        private void btnthemloaisach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtthemloaisach.Text))
            {
                MessageBox.Show("Nhập tên loại sách!");
                return;
            }

            Loai l = new Loai();
            l.TenLoai = txtthemloaisach.Text;

            db.Loai.Add(l);
            db.SaveChanges();

            MessageBox.Show("Thêm thành công!");
            txtthemloaisach.Clear();
            LoadLoai();
        }

        private void btnxoaloaisach_Click(object sender, EventArgs e)
        {
            if (cboxoaloaisach.SelectedValue == null)
                return;

            int maloai = (int)cboxoaloaisach.SelectedValue;

            Loai l = db.Loai.Find(maloai);

            if (l != null)
            {
                db.Loai.Remove(l);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                LoadLoai();
            }

        }
    }
}
