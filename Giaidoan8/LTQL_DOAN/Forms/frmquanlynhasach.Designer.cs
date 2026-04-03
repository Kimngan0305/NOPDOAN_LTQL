namespace LTQL
{
    partial class frmquanlynhasach
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
            menuStrip1 = new MenuStrip();
            QuanLyToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            sáchToolStripMenuItem1 = new ToolStripMenuItem();
            loạiSáchToolStripMenuItem1 = new ToolStripMenuItem();
            lĩnhVựcToolStripMenuItem1 = new ToolStripMenuItem();
            tácGiảToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            khoToolStripMenuItem1 = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnChiTiếtToolStripMenuItem = new ToolStripMenuItem();
            BaoCao_ThongKeToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem1 = new ToolStripMenuItem();
            thốngKêToolStripMenuItem1 = new ToolStripMenuItem();
            dgvsach = new DataGridView();
            lblnguoidung = new Label();
            lbldoanhthutrongngay = new Label();
            lblsoluongkhach = new Label();
            dateTimePicker1 = new DateTimePicker();
            TenSach = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            LinhVuc = new DataGridViewTextBoxColumn();
            LoaiSach = new DataGridViewTextBoxColumn();
            GiaBia = new DataGridViewTextBoxColumn();
            NXB = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsach).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { QuanLyToolStripMenuItem, BaoCao_ThongKeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // QuanLyToolStripMenuItem
            // 
            QuanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, sáchToolStripMenuItem1, loạiSáchToolStripMenuItem1, lĩnhVựcToolStripMenuItem1, tácGiảToolStripMenuItem1, toolStripMenuItem1, khoToolStripMenuItem1, kháchHàngToolStripMenuItem, nhânViênToolStripMenuItem, hóaĐơnToolStripMenuItem, hóaĐơnChiTiếtToolStripMenuItem });
            QuanLyToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            QuanLyToolStripMenuItem.Size = new Size(85, 23);
            QuanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(221, 26);
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // sáchToolStripMenuItem1
            // 
            sáchToolStripMenuItem1.Name = "sáchToolStripMenuItem1";
            sáchToolStripMenuItem1.Size = new Size(221, 26);
            sáchToolStripMenuItem1.Text = "Sách";
            sáchToolStripMenuItem1.Click += sáchToolStripMenuItem1_Click;
            // 
            // loạiSáchToolStripMenuItem1
            // 
            loạiSáchToolStripMenuItem1.Name = "loạiSáchToolStripMenuItem1";
            loạiSáchToolStripMenuItem1.Size = new Size(221, 26);
            loạiSáchToolStripMenuItem1.Text = "Loại Sách";
            loạiSáchToolStripMenuItem1.Click += loạiSáchToolStripMenuItem1_Click;
            // 
            // lĩnhVựcToolStripMenuItem1
            // 
            lĩnhVựcToolStripMenuItem1.Name = "lĩnhVựcToolStripMenuItem1";
            lĩnhVựcToolStripMenuItem1.Size = new Size(221, 26);
            lĩnhVựcToolStripMenuItem1.Text = "Lĩnh Vực";
            lĩnhVựcToolStripMenuItem1.Click += lĩnhVựcToolStripMenuItem1_Click;
            // 
            // tácGiảToolStripMenuItem1
            // 
            tácGiảToolStripMenuItem1.Name = "tácGiảToolStripMenuItem1";
            tácGiảToolStripMenuItem1.Size = new Size(221, 26);
            tácGiảToolStripMenuItem1.Text = "Tác Giả";
            tácGiảToolStripMenuItem1.Click += tácGiảToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 26);
            toolStripMenuItem1.Text = "Nhà Xuất Bản";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // khoToolStripMenuItem1
            // 
            khoToolStripMenuItem1.Name = "khoToolStripMenuItem1";
            khoToolStripMenuItem1.Size = new Size(221, 26);
            khoToolStripMenuItem1.Text = "Kho";
            khoToolStripMenuItem1.Click += khoToolStripMenuItem1_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(221, 26);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(221, 26);
            nhânViênToolStripMenuItem.Text = "Nhân Viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(221, 26);
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // hóaĐơnChiTiếtToolStripMenuItem
            // 
            hóaĐơnChiTiếtToolStripMenuItem.Name = "hóaĐơnChiTiếtToolStripMenuItem";
            hóaĐơnChiTiếtToolStripMenuItem.Size = new Size(221, 26);
            hóaĐơnChiTiếtToolStripMenuItem.Text = "Hóa Đơn Chi Tiết";
            hóaĐơnChiTiếtToolStripMenuItem.Click += hóaĐơnChiTiếtToolStripMenuItem_Click;
            // 
            // BaoCao_ThongKeToolStripMenuItem
            // 
            BaoCao_ThongKeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { báoCáoToolStripMenuItem1, thốngKêToolStripMenuItem1 });
            BaoCao_ThongKeToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            BaoCao_ThongKeToolStripMenuItem.Name = "BaoCao_ThongKeToolStripMenuItem";
            BaoCao_ThongKeToolStripMenuItem.Size = new Size(164, 23);
            BaoCao_ThongKeToolStripMenuItem.Text = "Báo Cáo_Thống Kê";
            // 
            // báoCáoToolStripMenuItem1
            // 
            báoCáoToolStripMenuItem1.Name = "báoCáoToolStripMenuItem1";
            báoCáoToolStripMenuItem1.Size = new Size(162, 26);
            báoCáoToolStripMenuItem1.Text = "Báo Cáo";
            báoCáoToolStripMenuItem1.Click += báoCáoToolStripMenuItem1_Click;
            // 
            // thốngKêToolStripMenuItem1
            // 
            thốngKêToolStripMenuItem1.Name = "thốngKêToolStripMenuItem1";
            thốngKêToolStripMenuItem1.Size = new Size(162, 26);
            thốngKêToolStripMenuItem1.Text = "Thống Kê";
            thốngKêToolStripMenuItem1.Click += thốngKêToolStripMenuItem1_Click;
            // 
            // dgvsach
            // 
            dgvsach.AllowUserToAddRows = false;
            dgvsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsach.BackgroundColor = Color.White;
            dgvsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsach.Columns.AddRange(new DataGridViewColumn[] { TenSach, TacGia, LinhVuc, LoaiSach, GiaBia, NXB });
            dgvsach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvsach.Location = new Point(12, 77);
            dgvsach.Name = "dgvsach";
            dgvsach.ReadOnly = true;
            dgvsach.RowHeadersVisible = false;
            dgvsach.RowHeadersWidth = 51;
            dgvsach.RowTemplate.Height = 24;
            dgvsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsach.Size = new Size(1076, 417);
            dgvsach.TabIndex = 1;
            // 
            // lblnguoidung
            // 
            lblnguoidung.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblnguoidung.AutoSize = true;
            lblnguoidung.Location = new Point(818, 43);
            lblnguoidung.Name = "lblnguoidung";
            lblnguoidung.Size = new Size(119, 22);
            lblnguoidung.TabIndex = 2;
            lblnguoidung.Text = "Người Dùng :";
            // 
            // lbldoanhthutrongngay
            // 
            lbldoanhthutrongngay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbldoanhthutrongngay.AutoSize = true;
            lbldoanhthutrongngay.Location = new Point(12, 518);
            lbldoanhthutrongngay.Name = "lbldoanhthutrongngay";
            lbldoanhthutrongngay.Size = new Size(199, 22);
            lbldoanhthutrongngay.TabIndex = 3;
            lbldoanhthutrongngay.Text = "Doanh Thu Trong Ngày:";
            // 
            // lblsoluongkhach
            // 
            lblsoluongkhach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblsoluongkhach.AutoSize = true;
            lblsoluongkhach.Location = new Point(63, 563);
            lblsoluongkhach.Name = "lblsoluongkhach";
            lblsoluongkhach.Size = new Size(148, 22);
            lblsoluongkhach.TabIndex = 4;
            lblsoluongkhach.Text = "Số Lượng Khách:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimePicker1.CalendarMonthBackground = Color.Wheat;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(888, 541);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 30);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // TenSach
            // 
            TenSach.HeaderText = "Tên Sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // TacGia
            // 
            TacGia.HeaderText = "Tác Giả";
            TacGia.MinimumWidth = 6;
            TacGia.Name = "TacGia";
            TacGia.ReadOnly = true;
            // 
            // LinhVuc
            // 
            LinhVuc.HeaderText = "Lĩnh Vực";
            LinhVuc.MinimumWidth = 6;
            LinhVuc.Name = "LinhVuc";
            LinhVuc.ReadOnly = true;
            // 
            // LoaiSach
            // 
            LoaiSach.HeaderText = "Loại Sách";
            LoaiSach.MinimumWidth = 6;
            LoaiSach.Name = "LoaiSach";
            LoaiSach.ReadOnly = true;
            // 
            // GiaBia
            // 
            GiaBia.HeaderText = "Giá Bìa";
            GiaBia.MinimumWidth = 6;
            GiaBia.Name = "GiaBia";
            GiaBia.ReadOnly = true;
            // 
            // NXB
            // 
            NXB.HeaderText = "Nhà Xuất Bản";
            NXB.MinimumWidth = 6;
            NXB.Name = "NXB";
            NXB.ReadOnly = true;
            // 
            // frmquanlynhasach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblsoluongkhach);
            Controls.Add(lbldoanhthutrongngay);
            Controls.Add(lblnguoidung);
            Controls.Add(dgvsach);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmquanlynhasach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhà Sách";
            Load += frmquanlynhasach_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsach).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BaoCao_ThongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.Label lblnguoidung;
        private System.Windows.Forms.Label lbldoanhthutrongngay;
        private System.Windows.Forms.Label lblsoluongkhach;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ToolStripMenuItem sáchToolStripMenuItem1;
        private ToolStripMenuItem loạiSáchToolStripMenuItem1;
        private ToolStripMenuItem lĩnhVựcToolStripMenuItem1;
        private ToolStripMenuItem tácGiảToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem khoToolStripMenuItem1;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem1;
        private ToolStripMenuItem thốngKêToolStripMenuItem1;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnChiTiếtToolStripMenuItem;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn LinhVuc;
        private DataGridViewTextBoxColumn LoaiSach;
        private DataGridViewTextBoxColumn GiaBia;
        private DataGridViewTextBoxColumn NXB;
    }
}