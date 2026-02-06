using LTQL_DOAN.DAO;
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
    public partial class frmquanlybaocao : Form
    {
        public frmquanlybaocao()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            txb_TextChanged();
        }
        private void listView1_SelectedIndexChanged()
        {
            string query = "Select CHITIETHOADON.MASACH, TENSACH, SUM(SOLUONG) AS [SỐ LƯỢNG BÁN RA], " +
                "GIAMUA, GIABIA From CHITIETHOADON JOIN SACH ON CHITIETHOADON.MASACH = SACH.MASACH " +
                "Group By CHITIETHOADON.MASACH, SACH.TENSACH, GIAMUA, GIABIA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ SÁCH", 200);
            this.listView1.Columns.Add("TÊN SÁCH", 350);
            this.listView1.Columns.Add("SỐ LƯỢNG BÁN RA", 250);
            this.listView1.Columns.Add("GIÁ MUA", 200);
            this.listView1.Columns.Add("GIÁ BÌA", 200);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MASACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["SỐ LƯỢNG BÁN RA"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIAMUA"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIABIA"].ToString());
                i++;
            }
        }
        private void txb_TextChanged()
        {
            int von = 0;
            int tong = 0;
            float loinhuan;
            foreach (ListViewItem item in this.listView1.Items)
            {

                von = von + (int.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[3].Text));
                tong = tong + (int.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[4].Text));

            }
            loinhuan = tong - von;
            txttongdoanhthu.Text = tong.ToString() + " VND";
            txtloinhuan.Text = loinhuan.ToString() + " VND";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmquanlybaocao_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Clear();

            listView1.Columns.Add("Mã Sách", 150);
            listView1.Columns.Add("Tên Sách", 250);
            listView1.Columns.Add("Số Lượng Bán Ra", 200);

            LoadBaoCao();
        }
        void LoadBaoCao()
        {
            string query = @"SELECT MASACH, TENSACH, SUM(SOLUONG) AS SLBAN
                     FROM CHITIETHOADON
                     JOIN SACH ON CHITIETHOADON.MASACH = SACH.MASACH
                     GROUP BY MASACH, TENSACH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            listView1.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["MASACH"].ToString());
                item.SubItems.Add(row["TENSACH"].ToString());
                item.SubItems.Add(row["SLBAN"].ToString());

                listView1.Items.Add(item);
            }
        }

    }
}
