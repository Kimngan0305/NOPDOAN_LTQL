namespace LTQL_DOAN.Forms
{
    partial class frmhoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnlaphoadon = new Button();
            btninhoadon = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            btntimkiem = new Button();
            btnxuat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1076, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1070, 253);
            dataGridView1.TabIndex = 0;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            // 
            // NgayLap
            // 
            NgayLap.HeaderText = "Ngày Lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            // 
            // XemChiTiet
            // 
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            // 
            // btnlaphoadon
            // 
            btnlaphoadon.ForeColor = Color.Blue;
            btnlaphoadon.Location = new Point(65, 343);
            btnlaphoadon.Name = "btnlaphoadon";
            btnlaphoadon.Size = new Size(143, 53);
            btnlaphoadon.TabIndex = 1;
            btnlaphoadon.Text = "Lập hóa đơn mới";
            btnlaphoadon.UseVisualStyleBackColor = true;
            btnlaphoadon.Click += btnlaphoadon_Click;
            // 
            // btninhoadon
            // 
            btninhoadon.Location = new Point(239, 343);
            btninhoadon.Name = "btninhoadon";
            btninhoadon.Size = new Size(94, 53);
            btninhoadon.TabIndex = 2;
            btninhoadon.Text = "In hóa đơn";
            btninhoadon.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(370, 343);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 53);
            btnsua.TabIndex = 3;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.ForeColor = Color.Red;
            btnxoa.Location = new Point(495, 343);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 53);
            btnxoa.TabIndex = 4;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(626, 343);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 53);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(755, 343);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 53);
            btntimkiem.TabIndex = 6;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnxuat
            // 
            btnxuat.Location = new Point(877, 343);
            btnxuat.Name = "btnxuat";
            btnxuat.Size = new Size(145, 53);
            btnxuat.TabIndex = 7;
            btnxuat.Text = "Xuất Excel";
            btnxuat.UseVisualStyleBackColor = true;
            // 
            // frmhoadon
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 495);
            Controls.Add(btnxuat);
            Controls.Add(btntimkiem);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btninhoadon);
            Controls.Add(btnlaphoadon);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmhoadon";
            Text = "Hóa đơn";
            Load += frmhoadon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnlaphoadon;
        private Button btninhoadon;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthoat;
        private Button btntimkiem;
        private Button btnxuat;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
    }
}