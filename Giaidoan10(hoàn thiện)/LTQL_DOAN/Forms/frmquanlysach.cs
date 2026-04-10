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
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmquanlysach_Resize(object sender, EventArgs e)
        {
           
            int totalWidth = groupBox1.Width + btnthem.Width + 20; 
            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int bottomY = this.ClientSize.Height - groupBox1.Height - 10;

            if (startX < 0) startX = 10;
            if (bottomY < dgvsach.Bottom + 10) bottomY = dgvsach.Bottom + 10;

            groupBox1.Location = new Point(startX, bottomY);
            
            int btnX = startX + groupBox1.Width + 10;
            btnthem.Location = new Point(btnX, bottomY + 50);
            btnxoa.Location = new Point(btnX, bottomY + 120);
            btnthoat.Location = new Point(btnX, bottomY + 190);
        }

        private void LoadSach()
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    var data = db.Sach
                        .Select(s => new
                        {
                            s.MaSach,
                            s.TenSach,
                            TenTacGia = s.TacGia != null ? s.TacGia.TenTacGia : "N/A",
                            TenLinhVuc = s.LinhVuc != null ? s.LinhVuc.TenLinhVuc : "N/A",
                            TenLoai = s.Loai != null ? s.Loai.TenLoai : "N/A",
                            TenNXB = s.NhaXuatBan != null ? s.NhaXuatBan.TenNXB : "N/A",
                            s.GiaMua,
                            s.GiaBia,
                            s.LanTaiBan,
                            s.NamXB
                        })
                        .ToList();

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

                    if (dgvsach.Columns.Contains("QuanLyNanXuatBan"))
                        dgvsach.Columns["QuanLyNanXuatBan"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgvsach.DataSource = data;
                    dgvsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sách: " + ex.Message);
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmquanlysach_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    cbotacgia.ValueMember = "ID";
                    cbotacgia.DisplayMember = "TenTacGia";
                    cbotacgia.DataSource = db.TacGia.ToList();

                    cbolinhvuc.ValueMember = "ID";
                    cbolinhvuc.DisplayMember = "TenLinhVuc";
                    cbolinhvuc.DataSource = db.LinhVuc.ToList();

                    cboloaisach.ValueMember = "ID";
                    cboloaisach.DisplayMember = "TenLoai";
                    cboloaisach.DataSource = db.Loai.ToList();

                    cbonxb.ValueMember = "ID";
                    cbonxb.DisplayMember = "TenNXB";
                    cbonxb.DataSource = db.NhaXuatBan.ToList();
                }
                LoadSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu danh mục: " + ex.Message);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmasach.Text) || string.IsNullOrEmpty(txttensach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách và tên sách!");
                return;
            }

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    Sach s = new Sach();
                    s.MaSach = txtmasach.Text;
                    s.TenSach = txttensach.Text;
                  
                    int idTacGia = (int)cbotacgia.SelectedValue;
                    int idLinhVuc = (int)cbolinhvuc.SelectedValue;
                    int idLoai = (int)cboloaisach.SelectedValue;
                    int idNXB = (int)cbonxb.SelectedValue;

                    s.TacGiaID = idTacGia;
                    s.MaTacGia = idTacGia;
                    
                    s.LinhVucID = idLinhVuc;
                    s.MaLinhVuc = idLinhVuc;
                    
                    s.LoaiID = idLoai;
                    s.MaLoai = idLoai;
                    
                    s.NhaXuatBanID = idNXB;
                    s.MaNXB = idNXB;

                    s.GiaMua = int.TryParse(txtgiamua.Text, out int gm) ? gm : 0;
                    s.GiaBia = int.TryParse(txtgiabia.Text, out int gb) ? gb : 0;
                    s.DonGiaBan = s.GiaBia; 
                    s.LanTaiBan = (int)numlantaiban.Value;
                    s.NamXB = dtnamsanxuat.Value;

                    db.Sach.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadSach();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null) msg += "\nInner: " + ex.InnerException.Message;
                MessageBox.Show("Lỗi khi thêm: " + msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvsach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                using (var db = new QUANLYCHSDbContext())
                {
                    string masach = dgvsach.SelectedRows[0].Cells["QuanLyMaSach"].Value?.ToString();
                    var s = db.Sach.FirstOrDefault(x => x.MaSach == masach);
                    if (s != null)
                    {
                        db.Sach.Remove(s);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                LoadSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
           
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
        }
           

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
