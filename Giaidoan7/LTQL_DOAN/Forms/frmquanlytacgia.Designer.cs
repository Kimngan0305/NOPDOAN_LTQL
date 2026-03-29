namespace LTQL
{
    partial class frmquanlytacgia
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
            btnthoat = new Button();
            btnluu = new Button();
            btnchon = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            groupBox1 = new GroupBox();
            chkngaymat = new CheckBox();
            chkngaysinh = new CheckBox();
            chkquequan = new CheckBox();
            dtngaymat = new DateTimePicker();
            txtquequan = new TextBox();
            dtngaysinh = new DateTimePicker();
            txttentacgia = new TextBox();
            txtmatacgia = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvtacgia = new DataGridView();
            MaTacGia = new DataGridViewCheckBoxColumn();
            TenTacGia = new DataGridViewTextBoxColumn();
            QueQuan = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            NgayMat = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtacgia).BeginInit();
            SuspendLayout();
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(959, 571);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(129, 42);
            btnthoat.TabIndex = 13;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(959, 503);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(129, 42);
            btnluu.TabIndex = 12;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnchon
            // 
            btnchon.Location = new Point(959, 429);
            btnchon.Name = "btnchon";
            btnchon.Size = new Size(129, 41);
            btnchon.TabIndex = 11;
            btnchon.Text = "Chọn";
            btnchon.UseVisualStyleBackColor = true;
            btnchon.Click += btnchon_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(959, 359);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(129, 41);
            btnxoa.TabIndex = 10;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(959, 278);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(129, 43);
            btnthem.TabIndex = 9;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkngaymat);
            groupBox1.Controls.Add(chkngaysinh);
            groupBox1.Controls.Add(chkquequan);
            groupBox1.Controls.Add(dtngaymat);
            groupBox1.Controls.Add(txtquequan);
            groupBox1.Controls.Add(dtngaysinh);
            groupBox1.Controls.Add(txttentacgia);
            groupBox1.Controls.Add(txtmatacgia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 345);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN TÁC GIẢ";
            // 
            // chkngaymat
            // 
            chkngaymat.AutoSize = true;
            chkngaymat.Location = new Point(743, 270);
            chkngaymat.Name = "chkngaymat";
            chkngaymat.Size = new Size(96, 26);
            chkngaymat.TabIndex = 23;
            chkngaymat.Text = "Chưa rõ";
            chkngaymat.UseVisualStyleBackColor = true;
            // 
            // chkngaysinh
            // 
            chkngaysinh.AutoSize = true;
            chkngaysinh.Location = new Point(743, 213);
            chkngaysinh.Name = "chkngaysinh";
            chkngaysinh.Size = new Size(96, 26);
            chkngaysinh.TabIndex = 22;
            chkngaysinh.Text = "Chưa rõ";
            chkngaysinh.UseVisualStyleBackColor = true;
            // 
            // chkquequan
            // 
            chkquequan.AutoSize = true;
            chkquequan.Location = new Point(743, 157);
            chkquequan.Name = "chkquequan";
            chkquequan.Size = new Size(96, 26);
            chkquequan.TabIndex = 21;
            chkquequan.Text = "Chưa rõ";
            chkquequan.UseVisualStyleBackColor = true;
            // 
            // dtngaymat
            // 
            dtngaymat.Format = DateTimePickerFormat.Short;
            dtngaymat.Location = new Point(164, 270);
            dtngaymat.Name = "dtngaymat";
            dtngaymat.Size = new Size(536, 30);
            dtngaymat.TabIndex = 20;
            // 
            // txtquequan
            // 
            txtquequan.Location = new Point(164, 148);
            txtquequan.Name = "txtquequan";
            txtquequan.Size = new Size(536, 30);
            txtquequan.TabIndex = 19;
            // 
            // dtngaysinh
            // 
            dtngaysinh.Format = DateTimePickerFormat.Short;
            dtngaysinh.Location = new Point(164, 213);
            dtngaysinh.Name = "dtngaysinh";
            dtngaysinh.Size = new Size(536, 30);
            dtngaysinh.TabIndex = 2;
            // 
            // txttentacgia
            // 
            txttentacgia.Location = new Point(164, 92);
            txttentacgia.Name = "txttentacgia";
            txttentacgia.Size = new Size(745, 30);
            txttentacgia.TabIndex = 11;
            // 
            // txtmatacgia
            // 
            txtmatacgia.Location = new Point(164, 34);
            txtmatacgia.Name = "txtmatacgia";
            txtmatacgia.Size = new Size(745, 30);
            txtmatacgia.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 276);
            label5.Name = "label5";
            label5.Size = new Size(113, 22);
            label5.TabIndex = 4;
            label5.Text = "NGÀY MẤT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 221);
            label4.Name = "label4";
            label4.Size = new Size(115, 22);
            label4.TabIndex = 3;
            label4.Text = "NGÀY SINH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 156);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 2;
            label3.Text = "QUÊ QUÁN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 100);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 1;
            label2.Text = "TÊN TÁC GIẢ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 0;
            label1.Text = "MÃ TÁC GIẢ";
            // 
            // dgvtacgia
            // 
            dgvtacgia.AllowUserToAddRows = false;
            dgvtacgia.AllowUserToDeleteRows = false;
            dgvtacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvtacgia.BackgroundColor = Color.White;
            dgvtacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtacgia.Columns.AddRange(new DataGridViewColumn[] { MaTacGia, TenTacGia, QueQuan, NgaySinh, NgayMat });
            dgvtacgia.Dock = DockStyle.Fill;
            dgvtacgia.Location = new Point(0, 0);
            dgvtacgia.MultiSelect = false;
            dgvtacgia.Name = "dgvtacgia";
            dgvtacgia.ReadOnly = true;
            dgvtacgia.RowHeadersVisible = false;
            dgvtacgia.RowHeadersWidth = 51;
            dgvtacgia.RowTemplate.Height = 24;
            dgvtacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvtacgia.Size = new Size(1100, 619);
            dgvtacgia.TabIndex = 7;
            // 
            // MaTacGia
            // 
            MaTacGia.DataPropertyName = "MaTacGia";
            MaTacGia.HeaderText = "Mã Tác Giả";
            MaTacGia.MinimumWidth = 6;
            MaTacGia.Name = "MaTacGia";
            MaTacGia.ReadOnly = true;
            MaTacGia.Resizable = DataGridViewTriState.True;
            MaTacGia.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TenTacGia
            // 
            TenTacGia.DataPropertyName = "TenTacGia";
            TenTacGia.HeaderText = "Tên Tác Giả";
            TenTacGia.MinimumWidth = 6;
            TenTacGia.Name = "TenTacGia";
            TenTacGia.ReadOnly = true;
            // 
            // QueQuan
            // 
            QueQuan.DataPropertyName = "QueQuan";
            QueQuan.HeaderText = "Quê Quán";
            QueQuan.MinimumWidth = 6;
            QueQuan.Name = "QueQuan";
            QueQuan.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // NgayMat
            // 
            NgayMat.DataPropertyName = "NgayMat";
            NgayMat.HeaderText = "Ngày Mất";
            NgayMat.MinimumWidth = 6;
            NgayMat.Name = "NgayMat";
            NgayMat.ReadOnly = true;
            // 
            // frmquanlytacgia
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(btnthoat);
            Controls.Add(btnluu);
            Controls.Add(btnchon);
            Controls.Add(btnxoa);
            Controls.Add(btnthem);
            Controls.Add(groupBox1);
            Controls.Add(dgvtacgia);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlytacgia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tác Giả";
            Load += frmquanlytacgia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtacgia).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.TextBox txttentacgia;
        private System.Windows.Forms.TextBox txtmatacgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtacgia;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.DateTimePicker dtngaymat;
        private System.Windows.Forms.CheckBox chkngaymat;
        private System.Windows.Forms.CheckBox chkngaysinh;
        private System.Windows.Forms.CheckBox chkquequan;
        private DataGridViewCheckBoxColumn MaTacGia;
        private DataGridViewTextBoxColumn TenTacGia;
        private DataGridViewTextBoxColumn QueQuan;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn NgayMat;
    }
}