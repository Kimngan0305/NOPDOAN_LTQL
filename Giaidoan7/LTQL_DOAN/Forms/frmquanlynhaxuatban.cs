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
    public partial class frmquanlynhaxuatban : Form
    {
        public frmquanlynhaxuatban()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void frmquanlynhaxuatban_Load(object sender, EventArgs e)
        {
             dt.Columns.Add("TenNXB");
             dt.Rows.Add("NXB Kim Dong");
             dt.Rows.Add("NXB Tre");
             dt.Rows.Add("NXB Giao Duc");

             dataGridView1.DataSource = dt;

            LoadComboBox();
        }
        void LoadComboBox()
        {
            cboxoanhaxuatban.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                cboxoanhaxuatban.Items.Add(row["TenNXB"].ToString());
            }
        }

        private void btnthemnhaxuatban_Click(object sender, EventArgs e)
        {

            if (txtthemnhaxuatban.Text == "")
            {
                MessageBox.Show("Nhập tên nhà xuất bản");
                return;
            }

            dt.Rows.Add(txtthemnhaxuatban.Text);

            LoadComboBox();

            txtthemnhaxuatban.Clear();
        }

        private void btnxoanhaxuatban_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TenNXB"].ToString() == cboxoanhaxuatban.Text)
                {
                    dt.Rows.RemoveAt(i);
                    break;
                }
            }

            LoadComboBox();
        }
    }
}
