using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LTQL_DOAN.DAO;


namespace LTQL
{
    public partial class frmquanlylinhvuc : Form
    {
        public frmquanlylinhvuc()
        {
            InitializeComponent();
            LoadListViewLinhVuc();
            LoadComboBoxLinhVuc();

        }
        void LoadListViewLinhVuc()
        {
            string query = "SELECT TENLINHVUC FROM LINHVUC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            listView1.BeginUpdate();
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("DANH SÁCH CÁC TÊN LĨNH VỰC HIỆN CÓ", 600);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            foreach (DataRow row in data.Rows)
            {
                listView1.Items.Add(row["TENLINHVUC"].ToString());
            }

            listView1.EndUpdate();
        }
        void LoadComboBoxLinhVuc()
        {
            string query = "SELECT TENLINHVUC FROM LINHVUC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            cboxoalinhvuc.DataSource = data;
            cboxoalinhvuc.DisplayMember = "TENLINHVUC";
            cboxoalinhvuc.ValueMember = "TENLINHVUC";
            cboxoalinhvuc.SelectedIndex = -1;
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnthemlinhvuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtthemlinhvuc.Text))
            {
                MessageBox.Show("CHƯA NHẬP TÊN LĨNH VỰC!", "THÔNG BÁO");
                return;
            }

            try
            {
                string query = "INSERT INTO LINHVUC VALUES (N'" + txtthemlinhvuc.Text.Trim() + "')";
                DataProvider.Instance.ExecuteQuery(query);

                LoadListViewLinhVuc();
                LoadComboBoxLinhVuc();
                txtthemlinhvuc.Clear();

                MessageBox.Show("ĐÃ THÊM LĨNH VỰC!", "THÔNG BÁO");
            }
            catch
            {
                MessageBox.Show("LĨNH VỰC ĐÃ TỒN TẠI!", "THÔNG BÁO");
            }
        }

        private void btnxoalinhvuc_Click(object sender, EventArgs e)
        {
            if (cboxoalinhvuc.SelectedIndex == -1)
            {
                MessageBox.Show("CHƯA CHỌN LĨNH VỰC CẦN XÓA!", "THÔNG BÁO");
                return;
            }

            DialogResult d = MessageBox.Show(
                "BẠN CÓ CHẮC CHẮN MUỐN XÓA?",
                "THÔNG BÁO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (d == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM LINHVUC WHERE TENLINHVUC = N'" + cboxoalinhvuc.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query);

                    LoadListViewLinhVuc();
                    LoadComboBoxLinhVuc();

                    MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                }
                catch
                {
                    MessageBox.Show("KHÔNG THỂ XÓA!", "THÔNG BÁO");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
