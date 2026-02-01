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
            this.dgvbaocao = new System.Windows.Forms.DataGridView();
            this.MaSachBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSachBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltongdoanhthu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblloinhuan = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaocao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbaocao
            // 
            this.dgvbaocao.AllowUserToAddRows = false;
            this.dgvbaocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbaocao.BackgroundColor = System.Drawing.Color.White;
            this.dgvbaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbaocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSachBanRa,
            this.TenSachBanRa,
            this.SoLuongBanRa});
            this.dgvbaocao.Location = new System.Drawing.Point(12, 12);
            this.dgvbaocao.Name = "dgvbaocao";
            this.dgvbaocao.ReadOnly = true;
            this.dgvbaocao.RowHeadersWidth = 51;
            this.dgvbaocao.RowTemplate.Height = 24;
            this.dgvbaocao.Size = new System.Drawing.Size(556, 361);
            this.dgvbaocao.TabIndex = 0;
            // 
            // MaSachBanRa
            // 
            this.MaSachBanRa.HeaderText = "Mã Sách";
            this.MaSachBanRa.MinimumWidth = 6;
            this.MaSachBanRa.Name = "MaSachBanRa";
            this.MaSachBanRa.ReadOnly = true;
            // 
            // TenSachBanRa
            // 
            this.TenSachBanRa.HeaderText = "Tên Sách";
            this.TenSachBanRa.MinimumWidth = 6;
            this.TenSachBanRa.Name = "TenSachBanRa";
            this.TenSachBanRa.ReadOnly = true;
            // 
            // SoLuongBanRa
            // 
            this.SoLuongBanRa.HeaderText = "Số Lượng Bán Ra";
            this.SoLuongBanRa.MinimumWidth = 6;
            this.SoLuongBanRa.Name = "SoLuongBanRa";
            this.SoLuongBanRa.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TỔNG DOANH THU:";
            // 
            // lbltongdoanhthu
            // 
            this.lbltongdoanhthu.Location = new System.Drawing.Point(207, 402);
            this.lbltongdoanhthu.Name = "lbltongdoanhthu";
            this.lbltongdoanhthu.Size = new System.Drawing.Size(190, 22);
            this.lbltongdoanhthu.TabIndex = 2;
            this.lbltongdoanhthu.Text = "0 VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "LỢI NHUẬN:";
            // 
            // lblloinhuan
            // 
            this.lblloinhuan.Location = new System.Drawing.Point(207, 439);
            this.lblloinhuan.Name = "lblloinhuan";
            this.lblloinhuan.Size = new System.Drawing.Size(190, 22);
            this.lblloinhuan.TabIndex = 4;
            this.lblloinhuan.Text = "0 VND";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(455, 396);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 34);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 634);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.lblloinhuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltongdoanhthu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvbaocao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form12";
            this.Text = "Quản Lý Báo Cáo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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