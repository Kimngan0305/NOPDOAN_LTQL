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
    public partial class frmquanlyloaisach : Form
    {
        public frmquanlyloaisach()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            cbXoaLoaiSach_SelectedIndexChanged();
        }


        private void frmquanlyloaisach_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listView1_SelectedIndexChanged()
        {
            string query = "Select TENLOAISACH From LOAISACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("DANH SÁCH CÁC LOẠI SÁCH HIỆN CÓ", 610);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["TENLOAISACH"].ToString());
                i++;
            }
        }
        private void cbXoaLoaiSach_SelectedIndexChanged()
        {
            string query = "Select TENLOAISACH From LOAISACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboxoaloaisach.DataSource = data;
            cboxoaloaisach.ValueMember = "TENLOAISACH";
            cboxoaloaisach.DisplayMember = "TENLOAISACH";
            cboxoaloaisach.Text = null;
        }

        private void cboxoaloaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select TENLOAISACH From LOAISACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboxoaloaisach.DataSource = data;
            cboxoaloaisach.ValueMember = "TENLOAISACH";
            cboxoaloaisach.DisplayMember = "TENLOAISACH";
            cboxoaloaisach.Text = null;
        }

        private void btnthemloaisach_Click(object sender, EventArgs e)
        {
            {
                if (txtthemloaisach.Text == "")
                {
                    MessageBox.Show("CHƯA NHẬP TÊN LOẠI SÁCH!", "THÔNG BÁO");
                }
                else
                {
                    try
                    {
                        string query = "Insert Into LOAISACH Values('" + txtthemloaisach.Text + "')";
                        DataTable data = DataProvider.Instance.ExecuteQuery(query);
                        listView1_SelectedIndexChanged();
                        cbXoaLoaiSach_SelectedIndexChanged();
                        txtthemloaisach.Text = "";
                        MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                    }
                    catch
                    {
                        MessageBox.Show("ĐÃ TỒN TẠI!", "THÔNG BÁO");
                    }
                }
            }

        }

        private void btnxoaloaisach_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete From LOAISACH Where TENLOAISACH = '" + cboxoaloaisach.Text.ToString() + "' AND TENLOAISACH NOT IN (Select TENLOAISACH From SACH)";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    listView1_SelectedIndexChanged();
                    cbXoaLoaiSach_SelectedIndexChanged();
                    MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                }
                catch
                {
                    MessageBox.Show("KHÔNG THỂ XÓA!", "THÔNG BÁO");
                }
            }
        }
    }
}
    
