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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            dgvsach = new DataGridView();
            MaTacGia = new DataGridViewCheckBoxColumn();
            TenTacGia = new DataGridViewTextBoxColumn();
            QueQuan = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            NgayMat = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsach).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(959, 571);
            button5.Name = "button5";
            button5.Size = new Size(129, 42);
            button5.TabIndex = 13;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(959, 503);
            button4.Name = "button4";
            button4.Size = new Size(129, 42);
            button4.TabIndex = 12;
            button4.Text = "Lưu";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(959, 429);
            button3.Name = "button3";
            button3.Size = new Size(129, 41);
            button3.TabIndex = 11;
            button3.Text = "Chọn";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(959, 359);
            button2.Name = "button2";
            button2.Size = new Size(129, 41);
            button2.TabIndex = 10;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(959, 278);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 9;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
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
            // dgvsach
            // 
            dgvsach.AllowUserToAddRows = false;
            dgvsach.AllowUserToDeleteRows = false;
            dgvsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsach.BackgroundColor = Color.White;
            dgvsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsach.Columns.AddRange(new DataGridViewColumn[] { MaTacGia, TenTacGia, QueQuan, NgaySinh, NgayMat });
            dgvsach.Dock = DockStyle.Fill;
            dgvsach.Location = new Point(0, 0);
            dgvsach.MultiSelect = false;
            dgvsach.Name = "dgvsach";
            dgvsach.ReadOnly = true;
            dgvsach.RowHeadersWidth = 51;
            dgvsach.RowTemplate.Height = 24;
            dgvsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsach.Size = new Size(1100, 619);
            dgvsach.TabIndex = 7;
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
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dgvsach);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlytacgia";
            Text = "Quản Lý Tác Giả";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsach).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.TextBox txttentacgia;
        private System.Windows.Forms.TextBox txtmatacgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvsach;
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