namespace LTQL
{
    partial class frmquanlykho
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvkho = new DataGridView();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            btnchonsua = new Button();
            btnxoasachkho = new Button();
            label1 = new Label();
            label2 = new Label();
            txtmasachkho = new TextBox();
            numsoluongkho = new NumericUpDown();
            btnluukho = new Button();
            groupBox1 = new GroupBox();
            dgvchonsach = new DataGridView();
            chkChon = new DataGridViewCheckBoxColumn();
            ChonMaSach = new DataGridViewTextBoxColumn();
            ChonTenSach = new DataGridViewTextBoxColumn();
            TenTacGia = new DataGridViewTextBoxColumn();
            TenLinhVuc = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenNXB = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            btnchonthemkho = new Button();
            label3 = new Label();
            label4 = new Label();
            txtmasach = new TextBox();
            numsoluong = new NumericUpDown();
            btnthemvaokho = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvkho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numsoluongkho).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvchonsach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numsoluong).BeginInit();
            SuspendLayout();
            // 
            // dgvkho
            // 
            dgvkho.AllowUserToAddRows = false;
            dgvkho.AllowUserToDeleteRows = false;
            dgvkho.BackgroundColor = Color.White;
            dgvkho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkho.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, SoLuong });
            dgvkho.Location = new Point(16, 3);
            dgvkho.MultiSelect = false;
            dgvkho.Name = "dgvkho";
            dgvkho.RowHeadersVisible = false;
            dgvkho.RowHeadersWidth = 51;
            dgvkho.RowTemplate.Height = 24;
            dgvkho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvkho.Size = new Size(763, 218);
            dgvkho.TabIndex = 0;
            dgvkho.CellContentClick += dgvkho_CellContentClick;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã Sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.ReadOnly = true;
            MaSach.Width = 200;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên Sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            TenSach.Width = 400;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // btnchonsua
            // 
            btnchonsua.Location = new Point(27, 227);
            btnchonsua.Name = "btnchonsua";
            btnchonsua.Size = new Size(140, 37);
            btnchonsua.TabIndex = 1;
            btnchonsua.Text = "CHỌN SỬA";
            btnchonsua.UseVisualStyleBackColor = true;
            // 
            // btnxoasachkho
            // 
            btnxoasachkho.Location = new Point(650, 227);
            btnxoasachkho.Name = "btnxoasachkho";
            btnxoasachkho.Size = new Size(140, 37);
            btnxoasachkho.TabIndex = 2;
            btnxoasachkho.Text = "XÓA SÁCH";
            btnxoasachkho.UseVisualStyleBackColor = true;
            btnxoasachkho.Click += btnxoasachkho_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 277);
            label1.Name = "label1";
            label1.Size = new Size(104, 22);
            label1.TabIndex = 3;
            label1.Text = "MÃ SÁCH:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 320);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 4;
            label2.Text = "SỐ LƯỢNG:";
            // 
            // txtmasachkho
            // 
            txtmasachkho.Location = new Point(147, 269);
            txtmasachkho.Name = "txtmasachkho";
            txtmasachkho.Size = new Size(547, 30);
            txtmasachkho.TabIndex = 5;
            // 
            // numsoluongkho
            // 
            numsoluongkho.Location = new Point(147, 312);
            numsoluongkho.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numsoluongkho.Name = "numsoluongkho";
            numsoluongkho.Size = new Size(382, 30);
            numsoluongkho.TabIndex = 6;
            numsoluongkho.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnluukho
            // 
            btnluukho.Location = new Point(554, 305);
            btnluukho.Name = "btnluukho";
            btnluukho.Size = new Size(140, 37);
            btnluukho.TabIndex = 7;
            btnluukho.Text = "LƯU";
            btnluukho.UseVisualStyleBackColor = true;
            btnluukho.Click += btnluukho_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvchonsach);
            groupBox1.Location = new Point(12, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1017, 177);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỌN SÁCH";
            // 
            // dgvchonsach
            // 
            dgvchonsach.AllowUserToAddRows = false;
            dgvchonsach.AllowUserToDeleteRows = false;
            dgvchonsach.BackgroundColor = Color.White;
            dgvchonsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvchonsach.Columns.AddRange(new DataGridViewColumn[] { chkChon, ChonMaSach, ChonTenSach, TenTacGia, TenLinhVuc, TenLoai, TenNXB, GiaBan, SoLuongTon });
            dgvchonsach.Location = new Point(15, 29);
            dgvchonsach.MultiSelect = false;
            dgvchonsach.Name = "dgvchonsach";
            dgvchonsach.RowHeadersVisible = false;
            dgvchonsach.RowHeadersWidth = 51;
            dgvchonsach.RowTemplate.Height = 24;
            dgvchonsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvchonsach.Size = new Size(986, 142);
            dgvchonsach.TabIndex = 15;
            dgvchonsach.CellContentClick += dgvchonsach_CellContentClick;
            // 
            // chkChon
            // 
            chkChon.Frozen = true;
            chkChon.HeaderText = "✔";
            chkChon.MinimumWidth = 6;
            chkChon.Name = "chkChon";
            chkChon.Resizable = DataGridViewTriState.True;
            chkChon.SortMode = DataGridViewColumnSortMode.Automatic;
            chkChon.Width = 40;
            // 
            // ChonMaSach
            // 
            ChonMaSach.Frozen = true;
            ChonMaSach.HeaderText = "Mã Sách";
            ChonMaSach.MinimumWidth = 6;
            ChonMaSach.Name = "ChonMaSach";
            ChonMaSach.ReadOnly = true;
            ChonMaSach.Width = 90;
            // 
            // ChonTenSach
            // 
            ChonTenSach.Frozen = true;
            ChonTenSach.HeaderText = "Tên Sách";
            ChonTenSach.MinimumWidth = 6;
            ChonTenSach.Name = "ChonTenSach";
            ChonTenSach.ReadOnly = true;
            ChonTenSach.Width = 180;
            // 
            // TenTacGia
            // 
            TenTacGia.HeaderText = "Tác Giả";
            TenTacGia.MinimumWidth = 6;
            TenTacGia.Name = "TenTacGia";
            TenTacGia.ReadOnly = true;
            TenTacGia.Width = 130;
            // 
            // TenLinhVuc
            // 
            TenLinhVuc.HeaderText = "Lĩnh Vực";
            TenLinhVuc.MinimumWidth = 6;
            TenLinhVuc.Name = "TenLinhVuc";
            TenLinhVuc.ReadOnly = true;
            TenLinhVuc.Width = 120;
            // 
            // TenLoai
            // 
            TenLoai.HeaderText = "Loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            TenLoai.Width = 125;
            // 
            // TenNXB
            // 
            TenNXB.HeaderText = "NBX";
            TenNXB.MinimumWidth = 6;
            TenNXB.Name = "TenNXB";
            TenNXB.ReadOnly = true;
            TenNXB.Width = 120;
            // 
            // GiaBan
            // 
            dataGridViewCellStyle2.Format = "NO";
            GiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            GiaBan.HeaderText = "Giá Bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            GiaBan.Width = 90;
            // 
            // SoLuongTon
            // 
            SoLuongTon.HeaderText = "Tồn";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            SoLuongTon.Width = 60;
            // 
            // btnchonthemkho
            // 
            btnchonthemkho.Location = new Point(27, 531);
            btnchonthemkho.Name = "btnchonthemkho";
            btnchonthemkho.Size = new Size(140, 37);
            btnchonthemkho.TabIndex = 9;
            btnchonthemkho.Text = "CHỌN THÊM";
            btnchonthemkho.UseVisualStyleBackColor = true;
            btnchonthemkho.Click += btnchonthemkho_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 581);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 10;
            label3.Text = "MÃ SÁCH:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 619);
            label4.Name = "label4";
            label4.Size = new Size(115, 22);
            label4.TabIndex = 11;
            label4.Text = "SỐ LƯỢNG:";
            // 
            // txtmasach
            // 
            txtmasach.Location = new Point(132, 573);
            txtmasach.Name = "txtmasach";
            txtmasach.Size = new Size(547, 30);
            txtmasach.TabIndex = 12;
            // 
            // numsoluong
            // 
            numsoluong.Location = new Point(132, 611);
            numsoluong.Name = "numsoluong";
            numsoluong.Size = new Size(382, 30);
            numsoluong.TabIndex = 13;
            // 
            // btnthemvaokho
            // 
            btnthemvaokho.Location = new Point(539, 606);
            btnthemvaokho.Name = "btnthemvaokho";
            btnthemvaokho.Size = new Size(140, 37);
            btnthemvaokho.TabIndex = 14;
            btnthemvaokho.Text = "THÊM";
            btnthemvaokho.UseVisualStyleBackColor = true;
            btnthemvaokho.Click += btnthemvaokho_Click;
            // 
            // frmquanlykho
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 650);
            Controls.Add(btnthemvaokho);
            Controls.Add(numsoluong);
            Controls.Add(txtmasach);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnchonthemkho);
            Controls.Add(groupBox1);
            Controls.Add(btnluukho);
            Controls.Add(numsoluongkho);
            Controls.Add(txtmasachkho);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnxoasachkho);
            Controls.Add(btnchonsua);
            Controls.Add(dgvkho);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlykho";
            Text = "Quản Lý Kho";
            Load += frmquanlykho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvkho).EndInit();
            ((System.ComponentModel.ISupportInitialize)numsoluongkho).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvchonsach).EndInit();
            ((System.ComponentModel.ISupportInitialize)numsoluong).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvkho;
        private System.Windows.Forms.Button btnchonsua;
        private System.Windows.Forms.Button btnxoasachkho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasachkho;
        private System.Windows.Forms.NumericUpDown numsoluongkho;
        private System.Windows.Forms.Button btnluukho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnchonthemkho;
        private System.Windows.Forms.DataGridView dgvchonsach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.NumericUpDown numsoluong;
        private System.Windows.Forms.Button btnthemvaokho;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChonMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChonTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLinhVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}