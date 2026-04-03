namespace LTQL_DOAN.Forms
{
    partial class frmhoadon_chitiet
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
            dataGridView2 = new DataGridView();
            ChitietMaHoaDon = new DataGridViewTextBoxColumn();
            ChiTietSanPham = new DataGridViewTextBoxColumn();
            ChiTietSoLuong = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnxoa = new Button();
            btnxacnhan = new Button();
            numsoluong = new NumericUpDown();
            numdongiaban = new NumericUpDown();
            cbosanpham = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtghichu = new TextBox();
            cbokhachhang = new ComboBox();
            cbonhanvien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnluuhoadon = new Button();
            btninhoadon = new Button();
            btnthoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numsoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numdongiaban).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.Beige;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ChitietMaHoaDon, ChiTietSanPham, ChiTietSoLuong, DonGiaBan, ThanhTien });
            dataGridView2.Location = new Point(6, 151);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1070, 202);
            dataGridView2.TabIndex = 14;
            // 
            // ChitietMaHoaDon
            // 
            ChitietMaHoaDon.DataPropertyName = "ChiTietMaHoaDon";
            ChitietMaHoaDon.FillWeight = 46.1411F;
            ChitietMaHoaDon.HeaderText = "Mã Hóa Đơn";
            ChitietMaHoaDon.MinimumWidth = 6;
            ChitietMaHoaDon.Name = "ChitietMaHoaDon";
            // 
            // ChiTietSanPham
            // 
            ChiTietSanPham.DataPropertyName = "ChiTietSanPham";
            ChiTietSanPham.FillWeight = 155.4588F;
            ChiTietSanPham.HeaderText = "Sản Phẩm";
            ChiTietSanPham.MinimumWidth = 6;
            ChiTietSanPham.Name = "ChiTietSanPham";
            // 
            // ChiTietSoLuong
            // 
            ChiTietSoLuong.DataPropertyName = "ChiTietSoLuong";
            ChiTietSoLuong.FillWeight = 43.02758F;
            ChiTietSoLuong.HeaderText = "Số Lượng";
            ChiTietSoLuong.MinimumWidth = 6;
            ChiTietSoLuong.Name = "ChiTietSoLuong";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            DonGiaBan.FillWeight = 134.4855F;
            DonGiaBan.HeaderText = "Đơn Giá Bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.FillWeight = 160.42778F;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnxacnhan);
            groupBox1.Controls.Add(numsoluong);
            groupBox1.Controls.Add(numdongiaban);
            groupBox1.Controls.Add(cbosanpham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(7, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 359);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn chi tiết";
            // 
            // btnxoa
            // 
            btnxoa.ForeColor = Color.Red;
            btnxoa.Location = new Point(859, 77);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(138, 29);
            btnxoa.TabIndex = 22;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnxacnhan
            // 
            btnxacnhan.Location = new Point(696, 77);
            btnxacnhan.Name = "btnxacnhan";
            btnxacnhan.Size = new Size(138, 29);
            btnxacnhan.TabIndex = 21;
            btnxacnhan.Text = "Xác nhận bán";
            btnxacnhan.UseVisualStyleBackColor = true;
            btnxacnhan.Click += btnxacnhan_Click;
            // 
            // numsoluong
            // 
            numsoluong.Location = new Point(468, 76);
            numsoluong.Name = "numsoluong";
            numsoluong.Size = new Size(150, 30);
            numsoluong.TabIndex = 20;
            // 
            // numdongiaban
            // 
            numdongiaban.Location = new Point(265, 76);
            numdongiaban.Name = "numdongiaban";
            numdongiaban.Size = new Size(150, 30);
            numdongiaban.TabIndex = 19;
            // 
            // cbosanpham
            // 
            cbosanpham.FormattingEnabled = true;
            cbosanpham.Location = new Point(6, 76);
            cbosanpham.Name = "cbosanpham";
            cbosanpham.Size = new Size(194, 30);
            cbosanpham.TabIndex = 18;
            cbosanpham.SelectedIndexChanged += cbosanpham_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 42);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 17;
            label6.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 42);
            label5.Name = "label5";
            label5.Size = new Size(112, 22);
            label5.TabIndex = 16;
            label5.Text = "Đơn giá bán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 42);
            label4.Name = "label4";
            label4.Size = new Size(92, 22);
            label4.TabIndex = 15;
            label4.Text = "Sản phẩm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtghichu);
            groupBox2.Controls.Add(cbokhachhang);
            groupBox2.Controls.Add(cbonhanvien);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(13, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1076, 168);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(151, 114);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(918, 30);
            txtghichu.TabIndex = 5;
            // 
            // cbokhachhang
            // 
            cbokhachhang.FormattingEnabled = true;
            cbokhachhang.Location = new Point(664, 42);
            cbokhachhang.Name = "cbokhachhang";
            cbokhachhang.Size = new Size(405, 30);
            cbokhachhang.TabIndex = 4;
            // 
            // cbonhanvien
            // 
            cbonhanvien.FormattingEnabled = true;
            cbonhanvien.Location = new Point(151, 42);
            cbonhanvien.Name = "cbonhanvien";
            cbonhanvien.Size = new Size(382, 30);
            cbonhanvien.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 117);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 2;
            label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(551, 45);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 45);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập:";
            // 
            // btnluuhoadon
            // 
            btnluuhoadon.ForeColor = Color.Blue;
            btnluuhoadon.Location = new Point(311, 568);
            btnluuhoadon.Name = "btnluuhoadon";
            btnluuhoadon.Size = new Size(138, 29);
            btnluuhoadon.TabIndex = 23;
            btnluuhoadon.Text = "Lưu hóa đơn";
            btnluuhoadon.UseVisualStyleBackColor = true;
            btnluuhoadon.Click += btnluuhoadon_Click;
            // 
            // btninhoadon
            // 
            btninhoadon.Location = new Point(487, 568);
            btninhoadon.Name = "btninhoadon";
            btninhoadon.Size = new Size(138, 29);
            btninhoadon.TabIndex = 24;
            btninhoadon.Text = "In hóa đơn";
            btninhoadon.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.ForeColor = Color.Red;
            btnthoat.Location = new Point(665, 568);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(138, 29);
            btnthoat.TabIndex = 25;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // frmhoadon_chitiet
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 659);
            Controls.Add(btnluuhoadon);
            Controls.Add(btninhoadon);
            Controls.Add(btnthoat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmhoadon_chitiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmhoadon_chitiet_Load;
            Resize += frmhoadon_chitiet_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numsoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numdongiaban).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbokhachhang;
        private ComboBox cbonhanvien;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtghichu;
        private NumericUpDown numsoluong;
        private NumericUpDown numdongiaban;
        private ComboBox cbosanpham;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnxoa;
        private Button btnxacnhan;
        private Button btnluuhoadon;
        private Button btninhoadon;
        private Button btnthoat;
        private DataGridViewTextBoxColumn ChitietMaHoaDon;
        private DataGridViewTextBoxColumn ChiTietSanPham;
        private DataGridViewTextBoxColumn ChiTietSoLuong;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}