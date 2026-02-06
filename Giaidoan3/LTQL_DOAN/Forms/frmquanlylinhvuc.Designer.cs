namespace LTQL
{
    partial class frmquanlylinhvuc
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
            txtthemlinhvuc = new TextBox();
            cboxoalinhvuc = new ComboBox();
            btnthemlinhvuc = new Button();
            btnxoalinhvuc = new Button();
            btnthoat = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(391, 22);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÁC TÊN LĨNH VỰC HIỆN CÓ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 453);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 2;
            label2.Text = "THÊM LĨNH VỰC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 526);
            label3.Name = "label3";
            label3.Size = new Size(154, 22);
            label3.TabIndex = 3;
            label3.Text = "XÓA LĨNH VỰC:";
            // 
            // txtthemlinhvuc
            // 
            txtthemlinhvuc.Location = new Point(186, 450);
            txtthemlinhvuc.Name = "txtthemlinhvuc";
            txtthemlinhvuc.Size = new Size(751, 30);
            txtthemlinhvuc.TabIndex = 4;
            // 
            // cboxoalinhvuc
            // 
            cboxoalinhvuc.FormattingEnabled = true;
            cboxoalinhvuc.Location = new Point(186, 523);
            cboxoalinhvuc.Name = "cboxoalinhvuc";
            cboxoalinhvuc.Size = new Size(751, 30);
            cboxoalinhvuc.TabIndex = 5;
            // 
            // btnthemlinhvuc
            // 
            btnthemlinhvuc.Location = new Point(966, 450);
            btnthemlinhvuc.Name = "btnthemlinhvuc";
            btnthemlinhvuc.Size = new Size(122, 30);
            btnthemlinhvuc.TabIndex = 6;
            btnthemlinhvuc.Text = "Thêm";
            btnthemlinhvuc.UseVisualStyleBackColor = true;
            btnthemlinhvuc.Click += btnthemlinhvuc_Click;
            // 
            // btnxoalinhvuc
            // 
            btnxoalinhvuc.Location = new Point(966, 523);
            btnxoalinhvuc.Name = "btnxoalinhvuc";
            btnxoalinhvuc.Size = new Size(122, 30);
            btnxoalinhvuc.TabIndex = 7;
            btnxoalinhvuc.Text = "Xóa";
            btnxoalinhvuc.UseVisualStyleBackColor = true;
            btnxoalinhvuc.Click += btnxoalinhvuc_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Red;
            btnthoat.Location = new Point(966, 577);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(122, 30);
            btnthoat.TabIndex = 8;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(1076, 393);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmquanlylinhvuc
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(listView1);
            Controls.Add(btnthoat);
            Controls.Add(btnxoalinhvuc);
            Controls.Add(btnthemlinhvuc);
            Controls.Add(cboxoalinhvuc);
            Controls.Add(txtthemlinhvuc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlylinhvuc";
            Text = "Quản Lý Lĩnh Vực";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtthemlinhvuc;
        private System.Windows.Forms.ComboBox cboxoalinhvuc;
        private System.Windows.Forms.Button btnthemlinhvuc;
        private System.Windows.Forms.Button btnxoalinhvuc;
        private Button btnthoat;
        private ListView listView1;
    }
}