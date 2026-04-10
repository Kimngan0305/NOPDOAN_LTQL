namespace LTQL
{
    partial class frmquanlysach
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
            dgvsach = new DataGridView();
            Chon = new DataGridViewCheckBoxColumn();
            QuanLyMaSach = new DataGridViewButtonColumn();
            QuanLyTenSach = new DataGridViewButtonColumn();
            QuanLyTacGia = new DataGridViewButtonColumn();
            QuanLyLinhVuc = new DataGridViewButtonColumn();
            QuanLyLoaiSach = new DataGridViewTextBoxColumn();
            QuanLyNXB = new DataGridViewTextBoxColumn();
            QuanLyGiaMua = new DataGridViewTextBoxColumn();
            QuanLyGiaBia = new DataGridViewTextBoxColumn();
            QuanLyLanTaiBan = new DataGridViewTextBoxColumn();
            QuanLyNanXuatBan = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtmasach = new TextBox();
            txttensach = new TextBox();
            cbotacgia = new ComboBox();
            cbolinhvuc = new ComboBox();
            cboloaisach = new ComboBox();
            cbonxb = new ComboBox();
            numlantaiban = new NumericUpDown();
            dtnamsanxuat = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtgiabia = new TextBox();
            txtgiamua = new TextBox();
            btnthem = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvsach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numlantaiban).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvsach
            // 
            dgvsach.AllowUserToAddRows = false;
            dgvsach.AllowUserToDeleteRows = false;
            dgvsach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsach.BackgroundColor = Color.White;
            dgvsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsach.Columns.AddRange(new DataGridViewColumn[] { Chon, QuanLyMaSach, QuanLyTenSach, QuanLyTacGia, QuanLyLinhVuc, QuanLyLoaiSach, QuanLyNXB, QuanLyGiaMua, QuanLyGiaBia, QuanLyLanTaiBan, QuanLyNanXuatBan });
            dgvsach.Location = new Point(0, 0);
            dgvsach.Name = "dgvsach";
            dgvsach.RowHeadersVisible = false;
            dgvsach.RowHeadersWidth = 51;
            dgvsach.RowTemplate.Height = 24;
            dgvsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsach.Size = new Size(1100, 256);
            dgvsach.TabIndex = 0;
            dgvsach.CellContentClick += dgvsach_CellContentClick;
            // 
            // Chon
            // 
            Chon.FillWeight = 50F;
            Chon.HeaderText = "✔";
            Chon.MinimumWidth = 6;
            Chon.Name = "Chon";
            Chon.Resizable = DataGridViewTriState.False;
            // 
            // QuanLyMaSach
            // 
            QuanLyMaSach.HeaderText = "Mã Sách";
            QuanLyMaSach.MinimumWidth = 6;
            QuanLyMaSach.Name = "QuanLyMaSach";
            QuanLyMaSach.Resizable = DataGridViewTriState.True;
            // 
            // QuanLyTenSach
            // 
            QuanLyTenSach.HeaderText = "Tên Sách";
            QuanLyTenSach.MinimumWidth = 6;
            QuanLyTenSach.Name = "QuanLyTenSach";
            QuanLyTenSach.Resizable = DataGridViewTriState.True;
            // 
            // QuanLyTacGia
            // 
            QuanLyTacGia.HeaderText = "Tác Giả";
            QuanLyTacGia.MinimumWidth = 6;
            QuanLyTacGia.Name = "QuanLyTacGia";
            QuanLyTacGia.Resizable = DataGridViewTriState.True;
            // 
            // QuanLyLinhVuc
            // 
            QuanLyLinhVuc.HeaderText = "Lĩnh Vực";
            QuanLyLinhVuc.MinimumWidth = 6;
            QuanLyLinhVuc.Name = "QuanLyLinhVuc";
            QuanLyLinhVuc.Resizable = DataGridViewTriState.True;
            // 
            // QuanLyLoaiSach
            // 
            QuanLyLoaiSach.HeaderText = "Loại Sách";
            QuanLyLoaiSach.MinimumWidth = 6;
            QuanLyLoaiSach.Name = "QuanLyLoaiSach";
            // 
            // QuanLyNXB
            // 
            QuanLyNXB.HeaderText = "NXB";
            QuanLyNXB.MinimumWidth = 6;
            QuanLyNXB.Name = "QuanLyNXB";
            // 
            // QuanLyGiaMua
            // 
            QuanLyGiaMua.HeaderText = "Giá Mua";
            QuanLyGiaMua.MinimumWidth = 6;
            QuanLyGiaMua.Name = "QuanLyGiaMua";
            // 
            // QuanLyGiaBia
            // 
            QuanLyGiaBia.HeaderText = "Giá Bìa";
            QuanLyGiaBia.MinimumWidth = 6;
            QuanLyGiaBia.Name = "QuanLyGiaBia";
            // 
            // QuanLyLanTaiBan
            // 
            QuanLyLanTaiBan.FillWeight = 80F;
            QuanLyLanTaiBan.HeaderText = "Lần Tái Bản";
            QuanLyLanTaiBan.MinimumWidth = 6;
            QuanLyLanTaiBan.Name = "QuanLyLanTaiBan";
            // 
            // QuanLyNanXuatBan
            // 
            QuanLyNanXuatBan.HeaderText = "Năm XB";
            QuanLyNanXuatBan.MinimumWidth = 6;
            QuanLyNanXuatBan.Name = "QuanLyNanXuatBan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã Sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 156);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 2;
            label3.Text = "Tác Giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 221);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 3;
            label4.Text = "Lĩnh Vực";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 282);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 4;
            label5.Text = "Loại Sách";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 47);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 5;
            label6.Text = "Tên NXB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 100);
            label7.Name = "label7";
            label7.Size = new Size(79, 22);
            label7.TabIndex = 6;
            label7.Text = "Gía Mua";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(518, 156);
            label8.Name = "label8";
            label8.Size = new Size(72, 22);
            label8.TabIndex = 7;
            label8.Text = "Gía Bìa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(480, 216);
            label9.Name = "label9";
            label9.Size = new Size(107, 22);
            label9.TabIndex = 8;
            label9.Text = "Lần Tái Bản";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(464, 282);
            label10.Name = "label10";
            label10.Size = new Size(123, 22);
            label10.TabIndex = 9;
            label10.Text = "Năm Sản Xuất";
            // 
            // txtmasach
            // 
            txtmasach.Location = new Point(128, 39);
            txtmasach.Name = "txtmasach";
            txtmasach.Size = new Size(302, 30);
            txtmasach.TabIndex = 10;
            // 
            // txttensach
            // 
            txttensach.Location = new Point(128, 92);
            txttensach.Name = "txttensach";
            txttensach.Size = new Size(302, 30);
            txttensach.TabIndex = 11;
            // 
            // cbotacgia
            // 
            cbotacgia.FormattingEnabled = true;
            cbotacgia.Location = new Point(128, 153);
            cbotacgia.Name = "cbotacgia";
            cbotacgia.Size = new Size(302, 30);
            cbotacgia.TabIndex = 12;
            // 
            // cbolinhvuc
            // 
            cbolinhvuc.FormattingEnabled = true;
            cbolinhvuc.Location = new Point(128, 213);
            cbolinhvuc.Name = "cbolinhvuc";
            cbolinhvuc.Size = new Size(302, 30);
            cbolinhvuc.TabIndex = 13;
            // 
            // cboloaisach
            // 
            cboloaisach.FormattingEnabled = true;
            cboloaisach.Location = new Point(128, 274);
            cboloaisach.Name = "cboloaisach";
            cboloaisach.Size = new Size(302, 30);
            cboloaisach.TabIndex = 14;
            // 
            // cbonxb
            // 
            cbonxb.FormattingEnabled = true;
            cbonxb.Location = new Point(607, 39);
            cbonxb.Name = "cbonxb";
            cbonxb.Size = new Size(302, 30);
            cbonxb.TabIndex = 15;
            // 
            // numlantaiban
            // 
            numlantaiban.Location = new Point(607, 213);
            numlantaiban.Name = "numlantaiban";
            numlantaiban.Size = new Size(302, 30);
            numlantaiban.TabIndex = 18;
            // 
            // dtnamsanxuat
            // 
            dtnamsanxuat.Format = DateTimePickerFormat.Short;
            dtnamsanxuat.Location = new Point(607, 274);
            dtnamsanxuat.Name = "dtnamsanxuat";
            dtnamsanxuat.Size = new Size(302, 30);
            dtnamsanxuat.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtgiabia);
            groupBox1.Controls.Add(txtgiamua);
            groupBox1.Controls.Add(dtnamsanxuat);
            groupBox1.Controls.Add(numlantaiban);
            groupBox1.Controls.Add(cbonxb);
            groupBox1.Controls.Add(cboloaisach);
            groupBox1.Controls.Add(cbolinhvuc);
            groupBox1.Controls.Add(cbotacgia);
            groupBox1.Controls.Add(txttensach);
            groupBox1.Controls.Add(txtmasach);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // txtgiabia
            // 
            txtgiabia.Location = new Point(607, 148);
            txtgiabia.Name = "txtgiabia";
            txtgiabia.Size = new Size(302, 30);
            txtgiabia.TabIndex = 20;
            // 
            // txtgiamua
            // 
            txtgiamua.Location = new Point(607, 92);
            txtgiamua.Name = "txtgiamua";
            txtgiamua.Size = new Size(302, 30);
            txtgiamua.TabIndex = 19;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(959, 318);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(129, 43);
            btnthem.TabIndex = 2;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnxoa
            // 
            btnxoa.ForeColor = Color.Red;
            btnxoa.Location = new Point(954, 404);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(129, 41);
            btnxoa.TabIndex = 3;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Red;
            btnthoat.ForeColor = Color.White;
            btnthoat.Location = new Point(954, 483);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(129, 42);
            btnthoat.TabIndex = 6;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // frmquanlysach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnthem);
            Controls.Add(groupBox1);
            Controls.Add(dgvsach);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlysach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sách";
            Load += frmquanlysach_Load;
            Resize += frmquanlysach_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvsach).EndInit();
            ((System.ComponentModel.ISupportInitialize)numlantaiban).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.ComboBox cbotacgia;
        private System.Windows.Forms.ComboBox cbolinhvuc;
        private System.Windows.Forms.ComboBox cboloaisach;
        private System.Windows.Forms.ComboBox cbonxb;
        private System.Windows.Forms.NumericUpDown numlantaiban;
        private System.Windows.Forms.DateTimePicker dtnamsanxuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private DataGridViewCheckBoxColumn Chon;
        private DataGridViewButtonColumn QuanLyMaSach;
        private DataGridViewButtonColumn QuanLyTenSach;
        private DataGridViewButtonColumn QuanLyTacGia;
        private DataGridViewButtonColumn QuanLyLinhVuc;
        private DataGridViewTextBoxColumn QuanLyLoaiSach;
        private DataGridViewTextBoxColumn QuanLyNXB;
        private DataGridViewTextBoxColumn QuanLyGiaMua;
        private DataGridViewTextBoxColumn QuanLyGiaBia;
        private DataGridViewTextBoxColumn QuanLyLanTaiBan;
        private DataGridViewTextBoxColumn QuanLyNanXuatBan;
        private TextBox txtgiabia;
        private TextBox txtgiamua;
    }
}