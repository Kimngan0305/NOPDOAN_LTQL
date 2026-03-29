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
    public partial class frmquanlylinhvuc : Form
    {
        public frmquanlylinhvuc()
        {
            InitializeComponent();
        }
        QUANLYCHSDbContext db = new QUANLYCHSDbContext();
        private void Form5_Load(object sender, EventArgs e)
        {
            LoadLinhVuc();
        }
        void LoadLinhVuc()
        {
            dgvlinhvuc.DataSource = db.LinhVuc
                                    .Select(lv => new
                                    {
                                        lv.MaLinhVuc,
                                        lv.TenLinhVuc
                                    }).ToList();

            cboxoalinhvuc.DataSource = db.LinhVuc.ToList();
            cboxoalinhvuc.DisplayMember = "TenLinhVuc";
            cboxoalinhvuc.ValueMember = "MaLinhVuc";
        }
        private void btnthemlinhvuc_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtthemlinhvuc.Text))
            {
                MessageBox.Show("Nhập tên lĩnh vực!");
                return;
            }

            LinhVuc lv = new LinhVuc();
            lv.TenLinhVuc = txtthemlinhvuc.Text;

            db.LinhVuc.Add(lv);
            db.SaveChanges();

            MessageBox.Show("Thêm thành công!");
            txtthemlinhvuc.Clear();
            LoadLinhVuc();

        }


        private void btnxoalinhvuc_Click(object sender, EventArgs e)
        {
            if (cboxoalinhvuc.SelectedValue == null)
                return;

            int ma = (int)cboxoalinhvuc.SelectedValue;

            LinhVuc lv = db.LinhVuc.Find(ma);

            if (lv != null)
            {
                db.LinhVuc.Remove(lv);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                LoadLinhVuc();
            }
        }
    }
}
