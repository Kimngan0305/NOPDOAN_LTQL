namespace LTQL
{
    partial class frmquanlysach
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
            dgvsach = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtmasach = new TextBox();
            txttensach = new TextBox();
            cbtacgia = new ComboBox();
            cblinhvuc = new ComboBox();
            cbloaisach = new ComboBox();
            cbtennxb = new ComboBox();
            numgiamua = new NumericUpDown();
            numgiabia = new NumericUpDown();
            numlantaiban = new NumericUpDown();
            dtnamsanxuat = new DateTimePicker();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Chon = new DataGridViewCheckBoxColumn();
            QuanLyMaSach = new DataGridViewButtonColumn();
            QuanLyTenSach = new DataGridViewButtonColumn();
            QuanLyTacGia = new DataGridViewButtonColumn();
            QuanLyLinhVuc = new DataGridViewButtonColumn();
            QuanLyLoaiSach = new DataGridViewTextBoxColumn();
            QuanLyNXB = new DataGridViewTextBoxColumn();
            QuanLyGiaMua = new DataGridViewTextBoxColumn();
            QuanLyGiaBia = new DataGridViewTextBoxColumn();
            QuanLyLanTaiBan = new DataGridViewTextBoxColumn();
            QuanLyNanXuatBan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvsach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numgiamua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numgiabia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numlantaiban).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvsach
            // 
            dgvsach.AllowUserToAddRows = false;
            dgvsach.AllowUserToDeleteRows = false;
            dgvsach.BackgroundColor = Color.White;
            dgvsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsach.Columns.AddRange(new DataGridViewColumn[] { Chon, QuanLyMaSach, QuanLyTenSach, QuanLyTacGia, QuanLyLinhVuc, QuanLyLoaiSach, QuanLyNXB, QuanLyGiaMua, QuanLyGiaBia, QuanLyLanTaiBan, QuanLyNanXuatBan });
            dgvsach.Dock = DockStyle.Top;
            dgvsach.Location = new Point(0, 0);
            dgvsach.Name = "dgvsach";
            dgvsach.ReadOnly = true;
            dgvsach.RowHeadersWidth = 51;
            dgvsach.RowTemplate.Height = 24;
            dgvsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsach.Size = new Size(1100, 256);
            dgvsach.TabIndex = 0;
            dgvsach.CellContentClick += dgvsach_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 0;
            label1.Text = "MÃ SÁCH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 1;
            label2.Text = "TÊN SÁCH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 161);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 2;
            label3.Text = "TÁC GIẢ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 221);
            label4.Name = "label4";
            label4.Size = new Size(102, 22);
            label4.TabIndex = 3;
            label4.Text = "LĨNH VỰC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 282);
            label5.Name = "label5";
            label5.Size = new Size(112, 22);
            label5.TabIndex = 4;
            label5.Text = "LOẠI SÁCH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 47);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 5;
            label6.Text = "TÊN NXB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(508, 100);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 6;
            label7.Text = "GIÁ MUA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(518, 156);
            label8.Name = "label8";
            label8.Size = new Size(83, 22);
            label8.TabIndex = 7;
            label8.Text = "GIÁ BÌA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(469, 221);
            label9.Name = "label9";
            label9.Size = new Size(132, 22);
            label9.TabIndex = 8;
            label9.Text = "LẦN TÁI BẢN";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(444, 282);
            label10.Name = "label10";
            label10.Size = new Size(157, 22);
            label10.TabIndex = 9;
            label10.Text = "NĂM SẢN XUẤT";
            // 
            // txtmasach
            // 
            txtmasach.Location = new Point(128, 39);
            txtmasach.Name = "txtmasach";
            txtmasach.Size = new Size(302, 30);
            txtmasach.TabIndex = 10;
            // 
            // txttensach
            // 
            txttensach.Location = new Point(128, 92);
            txttensach.Name = "txttensach";
            txttensach.Size = new Size(302, 30);
            txttensach.TabIndex = 11;
            // 
            // cbtacgia
            // 
            cbtacgia.FormattingEnabled = true;
            cbtacgia.Location = new Point(128, 153);
            cbtacgia.Name = "cbtacgia";
            cbtacgia.Size = new Size(302, 30);
            cbtacgia.TabIndex = 12;
            // 
            // cblinhvuc
            // 
            cblinhvuc.FormattingEnabled = true;
            cblinhvuc.Location = new Point(128, 213);
            cblinhvuc.Name = "cblinhvuc";
            cblinhvuc.Size = new Size(302, 30);
            cblinhvuc.TabIndex = 13;
            // 
            // cbloaisach
            // 
            cbloaisach.FormattingEnabled = true;
            cbloaisach.Location = new Point(128, 274);
            cbloaisach.Name = "cbloaisach";
            cbloaisach.Size = new Size(302, 30);
            cbloaisach.TabIndex = 14;
            // 
            // cbtennxb
            // 
            cbtennxb.FormattingEnabled = true;
            cbtennxb.Location = new Point(607, 39);
            cbtennxb.Name = "cbtennxb";
            cbtennxb.Size = new Size(302, 30);
            cbtennxb.TabIndex = 15;
            // 
            // numgiamua
            // 
            numgiamua.Location = new Point(607, 92);
            numgiamua.Name = "numgiamua";
            numgiamua.Size = new Size(302, 30);
            numgiamua.TabIndex = 16;
            // 
            // numgiabia
            // 
            numgiabia.Location = new Point(607, 153);
            numgiabia.Name = "numgiabia";
            numgiabia.Size = new Size(302, 30);
            numgiabia.TabIndex = 17;
            // 
            // numlantaiban
            // 
            numlantaiban.Location = new Point(607, 213);
            numlantaiban.Name = "numlantaiban";
            numlantaiban.Size = new Size(302, 30);
            numlantaiban.TabIndex = 18;
            // 
            // dtnamsanxuat
            // 
            dtnamsanxuat.Format = DateTimePickerFormat.Short;
            dtnamsanxuat.Location = new Point(607, 274);
            dtnamsanxuat.Name = "dtnamsanxuat";
            dtnamsanxuat.Size = new Size(302, 30);
            dtnamsanxuat.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtnamsanxuat);
            groupBox1.Controls.Add(numlantaiban);
            groupBox1.Controls.Add(numgiabia);
            groupBox1.Controls.Add(numgiamua);
            groupBox1.Controls.Add(cbtennxb);
            groupBox1.Controls.Add(cbloaisach);
            groupBox1.Controls.Add(cblinhvuc);
            groupBox1.Controls.Add(cbtacgia);
            groupBox1.Controls.Add(txttensach);
            groupBox1.Controls.Add(txtmasach);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN SÁCH";
            // 
            // button1
            // 
            button1.Location = new Point(959, 272);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 2;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(959, 353);
            button2.Name = "button2";
            button2.Size = new Size(129, 41);
            button2.TabIndex = 3;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(959, 423);
            button3.Name = "button3";
            button3.Size = new Size(129, 41);
            button3.TabIndex = 4;
            button3.Text = "Chọn";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(959, 497);
            button4.Name = "button4";
            button4.Size = new Size(129, 42);
            button4.TabIndex = 5;
            button4.Text = "Lưu";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(959, 565);
            button5.Name = "button5";
            button5.Size = new Size(129, 42);
            button5.TabIndex = 6;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = true;
            // 
            // Chon
            // 
            Chon.FillWeight = 131.3276F;
            Chon.HeaderText = "✔";
            Chon.MinimumWidth = 6;
            Chon.Name = "Chon";
            Chon.ReadOnly = true;
            Chon.Width = 50;
            // 
            // QuanLyMaSach
            // 
            QuanLyMaSach.FillWeight = 122.305908F;
            QuanLyMaSach.HeaderText = "Mã Sách";
            QuanLyMaSach.MinimumWidth = 6;
            QuanLyMaSach.Name = "QuanLyMaSach";
            QuanLyMaSach.ReadOnly = true;
            QuanLyMaSach.Resizable = DataGridViewTriState.True;
            QuanLyMaSach.Width = 116;
            // 
            // QuanLyTenSach
            // 
            QuanLyTenSach.FillWeight = 137.233612F;
            QuanLyTenSach.HeaderText = "Tên Sách";
            QuanLyTenSach.MinimumWidth = 6;
            QuanLyTenSach.Name = "QuanLyTenSach";
            QuanLyTenSach.ReadOnly = true;
            QuanLyTenSach.Resizable = DataGridViewTriState.True;
            QuanLyTenSach.Width = 125;
            // 
            // QuanLyTacGia
            // 
            QuanLyTacGia.FillWeight = 108.819923F;
            QuanLyTacGia.HeaderText = "Tác Giả";
            QuanLyTacGia.MinimumWidth = 6;
            QuanLyTacGia.Name = "QuanLyTacGia";
            QuanLyTacGia.ReadOnly = true;
            QuanLyTacGia.Resizable = DataGridViewTriState.True;
            QuanLyTacGia.Width = 125;
            // 
            // QuanLyLinhVuc
            // 
            QuanLyLinhVuc.FillWeight = 98.3000641F;
            QuanLyLinhVuc.HeaderText = "Lĩnh Vực";
            QuanLyLinhVuc.MinimumWidth = 6;
            QuanLyLinhVuc.Name = "QuanLyLinhVuc";
            QuanLyLinhVuc.ReadOnly = true;
            QuanLyLinhVuc.Resizable = DataGridViewTriState.True;
            // 
            // QuanLyLoaiSach
            // 
            QuanLyLoaiSach.FillWeight = 93.2215042F;
            QuanLyLoaiSach.HeaderText = "Loại Sách";
            QuanLyLoaiSach.MinimumWidth = 6;
            QuanLyLoaiSach.Name = "QuanLyLoaiSach";
            QuanLyLoaiSach.ReadOnly = true;
            // 
            // QuanLyNXB
            // 
            QuanLyNXB.FillWeight = 88.74926F;
            QuanLyNXB.HeaderText = "NXB";
            QuanLyNXB.MinimumWidth = 6;
            QuanLyNXB.Name = "QuanLyNXB";
            QuanLyNXB.ReadOnly = true;
            QuanLyNXB.Width = 125;
            // 
            // QuanLyGiaMua
            // 
            QuanLyGiaMua.FillWeight = 84.81097F;
            QuanLyGiaMua.HeaderText = "Giá Mua";
            QuanLyGiaMua.MinimumWidth = 6;
            QuanLyGiaMua.Name = "QuanLyGiaMua";
            QuanLyGiaMua.ReadOnly = true;
            QuanLyGiaMua.Width = 90;
            // 
            // QuanLyGiaBia
            // 
            QuanLyGiaBia.FillWeight = 81.34286F;
            QuanLyGiaBia.HeaderText = "Giá Bìa";
            QuanLyGiaBia.MinimumWidth = 6;
            QuanLyGiaBia.Name = "QuanLyGiaBia";
            QuanLyGiaBia.ReadOnly = true;
            QuanLyGiaBia.Width = 90;
            // 
            // QuanLyLanTaiBan
            // 
            QuanLyLanTaiBan.FillWeight = 78.2888F;
            QuanLyLanTaiBan.HeaderText = "Lần Tái Bản";
            QuanLyLanTaiBan.MinimumWidth = 6;
            QuanLyLanTaiBan.Name = "QuanLyLanTaiBan";
            QuanLyLanTaiBan.ReadOnly = true;
            QuanLyLanTaiBan.Width = 74;
            // 
            // QuanLyNanXuatBan
            // 
            QuanLyNanXuatBan.FillWeight = 75.5993652F;
            QuanLyNanXuatBan.HeaderText = "Năm XB";
            QuanLyNanXuatBan.MinimumWidth = 6;
            QuanLyNanXuatBan.Name = "QuanLyNanXuatBan";
            QuanLyNanXuatBan.ReadOnly = true;
            QuanLyNanXuatBan.Width = 90;
            // 
            // frmquanlysach
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
            Name = "frmquanlysach";
            Text = "Quản Lý Sách";
            ((System.ComponentModel.ISupportInitialize)dgvsach).EndInit();
            ((System.ComponentModel.ISupportInitialize)numgiamua).EndInit();
            ((System.ComponentModel.ISupportInitialize)numgiabia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numlantaiban).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.ComboBox cbtacgia;
        private System.Windows.Forms.ComboBox cblinhvuc;
        private System.Windows.Forms.ComboBox cbloaisach;
        private System.Windows.Forms.ComboBox cbtennxb;
        private System.Windows.Forms.NumericUpDown numgiamua;
        private System.Windows.Forms.NumericUpDown numgiabia;
        private System.Windows.Forms.NumericUpDown numlantaiban;
        private System.Windows.Forms.DateTimePicker dtnamsanxuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DataGridViewCheckBoxColumn Chon;
        private DataGridViewButtonColumn QuanLyMaSach;
        private DataGridViewButtonColumn QuanLyTenSach;
        private DataGridViewButtonColumn QuanLyTacGia;
        private DataGridViewButtonColumn QuanLyLinhVuc;
        private DataGridViewTextBoxColumn QuanLyLoaiSach;
        private DataGridViewTextBoxColumn QuanLyNXB;
        private DataGridViewTextBoxColumn QuanLyGiaMua;
        private DataGridViewTextBoxColumn QuanLyGiaBia;
        private DataGridViewTextBoxColumn QuanLyLanTaiBan;
        private DataGridViewTextBoxColumn QuanLyNanXuatBan;
    }
}