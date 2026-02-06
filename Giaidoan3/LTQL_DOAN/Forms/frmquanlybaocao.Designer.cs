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
            label1 = new Label();
            label2 = new Label();
            btnthoat = new Button();
            listView1 = new ListView();
            txttongdoanhthu = new TextBox();
            txtloinhuan = new TextBox();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 439);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 3;
            label2.Text = "LỢI NHUẬN:";
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(455, 396);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(113, 34);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "THOÁT";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(556, 378);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // txttongdoanhthu
            // 
            txttongdoanhthu.Location = new Point(207, 400);
            txttongdoanhthu.Name = "txttongdoanhthu";
            txttongdoanhthu.Size = new Size(205, 30);
            txttongdoanhthu.TabIndex = 7;
            // 
            // txtloinhuan
            // 
            txtloinhuan.Location = new Point(207, 431);
            txtloinhuan.Name = "txtloinhuan";
            txtloinhuan.Size = new Size(205, 30);
            txtloinhuan.TabIndex = 8;
            // 
            // frmquanlybaocao
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 634);
            Controls.Add(txtloinhuan);
            Controls.Add(txttongdoanhthu);
            Controls.Add(listView1);
            Controls.Add(btnthoat);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlybaocao";
            Text = "Quản Lý Báo Cáo";
            Load += frmquanlybaocao_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private ListView listView1;
        private TextBox txttongdoanhthu;
        private TextBox txtloinhuan;
    }
}