using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LTQL
{
    public partial class frmthongke : Form
    {
        string conn = @"Data Source=.;Initial Catalog=TenDatabase;Integrated Security=True";
        public frmthongke()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);

            string sql = @"SELECT MaHoaDon, TenKhachHang, NgayLap, TongTien
                   FROM HoaDon
                   WHERE NgayLap BETWEEN @tungay AND @denngay";

            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@tungay", dtptungay.Value);
            cmd.Parameters.AddWithValue("@denngay", dtpdenngay.Value);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvthongke.DataSource = dt;

            TinhTongTien();
        }
        void TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvthongke.Rows)
            {
                if (row.Cells["TongTien"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["TongTien"].Value);
                }
            }

          
        }

        private void btnxuatthongke_Click(object sender, EventArgs e)
        {

            decimal tong = 0;

            foreach (DataGridViewRow row in dgvthongke.Rows)
            {
                if (row.Cells["TongTien"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["TongTien"].Value);
                }
            }

            MessageBox.Show("Tổng tiền trong khoảng ngày đã chọn là: "
                + tong.ToString("N0") + " VNĐ",
                "Thống kê");

            
        }
    }
    

}
