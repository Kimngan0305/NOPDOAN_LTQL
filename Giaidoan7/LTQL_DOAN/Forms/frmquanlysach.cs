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
            var data = db.Sach
                .Select(s => new
                {
                    s.MaSach,
                    s.TenSach,
                    TenTacGia = s.TacGia.TenTacGia,
                    TenLinhVuc = s.LinhVuc.TenLinhVuc,
                    TenLoai = s.Loai.TenLoai,
                    TenNXB = s.NhaXuatBan.TenNXB,
                    s.GiaMua,
                    s.GiaBia,
                    s.LanTaiBan,
                    s.NamXB
                })
                .ToList();

            // Các cột trong Designer (button/text) chưa được gán DataPropertyName,
            // nên dù DataSource có dữ liệu thì grid vẫn không hiện nội dung.
            dgvsach.AutoGenerateColumns = false;

            void SetCol(string columnName, string propertyName)
            {
                if (dgvsach.Columns.Contains(columnName))
                    dgvsach.Columns[columnName].DataPropertyName = propertyName;
            }

            SetCol("QuanLyMaSach", "MaSach");
            SetCol("QuanLyTenSach", "TenSach");
            SetCol("QuanLyTacGia", "TenTacGia");
            SetCol("QuanLyLinhVuc", "TenLinhVuc");
            SetCol("QuanLyLoaiSach", "TenLoai");
            SetCol("QuanLyNXB", "TenNXB");
            SetCol("QuanLyGiaMua", "GiaMua");
            SetCol("QuanLyGiaBia", "GiaBia");
            SetCol("QuanLyLanTaiBan", "LanTaiBan");
            SetCol("QuanLyNanXuatBan", "NamXB");

            dgvsach.DataSource = data;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();

            s.MaSach = txtmasach.Text;
            s.TenSach = txttensach.Text;
            s.MaTacGia = int.Parse(cbotacgia.SelectedValue!.ToString());
            s.MaLinhVuc = (int)cbolinhvuc.SelectedValue;
            s.MaLoai = (int)cboloaisach.SelectedValue;
            s.MaNXB = (int)cbonxb.SelectedValue;

            s.GiaMua = int.Parse(txtgiamua.Text);
            s.GiaBia = int.Parse(txtgiabia.Text);
            s.LanTaiBan = int.Parse(numlantaiban.Text);
            s.NamXB = dtnamsanxuat.Value;

            // Gán navigation để EF điền đúng FK shadow (TacGiaID/LinhVucID/LoaiID/NhaXuatBanID)
            var tacGia = db.TacGia.FirstOrDefault(t => t.MaTacGia == s.MaTacGia.ToString());
            var linhVuc = db.LinhVuc.FirstOrDefault(lv => lv.MaLinhVuc == s.MaLinhVuc);
            var loai = db.Loai.FirstOrDefault(l => l.MaLoai == s.MaLoai);
            var nhaXuatBan = db.NhaXuatBan.FirstOrDefault(nxb => nxb.MaNXB == s.MaNXB);

            if (tacGia == null || linhVuc == null || loai == null || nhaXuatBan == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu liên quan (FK). Vui lòng seed lại DB hoặc chọn lại từ combobox.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            s.TacGia = tacGia;
            s.LinhVuc = linhVuc;
            s.Loai = loai;
            s.NhaXuatBan = nhaXuatBan;

            db.Sach.Add(s);
            db.SaveChanges();

            LoadSach();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Trong EF Core, PK của Sach là `ID` (int identity),
            // nên không dùng Find(string) theo `MaSach`.
            string masach = txtmasach.Text;
            var s = db.Sach.FirstOrDefault(x => x.MaSach == masach);
            if (s != null)
            {
                db.Sach.Remove(s);
                db.SaveChanges();
                LoadSach();
            }
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            string masach = txtmasach.Text;
            var s = db.Sach.FirstOrDefault(x => x.MaSach == masach);

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
            var s = db.Sach.FirstOrDefault(x => x.MaSach == masach);

            if (s != null)
            {
                s.TenSach = txttensach.Text;
                s.MaTacGia = int.Parse(cbotacgia.SelectedValue!.ToString());
                s.MaLinhVuc = (int)cbolinhvuc.SelectedValue;
                s.MaLoai = (int)cboloaisach.SelectedValue;
                s.MaNXB = (int)cbonxb.SelectedValue;

                s.GiaMua = int.Parse(txtgiamua.Text);
                s.GiaBia = int.Parse(txtgiabia.Text);
                s.LanTaiBan = int.Parse(numlantaiban.Text);
                s.NamXB = dtnamsanxuat.Value;

                // Update navigation để EF đảm bảo FK shadow đúng khi SaveChanges()
                var tacGia = db.TacGia.FirstOrDefault(t => t.MaTacGia == s.MaTacGia.ToString());
                var linhVuc = db.LinhVuc.FirstOrDefault(lv => lv.MaLinhVuc == s.MaLinhVuc);
                var loai = db.Loai.FirstOrDefault(l => l.MaLoai == s.MaLoai);
                var nhaXuatBan = db.NhaXuatBan.FirstOrDefault(nxb => nxb.MaNXB == s.MaNXB);

                if (tacGia == null || linhVuc == null || loai == null || nhaXuatBan == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu liên quan (FK).",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                s.TacGia = tacGia;
                s.LinhVuc = linhVuc;
                s.Loai = loai;
                s.NhaXuatBan = nhaXuatBan;

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
