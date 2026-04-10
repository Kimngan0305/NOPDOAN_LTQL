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
            dataGridView1 = new DataGridView();
            tickchon = new DataGridViewCheckBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            MaTacGia = new DataGridViewTextBoxColumn();
            TenTacGia = new DataGridViewTextBoxColumn();
            QueQuan = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            NgayMat = new DataGridViewTextBoxColumn();
            btnthoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            groupBox1.Text = "Thông tin tác giả";
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
            chkngaymat.CheckedChanged += chkngaymat_CheckedChanged;
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
            chkngaysinh.CheckedChanged += chkngaysinh_CheckedChanged;
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
            chkquequan.CheckedChanged += chkquequan_CheckedChanged;
            // 
            // dtngaymat
            // 
            dtngaymat.CustomFormat = "dd/MM/yyyy";
            dtngaymat.Format = DateTimePickerFormat.Custom;
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
            dtngaysinh.CustomFormat = "dd/MM/yyyy";
            dtngaysinh.Format = DateTimePickerFormat.Custom;
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
            label5.Size = new Size(87, 22);
            label5.TabIndex = 4;
            label5.Text = "Ngày Mất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 221);
            label4.Name = "label4";
            label4.Size = new Size(91, 22);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 156);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 2;
            label3.Text = "Quê Quán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 100);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên Tác Giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã Tác Giả";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tickchon, ID, MaTacGia, TenTacGia, QueQuan, NgaySinh, NgayMat });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1076, 250);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tickchon
            // 
            tickchon.HeaderText = "✔";
            tickchon.MinimumWidth = 6;
            tickchon.Name = "tickchon";
            tickchon.Visible = false;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // MaTacGia
            // 
            MaTacGia.HeaderText = "Mã Tác Giả";
            MaTacGia.MinimumWidth = 6;
            MaTacGia.Name = "MaTacGia";
            // 
            // TenTacGia
            // 
            TenTacGia.HeaderText = "Tên Tác Giả";
            TenTacGia.MinimumWidth = 6;
            TenTacGia.Name = "TenTacGia";
            // 
            // QueQuan
            // 
            QueQuan.HeaderText = "Quê Quán";
            QueQuan.MinimumWidth = 6;
            QueQuan.Name = "QueQuan";
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // NgayMat
            // 
            NgayMat.HeaderText = "Ngày Mất";
            NgayMat.MinimumWidth = 6;
            NgayMat.Name = "NgayMat";
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Red;
            btnthoat.ForeColor = Color.White;
            btnthoat.Location = new Point(959, 440);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(129, 42);
            btnthoat.TabIndex = 13;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // frmquanlytacgia
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(dataGridView1);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnthem);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlytacgia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tác Giả";
            Load += frmquanlytacgia_Load;
            Resize += frmquanlytacgia_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
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
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.DateTimePicker dtngaymat;
        private System.Windows.Forms.CheckBox chkngaymat;
        private System.Windows.Forms.CheckBox chkngaysinh;
        private System.Windows.Forms.CheckBox chkquequan;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn tickchon;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaTacGia;
        private DataGridViewTextBoxColumn TenTacGia;
        private DataGridViewTextBoxColumn QueQuan;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn NgayMat;
    }
}