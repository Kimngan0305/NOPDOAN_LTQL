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
    public partial class frmquanlysach : Form
    {
        public frmquanlysach()
        {
            InitializeComponent();
        }
        QUANLYCHSDbContext db = new QUANLYCHSDbContext();
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmquanlysach_Load(object sender, EventArgs e)
        {
            LoadSach();

            cbotacgia.DataSource = db.TacGia.ToList();
            cbotacgia.DisplayMember = "TenTacGia";
            cbotacgia.ValueMember = "MaTacGia";

            cbolinhvuc.DataSource = db.LinhVuc.ToList();
            cbolinhvuc.DisplayMember = "TenLinhVuc";
            cbolinhvuc.ValueMember = "MaLinhVuc";

            cboloaisach.DataSource = db.Loai.ToList();
            cboloaisach.DisplayMember = "TenLoai";
            cboloaisach.ValueMember = "MaLoai";

            cbonxb.DataSource = db.NhaXuatBan.ToList();
            cbonxb.DisplayMember = "TenNXB";
            cbonxb.ValueMember = "MaNXB";
        }
        void LoadSach()
        {
            dgvsach.DataSource = db.Sach
            .Select(s => new
            {
                s.MaSach,
                s.TenSach,
                s.TacGia.TenTacGia,
                s.LinhVuc.TenLinhVuc,
                s.Loai.TenLoai,
                s.NhaXuatBan.TenNXB,
                s.GiaMua,
                s.GiaBia,
                s.LanTaiBan,
                s.NamXB
            }).ToList();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();

            s.MaSach = txtmasach.Text;
            s.TenSach = txttensach.Text;
            s.MaTacGia = (int)cbotacgia.SelectedValue;
            s.MaLinhVuc = (int)cbolinhvuc.SelectedValue;
            s.MaLoai = (int)cboloaisach.SelectedValue;
            s.MaNXB = (int)cbonxb.SelectedValue;

            s.GiaMua = int.Parse(txtgiamua.Text);
            s.GiaBia = int.Parse(txtgiabia.Text);
            s.LanTaiBan = int.Parse(numlantaiban.Text);
            s.NamXB = dtnamsanxuat.Value;

            db.Sach.Add(s);
            db.SaveChanges();

            LoadSach();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();

            s.MaSach = txtmasach.Text;
            s.TenSach = txttensach.Text;
            s.MaTacGia = (int)cbotacgia.SelectedValue;
            s.MaLinhVuc = (int)cbolinhvuc.SelectedValue;
            s.MaLoai = (int)cboloaisach.SelectedValue;
            s.MaNXB = (int)cbonxb.SelectedValue;

            s.GiaMua = int.Parse(txtgiamua.Text);
            s.GiaBia = int.Parse(txtgiabia.Text);
            s.LanTaiBan = int.Parse(numlantaiban.Text);
            s.NamXB = dtnamsanxuat.Value;

            db.Sach.Add(s);
            db.SaveChanges();

            LoadSach();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {

            string masach = txtmasach.Text;

            Sach s = db.Sach.Find(masach);

            if (s != null)
            {
                db.Sach.Remove(s);
                db.SaveChanges();
            }

            LoadSach();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string masach = txtmasach.Text;

            Sach s = db.Sach.Find(masach);

            if (s != null)
            {
                s.TenSach = txttensach.Text;
                s.MaTacGia = (int)cbotacgia.SelectedValue;
                s.MaLinhVuc = (int)cbolinhvuc.SelectedValue;
                s.MaLoai = (int)cboloaisach.SelectedValue;
                s.MaNXB = (int)cbonxb.SelectedValue;

                s.GiaMua = int.Parse(txtgiamua.Text);
                s.GiaBia = int.Parse(txtgiabia.Text);
                s.LanTaiBan = int.Parse(numlantaiban.Text);
                s.NamXB = dtnamsanxuat.Value;

                db.SaveChanges();
            }

            LoadSach();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
