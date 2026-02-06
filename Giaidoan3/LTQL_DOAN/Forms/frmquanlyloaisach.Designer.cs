namespace LTQL
{
    partial class frmquanlyloaisach
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
            txtthemloaisach = new TextBox();
            btnthemloaisach = new Button();
            btnxoaloaisach = new Button();
            cboxoaloaisach = new ComboBox();
            listView1 = new ListView();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(358, 22);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÁC LOẠI SÁCH HIỆN CÓ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 437);
            label2.Name = "label2";
            label2.Size = new Size(178, 22);
            label2.TabIndex = 2;
            label2.Text = "THÊM LOẠI SÁCH:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 506);
            label3.Name = "label3";
            label3.Size = new Size(164, 22);
            label3.TabIndex = 3;
            label3.Text = "XÓA LOẠI SÁCH:";
            // 
            // txtthemloaisach
            // 
            txtthemloaisach.Location = new Point(206, 437);
            txtthemloaisach.Name = "txtthemloaisach";
            txtthemloaisach.Size = new Size(745, 30);
            txtthemloaisach.TabIndex = 4;
            // 
            // btnthemloaisach
            // 
            btnthemloaisach.Location = new Point(968, 437);
            btnthemloaisach.Name = "btnthemloaisach";
            btnthemloaisach.Size = new Size(117, 31);
            btnthemloaisach.TabIndex = 6;
            btnthemloaisach.Text = "Thêm";
            btnthemloaisach.UseVisualStyleBackColor = true;
            btnthemloaisach.Click += btnthemloaisach_Click;
            // 
            // btnxoaloaisach
            // 
            btnxoaloaisach.Location = new Point(968, 501);
            btnxoaloaisach.Name = "btnxoaloaisach";
            btnxoaloaisach.Size = new Size(117, 27);
            btnxoaloaisach.TabIndex = 7;
            btnxoaloaisach.Text = "Xóa";
            btnxoaloaisach.UseVisualStyleBackColor = true;
            btnxoaloaisach.Click += btnxoaloaisach_Click;
            // 
            // cboxoaloaisach
            // 
            cboxoaloaisach.FormattingEnabled = true;
            cboxoaloaisach.Location = new Point(206, 503);
            cboxoaloaisach.Name = "cboxoaloaisach";
            cboxoaloaisach.Size = new Size(745, 30);
            cboxoaloaisach.TabIndex = 8;
            cboxoaloaisach.SelectedIndexChanged += cboxoaloaisach_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(1073, 352);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Red;
            btnthoat.Location = new Point(968, 555);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(117, 27);
            btnthoat.TabIndex = 10;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // frmquanlyloaisach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(btnthoat);
            Controls.Add(listView1);
            Controls.Add(cboxoaloaisach);
            Controls.Add(btnxoaloaisach);
            Controls.Add(btnthemloaisach);
            Controls.Add(txtthemloaisach);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlyloaisach";
            Text = "Quản Lý Loại Sách";
            Load += frmquanlyloaisach_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtthemloaisach;
        private System.Windows.Forms.Button btnthemloaisach;
        private System.Windows.Forms.Button btnxoaloaisach;
        private System.Windows.Forms.ComboBox cboxoaloaisach;
        private ListView listView1;
        private Button btnthoat;
    }
}