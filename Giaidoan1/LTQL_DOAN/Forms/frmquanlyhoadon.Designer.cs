namespace LTQL
{
    partial class frmquanlyhoadon
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            dataGridView3 = new DataGridView();
            btnchonsua = new Button();
            btnxoahoadon = new Button();
            btnchitiethoadon = new Button();
            groupBox2 = new GroupBox();
            btnluusuahoadon = new Button();
            dtpngaylapsua = new DateTimePicker();
            txttenkhachhangsua = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            dtpngaylapthem = new DateTimePicker();
            txtmahoadonthem = new TextBox();
            txttenkhachhangthem = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnhoanthanhhoadon = new Button();
            btnchonsach = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            numsoluong = new NumericUpDown();
            MaHoaDon = new DataGridViewCheckBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            GiaTien = new DataGridViewTextBoxColumn();
            ChiTietSoLuong = new DataGridViewTextBoxColumn();
            ChiTietTenSach = new DataGridViewTextBoxColumn();
            ChiTietMaSach = new DataGridViewTextBoxColumn();
            ChitietMaHoaDon = new DataGridViewTextBoxColumn();
            ChonMaSach = new DataGridViewTextBoxColumn();
            ChonTenSach = new DataGridViewTextBoxColumn();
            ChonGiaBia = new DataGridViewTextBoxColumn();
            ChonMaTacGia = new DataGridViewTextBoxColumn();
            ChonTenTacGia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numsoluong).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, TenKhachHang, NgayLap, TongTien });
            dataGridView1.Location = new Point(12, 33);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(523, 179);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView3);
            groupBox1.Location = new Point(524, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 232);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỌN SÁCH";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { ChonMaSach, ChonTenSach, ChonGiaBia, ChonMaTacGia, ChonTenTacGia });
            dataGridView3.Location = new Point(6, 38);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 24;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(558, 179);
            dataGridView3.TabIndex = 14;
            // 
            // btnchonsua
            // 
            btnchonsua.Location = new Point(12, 230);
            btnchonsua.Name = "btnchonsua";
            btnchonsua.Size = new Size(145, 31);
            btnchonsua.TabIndex = 3;
            btnchonsua.Text = "Chọn Sửa";
            btnchonsua.UseVisualStyleBackColor = true;
            // 
            // btnxoahoadon
            // 
            btnxoahoadon.Location = new Point(182, 230);
            btnxoahoadon.Name = "btnxoahoadon";
            btnxoahoadon.Size = new Size(145, 31);
            btnxoahoadon.TabIndex = 4;
            btnxoahoadon.Text = "Xóa Hóa Đơn";
            btnxoahoadon.UseVisualStyleBackColor = true;
            // 
            // btnchitiethoadon
            // 
            btnchitiethoadon.BackColor = Color.Beige;
            btnchitiethoadon.Location = new Point(349, 230);
            btnchitiethoadon.Name = "btnchitiethoadon";
            btnchitiethoadon.Size = new Size(186, 31);
            btnchitiethoadon.TabIndex = 5;
            btnchitiethoadon.Text = "Chi Tiết Hóa Đơn";
            btnchitiethoadon.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnluusuahoadon);
            groupBox2.Controls.Add(dtpngaylapsua);
            groupBox2.Controls.Add(txttenkhachhangsua);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 139);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "SỬA HÓA ĐƠN";
            // 
            // btnluusuahoadon
            // 
            btnluusuahoadon.Location = new Point(401, 86);
            btnluusuahoadon.Name = "btnluusuahoadon";
            btnluusuahoadon.Size = new Size(99, 31);
            btnluusuahoadon.TabIndex = 4;
            btnluusuahoadon.Text = "LƯU";
            btnluusuahoadon.UseVisualStyleBackColor = true;
            // 
            // dtpngaylapsua
            // 
            dtpngaylapsua.Format = DateTimePickerFormat.Short;
            dtpngaylapsua.Location = new Point(195, 87);
            dtpngaylapsua.Name = "dtpngaylapsua";
            dtpngaylapsua.Size = new Size(200, 30);
            dtpngaylapsua.TabIndex = 3;
            // 
            // txttenkhachhangsua
            // 
            txttenkhachhangsua.Location = new Point(195, 29);
            txttenkhachhangsua.Name = "txttenkhachhangsua";
            txttenkhachhangsua.Size = new Size(305, 30);
            txttenkhachhangsua.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 87);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 1;
            label4.Text = "NGÀY LẬP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 37);
            label3.Name = "label3";
            label3.Size = new Size(183, 22);
            label3.TabIndex = 0;
            label3.Text = "TÊN KHÁCH HÀNG";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpngaylapthem);
            groupBox3.Controls.Add(txtmahoadonthem);
            groupBox3.Controls.Add(txttenkhachhangthem);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(12, 423);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(506, 184);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "THÊM HÓA ĐƠN";
            // 
            // dtpngaylapthem
            // 
            dtpngaylapthem.Format = DateTimePickerFormat.Short;
            dtpngaylapthem.Location = new Point(195, 136);
            dtpngaylapthem.Name = "dtpngaylapthem";
            dtpngaylapthem.Size = new Size(200, 30);
            dtpngaylapthem.TabIndex = 4;
            // 
            // txtmahoadonthem
            // 
            txtmahoadonthem.Location = new Point(195, 32);
            txtmahoadonthem.Name = "txtmahoadonthem";
            txtmahoadonthem.Size = new Size(305, 30);
            txtmahoadonthem.TabIndex = 3;
            // 
            // txttenkhachhangthem
            // 
            txttenkhachhangthem.Location = new Point(195, 81);
            txttenkhachhangthem.Name = "txttenkhachhangthem";
            txttenkhachhangthem.Size = new Size(305, 30);
            txttenkhachhangthem.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 40);
            label5.Name = "label5";
            label5.Size = new Size(134, 22);
            label5.TabIndex = 2;
            label5.Text = "MÃ HÓA ĐƠN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 89);
            label6.Name = "label6";
            label6.Size = new Size(183, 22);
            label6.TabIndex = 3;
            label6.Text = "TÊN KHÁCH HÀNG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 144);
            label7.Name = "label7";
            label7.Size = new Size(106, 22);
            label7.TabIndex = 4;
            label7.Text = "NGÀY LẬP";
            // 
            // btnhoanthanhhoadon
            // 
            btnhoanthanhhoadon.Location = new Point(876, 522);
            btnhoanthanhhoadon.Name = "btnhoanthanhhoadon";
            btnhoanthanhhoadon.Size = new Size(222, 67);
            btnhoanthanhhoadon.TabIndex = 8;
            btnhoanthanhhoadon.Text = "HOÀN THÀNH HÓA ĐƠN";
            btnhoanthanhhoadon.UseVisualStyleBackColor = true;
            // 
            // btnchonsach
            // 
            btnchonsach.Location = new Point(755, 540);
            btnchonsach.Name = "btnchonsach";
            btnchonsach.Size = new Size(115, 31);
            btnchonsach.TabIndex = 9;
            btnchonsach.Text = "CHỌN";
            btnchonsach.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(524, 544);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 10;
            label1.Text = "SỐ LƯỢNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 8);
            label2.Name = "label2";
            label2.Size = new Size(147, 22);
            label2.TabIndex = 12;
            label2.Text = "Tên Khách Hàng:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.Beige;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ChitietMaHoaDon, ChiTietMaSach, ChiTietTenSach, ChiTietSoLuong, GiaTien, ThanhTien });
            dataGridView2.Location = new Point(541, 33);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(547, 179);
            dataGridView2.TabIndex = 13;
            // 
            // numsoluong
            // 
            numsoluong.Location = new Point(629, 540);
            numsoluong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numsoluong.Name = "numsoluong";
            numsoluong.Size = new Size(120, 30);
            numsoluong.TabIndex = 14;
            numsoluong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            MaHoaDon.Resizable = DataGridViewTriState.True;
            MaHoaDon.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày Lặp";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.FillWeight = 160.42778F;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // GiaTien
            // 
            GiaTien.DataPropertyName = "GiaTien";
            GiaTien.FillWeight = 134.4855F;
            GiaTien.HeaderText = "Giá Tiền";
            GiaTien.MinimumWidth = 6;
            GiaTien.Name = "GiaTien";
            // 
            // ChiTietSoLuong
            // 
            ChiTietSoLuong.DataPropertyName = "ChiTietSoLuong";
            ChiTietSoLuong.FillWeight = 43.02758F;
            ChiTietSoLuong.HeaderText = "Số Lượng";
            ChiTietSoLuong.MinimumWidth = 6;
            ChiTietSoLuong.Name = "ChiTietSoLuong";
            // 
            // ChiTietTenSach
            // 
            ChiTietTenSach.DataPropertyName = "ChiTietTenSach";
            ChiTietTenSach.FillWeight = 155.4588F;
            ChiTietTenSach.HeaderText = "Tên Sách";
            ChiTietTenSach.MinimumWidth = 6;
            ChiTietTenSach.Name = "ChiTietTenSach";
            // 
            // ChiTietMaSach
            // 
            ChiTietMaSach.DataPropertyName = "ChiTietMaSach";
            ChiTietMaSach.FillWeight = 60.4590569F;
            ChiTietMaSach.HeaderText = "Mã Sách";
            ChiTietMaSach.MinimumWidth = 6;
            ChiTietMaSach.Name = "ChiTietMaSach";
            // 
            // ChitietMaHoaDon
            // 
            ChitietMaHoaDon.DataPropertyName = "ChiTietMaHoaDon";
            ChitietMaHoaDon.FillWeight = 46.1411F;
            ChitietMaHoaDon.HeaderText = "Mã Hóa Đơn";
            ChitietMaHoaDon.MinimumWidth = 6;
            ChitietMaHoaDon.Name = "ChitietMaHoaDon";
            // 
            // ChonMaSach
            // 
            ChonMaSach.HeaderText = "Mã Sách";
            ChonMaSach.MinimumWidth = 6;
            ChonMaSach.Name = "ChonMaSach";
            ChonMaSach.ReadOnly = true;
            // 
            // ChonTenSach
            // 
            ChonTenSach.HeaderText = "Tên Sách";
            ChonTenSach.MinimumWidth = 6;
            ChonTenSach.Name = "ChonTenSach";
            ChonTenSach.ReadOnly = true;
            // 
            // ChonGiaBia
            // 
            ChonGiaBia.HeaderText = "Giá Bìa";
            ChonGiaBia.MinimumWidth = 6;
            ChonGiaBia.Name = "ChonGiaBia";
            ChonGiaBia.ReadOnly = true;
            // 
            // ChonMaTacGia
            // 
            ChonMaTacGia.HeaderText = "Mã Tác Giả";
            ChonMaTacGia.MinimumWidth = 6;
            ChonMaTacGia.Name = "ChonMaTacGia";
            ChonMaTacGia.ReadOnly = true;
            // 
            // ChonTenTacGia
            // 
            ChonTenTacGia.HeaderText = "Tên Tác Giả";
            ChonTenTacGia.MinimumWidth = 6;
            ChonTenTacGia.Name = "ChonTenTacGia";
            ChonTenTacGia.ReadOnly = true;
            // 
            // frmquanlyhoadon
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(numsoluong);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnchonsach);
            Controls.Add(btnhoanthanhhoadon);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnchitiethoadon);
            Controls.Add(btnxoahoadon);
            Controls.Add(btnchonsua);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlyhoadon";
            Text = "Quản Lý Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numsoluong).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnchonsua;
        private System.Windows.Forms.Button btnxoahoadon;
        private System.Windows.Forms.Button btnchitiethoadon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnhoanthanhhoadon;
        private System.Windows.Forms.Button btnchonsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnluusuahoadon;
        private System.Windows.Forms.DateTimePicker dtpngaylapsua;
        private System.Windows.Forms.TextBox txttenkhachhangsua;
        private System.Windows.Forms.DateTimePicker dtpngaylapthem;
        private System.Windows.Forms.TextBox txtmahoadonthem;
        private System.Windows.Forms.TextBox txttenkhachhangthem;
        private System.Windows.Forms.NumericUpDown numsoluong;
        private DataGridViewCheckBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn ChonMaSach;
        private DataGridViewTextBoxColumn ChonTenSach;
        private DataGridViewTextBoxColumn ChonGiaBia;
        private DataGridViewTextBoxColumn ChonMaTacGia;
        private DataGridViewTextBoxColumn ChonTenTacGia;
        private DataGridViewTextBoxColumn ChitietMaHoaDon;
        private DataGridViewTextBoxColumn ChiTietMaSach;
        private DataGridViewTextBoxColumn ChiTietTenSach;
        private DataGridViewTextBoxColumn ChiTietSoLuong;
        private DataGridViewTextBoxColumn GiaTien;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}