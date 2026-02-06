namespace LTQL
{
    partial class frmangnhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txttaikhoan = new TextBox();
            txtmatkhau = new TextBox();
            btndangnhap = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(395, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(324, 37);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập Hệ Thống";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(201, 207);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 1;
            label2.Text = "Tài Khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(201, 307);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu:";
            // 
            // txttaikhoan
            // 
            txttaikhoan.Location = new Point(402, 207);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(443, 30);
            txttaikhoan.TabIndex = 3;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(402, 307);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(443, 30);
            txtmatkhau.TabIndex = 4;
            // 
            // btndangnhap
            // 
            btndangnhap.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btndangnhap.Location = new Point(297, 457);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(148, 62);
            btndangnhap.TabIndex = 5;
            btndangnhap.Text = "Đăng Nhập";
            btndangnhap.UseVisualStyleBackColor = true;
            btndangnhap.Click += button1_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnthoat.Location = new Point(642, 457);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(148, 62);
            btnthoat.TabIndex = 6;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // frmangnhap
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(btnthoat);
            Controls.Add(btndangnhap);
            Controls.Add(txtmatkhau);
            Controls.Add(txttaikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmangnhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
    }
}

