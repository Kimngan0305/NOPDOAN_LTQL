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
            dgvloaisach = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaLoai = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            txtthemloaisach = new TextBox();
            btnthemloaisach = new Button();
            btnxoaloaisach = new Button();
            cboxoaloaisach = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvloaisach).BeginInit();
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
            // dgvloaisach
            // 
            dgvloaisach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvloaisach.BackgroundColor = Color.White;
            dgvloaisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvloaisach.Columns.AddRange(new DataGridViewColumn[] { ID, MaLoai, TenLoai });
            dgvloaisach.Location = new Point(16, 59);
            dgvloaisach.Name = "dgvloaisach";
            dgvloaisach.ReadOnly = true;
            dgvloaisach.RowHeadersVisible = false;
            dgvloaisach.RowHeadersWidth = 51;
            dgvloaisach.RowTemplate.Height = 24;
            dgvloaisach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvloaisach.Size = new Size(1072, 322);
            dgvloaisach.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // MaLoai
            // 
            MaLoai.HeaderText = "Mã Loại";
            MaLoai.MinimumWidth = 6;
            MaLoai.Name = "MaLoai";
            MaLoai.ReadOnly = true;
            MaLoai.Width = 150;
            // 
            // TenLoai
            // 
            TenLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoai.HeaderText = "Tên Loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
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
            btnxoaloaisach.ForeColor = Color.Red;
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
            // 
            // frmquanlyloaisach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(cboxoaloaisach);
            Controls.Add(btnxoaloaisach);
            Controls.Add(btnthemloaisach);
            Controls.Add(txtthemloaisach);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvloaisach);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlyloaisach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Loại Sách";
            Load += frmquanlyloaisach_Load;
            Resize += frmquanlyloaisach_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvloaisach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvloaisach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtthemloaisach;
        private System.Windows.Forms.Button btnthemloaisach;
        private System.Windows.Forms.Button btnxoaloaisach;
        private System.Windows.Forms.ComboBox cboxoaloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
    }
}
