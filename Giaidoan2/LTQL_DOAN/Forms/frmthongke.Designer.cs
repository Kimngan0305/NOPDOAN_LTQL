namespace LTQL
{
    partial class frmthongke
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
            dgvthongke = new DataGridView();
            ThongKeMaHoaDon = new DataGridViewTextBoxColumn();
            ThongKeTenKhachHang = new DataGridViewTextBoxColumn();
            ThongKeNgayLap = new DataGridViewTextBoxColumn();
            ThongKetongTien = new DataGridViewTextBoxColumn();
            btntimkiem = new Button();
            btnxuatthongke = new Button();
            btnthoat = new Button();
            label1 = new Label();
            label2 = new Label();
            dtptungay = new DateTimePicker();
            dtpdenngay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvthongke).BeginInit();
            SuspendLayout();
            // 
            // dgvthongke
            // 
            dgvthongke.AllowUserToAddRows = false;
            dgvthongke.AllowUserToDeleteRows = false;
            dgvthongke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvthongke.BackgroundColor = Color.White;
            dgvthongke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvthongke.Columns.AddRange(new DataGridViewColumn[] { ThongKeMaHoaDon, ThongKeTenKhachHang, ThongKeNgayLap, ThongKetongTien });
            dgvthongke.Location = new Point(12, 105);
            dgvthongke.MultiSelect = false;
            dgvthongke.Name = "dgvthongke";
            dgvthongke.ReadOnly = true;
            dgvthongke.RowHeadersWidth = 51;
            dgvthongke.RowTemplate.Height = 24;
            dgvthongke.ScrollBars = ScrollBars.Vertical;
            dgvthongke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvthongke.Size = new Size(1076, 386);
            dgvthongke.TabIndex = 0;
            // 
            // ThongKeMaHoaDon
            // 
            ThongKeMaHoaDon.HeaderText = "Mã Hóa Đơn";
            ThongKeMaHoaDon.MinimumWidth = 6;
            ThongKeMaHoaDon.Name = "ThongKeMaHoaDon";
            ThongKeMaHoaDon.ReadOnly = true;
            // 
            // ThongKeTenKhachHang
            // 
            ThongKeTenKhachHang.HeaderText = "Tên Khách Hàng";
            ThongKeTenKhachHang.MinimumWidth = 6;
            ThongKeTenKhachHang.Name = "ThongKeTenKhachHang";
            ThongKeTenKhachHang.ReadOnly = true;
            // 
            // ThongKeNgayLap
            // 
            ThongKeNgayLap.HeaderText = "Ngày Lặp";
            ThongKeNgayLap.MinimumWidth = 6;
            ThongKeNgayLap.Name = "ThongKeNgayLap";
            ThongKeNgayLap.ReadOnly = true;
            // 
            // ThongKetongTien
            // 
            ThongKetongTien.HeaderText = "Tổng Tiền";
            ThongKetongTien.MinimumWidth = 6;
            ThongKetongTien.Name = "ThongKetongTien";
            ThongKetongTien.ReadOnly = true;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(926, 50);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(162, 40);
            btntimkiem.TabIndex = 1;
            btntimkiem.Text = "TÌM KIẾM";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnxuatthongke
            // 
            btnxuatthongke.Location = new Point(12, 515);
            btnxuatthongke.Name = "btnxuatthongke";
            btnxuatthongke.Size = new Size(195, 40);
            btnxuatthongke.TabIndex = 2;
            btnxuatthongke.Text = "XUẤT THỐNG KÊ";
            btnxuatthongke.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(926, 515);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(162, 40);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "THOÁT";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(99, 22);
            label1.TabIndex = 4;
            label1.Text = "TỪ NGÀY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 68);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 5;
            label2.Text = "ĐẾN NGÀY";
            // 
            // dtptungay
            // 
            dtptungay.Format = DateTimePickerFormat.Short;
            dtptungay.Location = new Point(117, 62);
            dtptungay.Name = "dtptungay";
            dtptungay.Size = new Size(200, 30);
            dtptungay.TabIndex = 6;
            // 
            // dtpdenngay
            // 
            dtpdenngay.Format = DateTimePickerFormat.Short;
            dtpdenngay.Location = new Point(456, 62);
            dtpdenngay.Name = "dtpdenngay";
            dtpdenngay.Size = new Size(200, 30);
            dtpdenngay.TabIndex = 7;
            // 
            // frmthongke
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(dtpdenngay);
            Controls.Add(dtptungay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnthoat);
            Controls.Add(btnxuatthongke);
            Controls.Add(btntimkiem);
            Controls.Add(dgvthongke);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmthongke";
            Text = "Quản Lý Thống Kê";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dgvthongke).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxuatthongke;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private DataGridViewTextBoxColumn ThongKeMaHoaDon;
        private DataGridViewTextBoxColumn ThongKeTenKhachHang;
        private DataGridViewTextBoxColumn ThongKeNgayLap;
        private DataGridViewTextBoxColumn ThongKetongTien;
    }
}