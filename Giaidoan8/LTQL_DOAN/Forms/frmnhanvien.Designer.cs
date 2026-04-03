namespace LTQL_DOAN.Forms
{
    partial class frmnhanvien
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
            txtmatkhau = new TextBox();
            txttendangnhap = new TextBox();
            txtdiachi = new TextBox();
            txtdienthoai = new TextBox();
            txthoten = new TextBox();
            btnhuybo = new Button();
            btnluu = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmatkhau);
            groupBox1.Controls.Add(txttendangnhap);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtdienthoai);
            groupBox1.Controls.Add(txthoten);
            groupBox1.Controls.Add(btnhuybo);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 13);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1067, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(567, 87);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(264, 30);
            txtmatkhau.TabIndex = 17;
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(567, 30);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(264, 30);
            txttendangnhap.TabIndex = 16;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(111, 152);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(720, 30);
            txtdiachi.TabIndex = 15;
            // 
            // txtdienthoai
            // 
            txtdienthoai.Location = new Point(111, 90);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(431, 33);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 5;
            label6.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 90);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 160);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 93);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(16, 227);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1067, 256);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap });
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
            // TenDangNhap
            // 
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // frmnhanvien
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 495);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmnhanvien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmnhanvien_Load;
            Resize += frmnhanvien_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnhuybo;
        private Button btnluu;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox txtmatkhau;
        private TextBox txttendangnhap;
        private TextBox txtdiachi;
        private TextBox txtdienthoai;
        private TextBox txthoten;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
    }
}