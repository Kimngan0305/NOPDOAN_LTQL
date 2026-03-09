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
    public partial class frmquanlytacgia : Form
    {
        public frmquanlytacgia()
        {
            InitializeComponent();
        }
        QUANLYCHSDbContext db = new QUANLYCHSDbContext();
        int chon = 0;
        private void frmquanlytacgia_Load(object sender, EventArgs e)
        {
            LoadTacGia();
        }
        void LoadTacGia()
        {
            dgvtacgia.DataSource = db.TacGia.Select(t => new
            {
                t.MaTacGia,
                t.TenTacGia,
                t.QueQuan,
                t.NgaySinh,
                t.NgayMat
            }).ToList();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmatacgia.Text = "";
            txttentacgia.Text = "";
            txtquequan.Text = "";

            chon = 1;
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            txtmatacgia.Text = dgvtacgia.CurrentRow.Cells[0].Value.ToString();
            txttentacgia.Text = dgvtacgia.CurrentRow.Cells[1].Value.ToString();
            txtquequan.Text = dgvtacgia.CurrentRow.Cells[2].Value.ToString();

            dtngaysinh.Value = Convert.ToDateTime(dgvtacgia.CurrentRow.Cells[3].Value);
            dtngaymat.Value = Convert.ToDateTime(dgvtacgia.CurrentRow.Cells[4].Value);

            chon = 2;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (chon == 1)
            {
                TacGia tg = new TacGia();

                tg.TenTacGia = txttentacgia.Text;
                tg.QueQuan = txtquequan.Text;
                tg.NgaySinh = dtngaysinh.Value;
                tg.NgayMat = dtngaymat.Value;

                db.TacGia.Add(tg);
                db.SaveChanges();
            }

            if (chon == 2)
            {
                int id = int.Parse(txtmatacgia.Text);

                TacGia tg = db.TacGia.Find(id);

                tg.TenTacGia = txttentacgia.Text;
                tg.QueQuan = txtquequan.Text;
                tg.NgaySinh = dtngaysinh.Value;
                tg.NgayMat = dtngaymat.Value;

                db.SaveChanges();
            }

            LoadTacGia();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtmatacgia.Text);

            TacGia tg = db.TacGia.Find(id);

            db.TacGia.Remove(tg);

            db.SaveChanges();

            LoadTacGia();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
