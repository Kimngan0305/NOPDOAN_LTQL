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

namespace LTQL_DOAN.Forms
{
    public partial class frmhoadon_chitiet : Form
    {
        public frmhoadon_chitiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        QUANLYCHSDbContext context = new QUANLYCHSDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        int id;                                         // Lấy mã hóa đơn (dùng cho Sửa và Xóa) 
        BindingList<ChiTietHoaDon> hoaDonChiTiet = new BindingList<ChiTietHoaDon>();

        public void LayNhanVienVaoComboBox()
        {
            cbonhanvien.DataSource = context.NhanVien.ToList();
            cbonhanvien.ValueMember = "ID";
            cbonhanvien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cbokhachhang.DataSource = context.KhachHang.ToList();
            cbokhachhang.ValueMember = "ID";
            cbokhachhang.DisplayMember = "HoVaTen";
        }

        public void LaySanPhamVaoComboBox()
        {
            cbosanpham.DataSource = context.Sach.ToList();
            cbosanpham.ValueMember = "ID";
            cbosanpham.DisplayMember = "TenSanPham";
        }

        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView2.Rows.Count == 0) // Thêm 
            {
                // Xóa trắng các trường 
                cbokhachhang.Text = "";
                cbonhanvien.Text = "";
                cbosanpham.Text = "";
                numsoluong.Value = 1;
                numdongiaban.Value = 0;
            }

            // Nút lưu và xóa chỉ sáng khi có sản phẩm 
            btnluuhoadon.Enabled = dataGridView2.Rows.Count > 0;
            btnxoa.Enabled = dataGridView2.Rows.Count > 0;
        }
        private void frmhoadon_chitiet_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();
            dataGridView2.AutoGenerateColumns = false;
            if (id != 0) // Đã tồn tại chi tiết 
            {
                var hoaDon = context.HoaDon.Where(r => r.ID == id).SingleOrDefault();
                cbonhanvien.SelectedValue = hoaDon.NhanVienID;
                cbokhachhang.SelectedValue = hoaDon.KhachHangID;
                txtghichu.Text = hoaDon.GhiChuHoaDon;

                var ct = context.ChiTietHoaDon.Where(r => r.HoaDonID == id).Select(r => new ChiTietHoaDon
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSach = r.Sach.TenSach,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();

                hoaDonChiTiet = new BindingList<ChiTietHoaDon>(ct);
            }

            dataGridView2.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(dataGridView2.CurrentRow.Cells["SanPhamID"].Value.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbonhanvien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cbokhachhang.Text))
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0) // Đã tồn tại chi tiết thì chỉ cập nhật 
                {
                    HoaDon hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cbonhanvien.SelectedValue.ToString());
                        hd.KhachHangID = Convert.ToInt32(cbokhachhang.SelectedValue.ToString());
                        hd.GhiChuHoaDon = txtghichu.Text;
                        context.HoaDon.Update(hd);
                        // Xóa chi tiết cũ 
                        var old = context.ChiTietHoaDon.Where(r => r.HoaDonID == id).ToList();
                        context.ChiTietHoaDon.RemoveRange(old);

                        // Thêm lại chi tiết mới 
                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            ChiTietHoaDon ct = new ChiTietHoaDon();
                            ct.HoaDonID = id;
                            ct.SanPhamID = item.SanPhamID;
                            ct.SoLuongBan = item.SoLuongBan;
                            ct.DonGiaBan = item.DonGiaBan;
                            context.ChiTietHoaDon.Add(ct);
                        }

                        context.SaveChanges();
                    }
                }
                else // Thêm mới 
                {
                    HoaDon hd = new HoaDon();
                    hd.NhanVienID = Convert.ToInt32(cbonhanvien.SelectedValue.ToString());
                    hd.KhachHangID = Convert.ToInt32(cbokhachhang.SelectedValue.ToString());
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuHoaDon = txtghichu.Text;
                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    // Thêm chi tiết 
                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        ChiTietHoaDon ct = new ChiTietHoaDon();
                        ct.HoaDonID = hd.ID;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuongBan = item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        context.ChiTietHoaDon.Add(ct);
                    }
                    context.SaveChanges();
                }

                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void cbosanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(cbosanpham.SelectedValue.ToString());
            var sanPham = context.Sach.Find(maSanPham);
            numdongiaban.Value = sanPham.DonGiaBan;
        }
    }



}
