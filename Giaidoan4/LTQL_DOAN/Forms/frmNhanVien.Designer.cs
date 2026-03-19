namespace QuanLybanHang.Forms
{
    partial class frmNhanVien
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
            btnxuat = new Button();
            btnnhap = new Button();
            btntimkiem = new Button();
            btnthoat = new Button();
            btnhuybo = new Button();
            dgvdanhsachnhanvien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewComboBoxColumn();
            btnluu = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cboquyenhan = new ComboBox();
            txtmatkhau = new TextBox();
            txttendangnhap = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnsua = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachnhanvien).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(99, 117);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(214, 30);
            txtdiachi.TabIndex = 14;
            // 
            // txtdienthoai
            // 
            txtdienthoai.Location = new Point(104, 69);
            txtdienthoai.Name = "txtdienthoai";
            txtdienthoai.Size = new Size(209, 30);
            txtdienthoai.TabIndex = 13;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(104, 26);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(209, 30);
            txthoten.TabIndex = 12;
            // 
            // btnxuat
            // 
            btnxuat.Location = new Point(976, 120);
            btnxuat.Name = "btnxuat";
            btnxuat.Size = new Size(94, 29);
            btnxuat.TabIndex = 11;
            btnxuat.Text = "Xuất";
            btnxuat.UseVisualStyleBackColor = true;
            // 
            // btnnhap
            // 
            btnnhap.Location = new Point(976, 72);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(94, 29);
            btnnhap.TabIndex = 10;
            btnnhap.Text = "Nhập..";
            btnnhap.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(976, 29);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 9;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(876, 120);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 8;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnhuybo
            // 
            btnhuybo.Location = new Point(876, 72);
            btnhuybo.Name = "btnhuybo";
            btnhuybo.Size = new Size(94, 29);
            btnhuybo.TabIndex = 7;
            btnhuybo.Text = "Hủy bỏ";
            btnhuybo.UseVisualStyleBackColor = true;
            btnhuybo.Click += btnhuybo_Click;
            // 
            // dgvdanhsachnhanvien
            // 
            dgvdanhsachnhanvien.AllowUserToAddRows = false;
            dgvdanhsachnhanvien.AllowUserToDeleteRows = false;
            dgvdanhsachnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdanhsachnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhsachnhanvien.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dgvdanhsachnhanvien.Dock = DockStyle.Fill;
            dgvdanhsachnhanvien.Location = new Point(3, 26);
            dgvdanhsachnhanvien.MultiSelect = false;
            dgvdanhsachnhanvien.Name = "dgvdanhsachnhanvien";
            dgvdanhsachnhanvien.RowHeadersVisible = false;
            dgvdanhsachnhanvien.RowHeadersWidth = 51;
            dgvdanhsachnhanvien.Size = new Size(1070, 263);
            dgvdanhsachnhanvien.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ Và Tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền Hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.Resizable = DataGridViewTriState.True;
            QuyenHan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(876, 29);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(94, 29);
            btnluu.TabIndex = 6;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(776, 117);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 5;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(776, 29);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 3;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 72);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 2;
            label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 120);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboquyenhan);
            groupBox1.Controls.Add(txtmatkhau);
            groupBox1.Controls.Add(txttendangnhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtdienthoai);
            groupBox1.Controls.Add(txthoten);
            groupBox1.Controls.Add(btnxuat);
            groupBox1.Controls.Add(btnnhap);
            groupBox1.Controls.Add(btntimkiem);
            groupBox1.Controls.Add(btnthoat);
            groupBox1.Controls.Add(btnhuybo);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1076, 173);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboquyenhan
            // 
            cboquyenhan.FormattingEnabled = true;
            cboquyenhan.Location = new Point(469, 120);
            cboquyenhan.Name = "cboquyenhan";
            cboquyenhan.Size = new Size(209, 30);
            cboquyenhan.TabIndex = 20;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(469, 79);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(209, 30);
            txtmatkhau.TabIndex = 19;
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(469, 32);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(209, 30);
            txttendangnhap.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 127);
            label6.Name = "label6";
            label6.Size = new Size(98, 22);
            label6.TabIndex = 17;
            label6.Text = "Quyền hạn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 79);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 16;
            label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 32);
            label4.Name = "label4";
            label4.Size = new Size(130, 22);
            label4.TabIndex = 15;
            label4.Text = "Tên đăng nhập:";
            // 
            // btnsua
            // 
            btnsua.Location = new Point(776, 72);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 4;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvdanhsachnhanvien);
            groupBox2.Location = new Point(12, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1076, 292);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 495);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachnhanvien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtdiachi;
        private TextBox txtdienthoai;
        private TextBox txthoten;
        private Button btnxuat;
        private Button btnnhap;
        private Button btntimkiem;
        private Button btnthoat;
        private Button btnhuybo;
        private DataGridView dgvdanhsachnhanvien;
        private Button btnluu;
        private Button btnxoa;
        private Button btnthem;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnsua;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn TendangNhap;
        private TextBox txtmatkhau;
        private TextBox txttendangnhap;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewComboBoxColumn QuyenHan;
        private ComboBox cboquyenhan;
    }
}