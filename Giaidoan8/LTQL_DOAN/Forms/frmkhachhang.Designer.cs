namespace LTQL_DOAN.Forms
{
    partial class frmkhachhang
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
            txtdiachi = new TextBox();
            txtdienthoai = new TextBox();
            txthoten = new TextBox();
            btnhuybo = new Button();
            btnluu = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(111, 107);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(666, 30);
            txtdiachi.TabIndex = 15;
            // 
            // txtdienthoai
            // 
            txtdienthoai.Location = new Point(513, 33);
            txtdienthoai.Name = "txtdienthoai";
            txtdienthoai.Size = new Size(264, 30);
            txtdienthoai.TabIndex = 14;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(111, 33);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(264, 30);
            txthoten.TabIndex = 13;
            // 
            // btnhuybo
            // 
            btnhuybo.Location = new Point(966, 90);
            btnhuybo.Name = "btnhuybo";
            btnhuybo.Size = new Size(94, 47);
            btnhuybo.TabIndex = 11;
            btnhuybo.Text = "Hủy bỏ";
            btnhuybo.UseVisualStyleBackColor = true;
            btnhuybo.Click += btnhuybo_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(966, 29);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(94, 48);
            btnluu.TabIndex = 10;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnxoa
            // 
            btnxoa.ForeColor = Color.Red;
            btnxoa.Location = new Point(856, 143);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(204, 47);
            btnxoa.TabIndex = 9;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(856, 90);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 47);
            btnsua.TabIndex = 8;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(856, 29);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 48);
            btnthem.TabIndex = 7;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 26);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1059, 227);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.HeaderText = "Điện thoai";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(17, 226);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1067, 256);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 110);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 36);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtdienthoai);
            groupBox1.Controls.Add(txthoten);
            groupBox1.Controls.Add(btnhuybo);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1067, 208);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // frmkhachhang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 495);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmkhachhang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách Hàng";
            Load += frmkhachhang_Load;
            Resize += frmkhachhang_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtdiachi;
        private TextBox txtdienthoai;
        private TextBox txthoten;
        private Button btnhuybo;
        private Button btnluu;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}