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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvkho = new System.Windows.Forms.DataGridView();
            this.btnchonsua = new System.Windows.Forms.Button();
            this.btnxoasachkho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmasachkho = new System.Windows.Forms.TextBox();
            this.numsoluongkho = new System.Windows.Forms.NumericUpDown();
            this.btnluukho = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnchonthemkho = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasachthemkho = new System.Windows.Forms.TextBox();
            this.numsoluongthemvaokho = new System.Windows.Forms.NumericUpDown();
            this.btnthemvaokho = new System.Windows.Forms.Button();
            this.dgvchonsachvaokho = new System.Windows.Forms.DataGridView();
            this.chkChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChonMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChonTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLinhVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsoluongkho)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsoluongthemvaokho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchonsachvaokho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvkho
            // 
            this.dgvkho.AllowUserToAddRows = false;
            this.dgvkho.AllowUserToDeleteRows = false;
            this.dgvkho.BackgroundColor = System.Drawing.Color.White;
            this.dgvkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.SoLuong});
            this.dgvkho.Location = new System.Drawing.Point(16, 3);
            this.dgvkho.MultiSelect = false;
            this.dgvkho.Name = "dgvkho";
            this.dgvkho.RowHeadersWidth = 51;
            this.dgvkho.RowTemplate.Height = 24;
            this.dgvkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkho.Size = new System.Drawing.Size(763, 218);
            this.dgvkho.TabIndex = 0;
            this.dgvkho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkho_CellContentClick);
            // 
            // btnchonsua
            // 
            this.btnchonsua.Location = new System.Drawing.Point(27, 227);
            this.btnchonsua.Name = "btnchonsua";
            this.btnchonsua.Size = new System.Drawing.Size(140, 37);
            this.btnchonsua.TabIndex = 1;
            this.btnchonsua.Text = "CHỌN SỬA";
            this.btnchonsua.UseVisualStyleBackColor = true;
            // 
            // btnxoasachkho
            // 
            this.btnxoasachkho.Location = new System.Drawing.Point(650, 227);
            this.btnxoasachkho.Name = "btnxoasachkho";
            this.btnxoasachkho.Size = new System.Drawing.Size(140, 37);
            this.btnxoasachkho.TabIndex = 2;
            this.btnxoasachkho.Text = "XÓA SÁCH";
            this.btnxoasachkho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "MÃ SÁCH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "SỐ LƯỢNG:";
            // 
            // txtmasachkho
            // 
            this.txtmasachkho.Location = new System.Drawing.Point(147, 269);
            this.txtmasachkho.Name = "txtmasachkho";
            this.txtmasachkho.Size = new System.Drawing.Size(547, 30);
            this.txtmasachkho.TabIndex = 5;
            // 
            // numsoluongkho
            // 
            this.numsoluongkho.Location = new System.Drawing.Point(147, 312);
            this.numsoluongkho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsoluongkho.Name = "numsoluongkho";
            this.numsoluongkho.Size = new System.Drawing.Size(382, 30);
            this.numsoluongkho.TabIndex = 6;
            this.numsoluongkho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnluukho
            // 
            this.btnluukho.Location = new System.Drawing.Point(554, 305);
            this.btnluukho.Name = "btnluukho";
            this.btnluukho.Size = new System.Drawing.Size(140, 37);
            this.btnluukho.TabIndex = 7;
            this.btnluukho.Text = "LƯU";
            this.btnluukho.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvchonsachvaokho);
            this.groupBox1.Location = new System.Drawing.Point(12, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 177);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỌN SÁCH";
            // 
            // btnchonthemkho
            // 
            this.btnchonthemkho.Location = new System.Drawing.Point(27, 531);
            this.btnchonthemkho.Name = "btnchonthemkho";
            this.btnchonthemkho.Size = new System.Drawing.Size(140, 37);
            this.btnchonthemkho.TabIndex = 9;
            this.btnchonthemkho.Text = "CHỌN THÊM";
            this.btnchonthemkho.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "MÃ SÁCH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "SỐ LƯỢNG:";
            // 
            // txtmasachthemkho
            // 
            this.txtmasachthemkho.Location = new System.Drawing.Point(132, 573);
            this.txtmasachthemkho.Name = "txtmasachthemkho";
            this.txtmasachthemkho.Size = new System.Drawing.Size(547, 30);
            this.txtmasachthemkho.TabIndex = 12;
            // 
            // numsoluongthemvaokho
            // 
            this.numsoluongthemvaokho.Location = new System.Drawing.Point(132, 611);
            this.numsoluongthemvaokho.Name = "numsoluongthemvaokho";
            this.numsoluongthemvaokho.Size = new System.Drawing.Size(382, 30);
            this.numsoluongthemvaokho.TabIndex = 13;
            // 
            // btnthemvaokho
            // 
            this.btnthemvaokho.Location = new System.Drawing.Point(539, 606);
            this.btnthemvaokho.Name = "btnthemvaokho";
            this.btnthemvaokho.Size = new System.Drawing.Size(140, 37);
            this.btnthemvaokho.TabIndex = 14;
            this.btnthemvaokho.Text = "THÊM";
            this.btnthemvaokho.UseVisualStyleBackColor = true;
            // 
            // dgvchonsachvaokho
            // 
            this.dgvchonsachvaokho.AllowUserToAddRows = false;
            this.dgvchonsachvaokho.AllowUserToDeleteRows = false;
            this.dgvchonsachvaokho.BackgroundColor = System.Drawing.Color.White;
            this.dgvchonsachvaokho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchonsachvaokho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkChon,
            this.ChonMaSach,
            this.ChonTenSach,
            this.TenTacGia,
            this.TenLinhVuc,
            this.TenLoai,
            this.TenNXB,
            this.GiaBan,
            this.SoLuongTon});
            this.dgvchonsachvaokho.Location = new System.Drawing.Point(15, 29);
            this.dgvchonsachvaokho.MultiSelect = false;
            this.dgvchonsachvaokho.Name = "dgvchonsachvaokho";
            this.dgvchonsachvaokho.RowHeadersWidth = 51;
            this.dgvchonsachvaokho.RowTemplate.Height = 24;
            this.dgvchonsachvaokho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvchonsachvaokho.Size = new System.Drawing.Size(986, 142);
            this.dgvchonsachvaokho.TabIndex = 15;
            // 
            // chkChon
            // 
            this.chkChon.Frozen = true;
            this.chkChon.HeaderText = "✔";
            this.chkChon.MinimumWidth = 6;
            this.chkChon.Name = "chkChon";
            this.chkChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkChon.Width = 40;
            // 
            // ChonMaSach
            // 
            this.ChonMaSach.Frozen = true;
            this.ChonMaSach.HeaderText = "Mã Sách";
            this.ChonMaSach.MinimumWidth = 6;
            this.ChonMaSach.Name = "ChonMaSach";
            this.ChonMaSach.ReadOnly = true;
            this.ChonMaSach.Width = 90;
            // 
            // ChonTenSach
            // 
            this.ChonTenSach.Frozen = true;
            this.ChonTenSach.HeaderText = "Tên Sách";
            this.ChonTenSach.MinimumWidth = 6;
            this.ChonTenSach.Name = "ChonTenSach";
            this.ChonTenSach.ReadOnly = true;
            this.ChonTenSach.Width = 180;
            // 
            // TenTacGia
            // 
            this.TenTacGia.HeaderText = "Tác Giả";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            this.TenTacGia.Width = 130;
            // 
            // TenLinhVuc
            // 
            this.TenLinhVuc.HeaderText = "Lĩnh Vực";
            this.TenLinhVuc.MinimumWidth = 6;
            this.TenLinhVuc.Name = "TenLinhVuc";
            this.TenLinhVuc.ReadOnly = true;
            this.TenLinhVuc.Width = 120;
            // 
            // TenLoai
            // 
            this.TenLoai.HeaderText = "Loại";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // TenNXB
            // 
            this.TenNXB.HeaderText = "NBX";
            this.TenNXB.MinimumWidth = 6;
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            this.TenNXB.Width = 120;
            // 
            // GiaBan
            // 
            dataGridViewCellStyle3.Format = "NO";
            this.GiaBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 90;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.HeaderText = "Tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            this.SoLuongTon.Width = 60;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 200;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Width = 400;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 650);
            this.Controls.Add(this.btnthemvaokho);
            this.Controls.Add(this.numsoluongthemvaokho);
            this.Controls.Add(this.txtmasachthemkho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnchonthemkho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnluukho);
            this.Controls.Add(this.numsoluongkho);
            this.Controls.Add(this.txtmasachkho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoasachkho);
            this.Controls.Add(this.btnchonsua);
            this.Controls.Add(this.dgvkho);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form11";
            this.Text = "Quản Lý Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsoluongkho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numsoluongthemvaokho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchonsachvaokho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvchonsachvaokho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasachthemkho;
        private System.Windows.Forms.NumericUpDown numsoluongthemvaokho;
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