namespace LTQL
{
    partial class frmquanlybaocao
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
            dgvbaocao = new DataGridView();
            MaSachBanRa = new DataGridViewTextBoxColumn();
            TenSachBanRa = new DataGridViewTextBoxColumn();
            SoLuongBanRa = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lbltongdoanhthu = new Label();
            label2 = new Label();
            lblloinhuan = new Label();
            btnthoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvbaocao).BeginInit();
            SuspendLayout();
            // 
            // dgvbaocao
            // 
            dgvbaocao.AllowUserToAddRows = false;
            dgvbaocao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbaocao.BackgroundColor = Color.White;
            dgvbaocao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbaocao.Columns.AddRange(new DataGridViewColumn[] { MaSachBanRa, TenSachBanRa, SoLuongBanRa });
            dgvbaocao.Location = new Point(12, 12);
            dgvbaocao.Name = "dgvbaocao";
            dgvbaocao.ReadOnly = true;
            dgvbaocao.RowHeadersVisible = false;
            dgvbaocao.RowHeadersWidth = 51;
            dgvbaocao.RowTemplate.Height = 24;
            dgvbaocao.Size = new Size(556, 361);
            dgvbaocao.TabIndex = 0;
            // 
            // MaSachBanRa
            // 
            MaSachBanRa.HeaderText = "Mã Sách";
            MaSachBanRa.MinimumWidth = 6;
            MaSachBanRa.Name = "MaSachBanRa";
            MaSachBanRa.ReadOnly = true;
            // 
            // TenSachBanRa
            // 
            TenSachBanRa.HeaderText = "Tên Sách";
            TenSachBanRa.MinimumWidth = 6;
            TenSachBanRa.Name = "TenSachBanRa";
            TenSachBanRa.ReadOnly = true;
            // 
            // SoLuongBanRa
            // 
            SoLuongBanRa.HeaderText = "Số Lượng Bán Ra";
            SoLuongBanRa.MinimumWidth = 6;
            SoLuongBanRa.Name = "SoLuongBanRa";
            SoLuongBanRa.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 402);
            label1.Name = "label1";
            label1.Size = new Size(189, 22);
            label1.TabIndex = 1;
            label1.Text = "TỔNG DOANH THU:";
            // 
            // lbltongdoanhthu
            // 
            lbltongdoanhthu.Location = new Point(207, 402);
            lbltongdoanhthu.Name = "lbltongdoanhthu";
            lbltongdoanhthu.Size = new Size(190, 22);
            lbltongdoanhthu.TabIndex = 2;
            lbltongdoanhthu.Text = "0 VND";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 439);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 3;
            label2.Text = "LỢI NHUẬN:";
            // 
            // lblloinhuan
            // 
            lblloinhuan.Location = new Point(207, 439);
            lblloinhuan.Name = "lblloinhuan";
            lblloinhuan.Size = new Size(190, 22);
            lblloinhuan.TabIndex = 4;
            lblloinhuan.Text = "0 VND";
            // 
            // btnthoat
            // 
            btnthoat.ForeColor = Color.Red;
            btnthoat.Location = new Point(455, 396);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(113, 34);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // frmquanlybaocao
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 634);
            Controls.Add(btnthoat);
            Controls.Add(lblloinhuan);
            Controls.Add(label2);
            Controls.Add(lbltongdoanhthu);
            Controls.Add(label1);
            Controls.Add(dgvbaocao);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlybaocao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Báo Cáo";
            Load += frmquanlybaocao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbaocao).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbaocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSachBanRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSachBanRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBanRa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltongdoanhthu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblloinhuan;
        private System.Windows.Forms.Button btnthoat;
    }
}