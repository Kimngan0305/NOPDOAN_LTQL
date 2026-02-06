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
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            sáchToolStripMenuItem = new ToolStripMenuItem();
            lĩnhVựcToolStripMenuItem = new ToolStripMenuItem();
            loạiSáchToolStripMenuItem = new ToolStripMenuItem();
            tácGiảToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            khoToolStripMenuItem = new ToolStripMenuItem();
            nhàXuấtBảnToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            dgvsach = new DataGridView();
            tensach = new DataGridViewTextBoxColumn();
            tacgia = new DataGridViewTextBoxColumn();
            linhvuc = new DataGridViewTextBoxColumn();
            loaisach = new DataGridViewTextBoxColumn();
            giabia = new DataGridViewTextBoxColumn();
            lblnguoidung = new Label();
            lbldoanhthutrongngay = new Label();
            lblsoluongkhach = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbldoanhthu = new Label();
            lblsoluong = new Label();
            lblten = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsach).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, sáchToolStripMenuItem, lĩnhVựcToolStripMenuItem, loạiSáchToolStripMenuItem, tácGiảToolStripMenuItem, hóaĐơnToolStripMenuItem, khoToolStripMenuItem, nhàXuấtBảnToolStripMenuItem, thốngKêToolStripMenuItem, báoCáoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(98, 23);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
            // 
            // sáchToolStripMenuItem
            // 
            sáchToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            sáchToolStripMenuItem.Size = new Size(57, 23);
            sáchToolStripMenuItem.Text = "Sách";
            sáchToolStripMenuItem.Click += sáchToolStripMenuItem_Click;
            // 
            // lĩnhVựcToolStripMenuItem
            // 
            lĩnhVựcToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lĩnhVựcToolStripMenuItem.Name = "lĩnhVựcToolStripMenuItem";
            lĩnhVựcToolStripMenuItem.Size = new Size(91, 23);
            lĩnhVựcToolStripMenuItem.Text = "Lĩnh Vực";
            lĩnhVựcToolStripMenuItem.Click += lĩnhVựcToolStripMenuItem_Click;
            // 
            // loạiSáchToolStripMenuItem
            // 
            loạiSáchToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            loạiSáchToolStripMenuItem.Name = "loạiSáchToolStripMenuItem";
            loạiSáchToolStripMenuItem.Size = new Size(95, 23);
            loạiSáchToolStripMenuItem.Text = "Loại Sách";
            loạiSáchToolStripMenuItem.Click += loạiSáchToolStripMenuItem_Click;
            // 
            // tácGiảToolStripMenuItem
            // 
            tácGiảToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            tácGiảToolStripMenuItem.Size = new Size(81, 23);
            tácGiảToolStripMenuItem.Text = "Tác Giả";
            tácGiảToolStripMenuItem.Click += tácGiảToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(87, 23);
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new Size(53, 23);
            khoToolStripMenuItem.Text = "Kho";
            khoToolStripMenuItem.Click += khoToolStripMenuItem_Click;
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            nhàXuấtBảnToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            nhàXuấtBảnToolStripMenuItem.Size = new Size(124, 23);
            nhàXuấtBảnToolStripMenuItem.Text = "Nhà Xuất Bản";
            nhàXuấtBảnToolStripMenuItem.Click += nhàXuấtBảnToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(93, 23);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(85, 23);
            báoCáoToolStripMenuItem.Text = "Báo Cáo";
            báoCáoToolStripMenuItem.Click += báoCáoToolStripMenuItem_Click;
            // 
            // dgvsach
            // 
            dgvsach.AllowUserToAddRows = false;
            dgvsach.AllowUserToDeleteRows = false;
            dgvsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsach.BackgroundColor = Color.White;
            dgvsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsach.Columns.AddRange(new DataGridViewColumn[] { tensach, tacgia, linhvuc, loaisach, giabia });
            dgvsach.Location = new Point(12, 77);
            dgvsach.Name = "dgvsach";
            dgvsach.ReadOnly = true;
            dgvsach.RowHeadersVisible = false;
            dgvsach.RowHeadersWidth = 51;
            dgvsach.RowTemplate.Height = 24;
            dgvsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsach.Size = new Size(1076, 420);
            dgvsach.TabIndex = 1;
            dgvsach.CellContentClick += dgvsach_CellContentClick;
            // 
            // tensach
            // 
            tensach.HeaderText = "TÊN SÁCH";
            tensach.MinimumWidth = 6;
            tensach.Name = "tensach";
            tensach.ReadOnly = true;
            // 
            // tacgia
            // 
            tacgia.HeaderText = "TÁC GIẢ";
            tacgia.MinimumWidth = 6;
            tacgia.Name = "tacgia";
            tacgia.ReadOnly = true;
            // 
            // linhvuc
            // 
            linhvuc.HeaderText = "LĨNH VỰC";
            linhvuc.MinimumWidth = 6;
            linhvuc.Name = "linhvuc";
            linhvuc.ReadOnly = true;
            // 
            // loaisach
            // 
            loaisach.HeaderText = "LOẠI SÁCH";
            loaisach.MinimumWidth = 6;
            loaisach.Name = "loaisach";
            loaisach.ReadOnly = true;
            // 
            // giabia
            // 
            giabia.HeaderText = "GIÁ BÌA";
            giabia.MinimumWidth = 6;
            giabia.Name = "giabia";
            giabia.ReadOnly = true;
            // 
            // lblnguoidung
            // 
            lblnguoidung.AutoSize = true;
            lblnguoidung.Location = new Point(801, 43);
            lblnguoidung.Name = "lblnguoidung";
            lblnguoidung.Size = new Size(119, 22);
            lblnguoidung.TabIndex = 2;
            lblnguoidung.Text = "Người Dùng :";
            // 
            // lbldoanhthutrongngay
            // 
            lbldoanhthutrongngay.AutoSize = true;
            lbldoanhthutrongngay.Location = new Point(12, 518);
            lbldoanhthutrongngay.Name = "lbldoanhthutrongngay";
            lbldoanhthutrongngay.Size = new Size(199, 22);
            lbldoanhthutrongngay.TabIndex = 3;
            lbldoanhthutrongngay.Text = "Doanh Thu Trong Ngày:";
            // 
            // lblsoluongkhach
            // 
            lblsoluongkhach.AutoSize = true;
            lblsoluongkhach.Location = new Point(63, 563);
            lblsoluongkhach.Name = "lblsoluongkhach";
            lblsoluongkhach.Size = new Size(148, 22);
            lblsoluongkhach.TabIndex = 4;
            lblsoluongkhach.Text = "Số Lượng Khách:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Wheat;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(888, 541);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 30);
            dateTimePicker1.TabIndex = 5;
            // 
            // lbldoanhthu
            // 
            lbldoanhthu.Location = new Point(217, 518);
            lbldoanhthu.Name = "lbldoanhthu";
            lbldoanhthu.Size = new Size(264, 25);
            lbldoanhthu.TabIndex = 6;
            // 
            // lblsoluong
            // 
            lblsoluong.Location = new Point(217, 560);
            lblsoluong.Name = "lblsoluong";
            lblsoluong.Size = new Size(264, 25);
            lblsoluong.TabIndex = 7;
            // 
            // lblten
            // 
            lblten.Location = new Point(917, 40);
            lblten.Name = "lblten";
            lblten.Size = new Size(136, 25);
            lblten.TabIndex = 8;
            // 
            // frmquanlynhasach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(lblten);
            Controls.Add(lblsoluong);
            Controls.Add(lbldoanhthu);
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
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lĩnhVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.Label lblnguoidung;
        private System.Windows.Forms.Label lbldoanhthutrongngay;
        private System.Windows.Forms.Label lblsoluongkhach;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private DataGridViewTextBoxColumn tensach;
        private DataGridViewTextBoxColumn tacgia;
        private DataGridViewTextBoxColumn linhvuc;
        private DataGridViewTextBoxColumn loaisach;
        private DataGridViewTextBoxColumn giabia;
        private Label lbldoanhthu;
        private Label lblsoluong;
        private Label lblten;
    }
}