namespace LTQL
{
    partial class frmquanlynhaxuatban
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaNXB = new DataGridViewTextBoxColumn();
            TenNXB = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            txtthemnhaxuatban = new TextBox();
            cboxoanhaxuatban = new ComboBox();
            btnthemnhaxuatban = new Button();
            btnxoanhaxuatban = new Button();
            btnthoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(402, 22);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÁC NHÀ XUẤT BẢN HIỆN CÓ";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, MaNXB, TenNXB });
            dataGridView1.Location = new Point(16, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1072, 340);
            dataGridView1.TabIndex = 1;
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
            // MaNXB
            // 
            MaNXB.HeaderText = "Mã NXB";
            MaNXB.MinimumWidth = 6;
            MaNXB.Name = "MaNXB";
            MaNXB.ReadOnly = true;
            MaNXB.Width = 150;
            // 
            // TenNXB
            // 
            TenNXB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenNXB.HeaderText = "Tên Nhà Xuất Bản";
            TenNXB.MinimumWidth = 6;
            TenNXB.Name = "TenNXB";
            TenNXB.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 441);
            label2.Name = "label2";
            label2.Size = new Size(175, 22);
            label2.TabIndex = 2;
            label2.Text = "Thêm Nhà Xuất Bản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 511);
            label3.Name = "label3";
            label3.Size = new Size(164, 22);
            label3.TabIndex = 3;
            label3.Text = "Xóa Nhà Xuất Bản:";
            // 
            // txtthemnhaxuatban
            // 
            txtthemnhaxuatban.Location = new Point(193, 441);
            txtthemnhaxuatban.Name = "txtthemnhaxuatban";
            txtthemnhaxuatban.Size = new Size(748, 30);
            txtthemnhaxuatban.TabIndex = 4;
            // 
            // cboxoanhaxuatban
            // 
            cboxoanhaxuatban.FormattingEnabled = true;
            cboxoanhaxuatban.Location = new Point(196, 508);
            cboxoanhaxuatban.Name = "cboxoanhaxuatban";
            cboxoanhaxuatban.Size = new Size(745, 30);
            cboxoanhaxuatban.TabIndex = 5;
            // 
            // btnthemnhaxuatban
            // 
            btnthemnhaxuatban.Location = new Point(958, 440);
            btnthemnhaxuatban.Name = "btnthemnhaxuatban";
            btnthemnhaxuatban.Size = new Size(130, 31);
            btnthemnhaxuatban.TabIndex = 6;
            btnthemnhaxuatban.Text = "Thêm";
            btnthemnhaxuatban.UseVisualStyleBackColor = true;
            btnthemnhaxuatban.Click += btnthemnhaxuatban_Click;
            // 
            // btnxoanhaxuatban
            // 
            btnxoanhaxuatban.ForeColor = Color.Red;
            btnxoanhaxuatban.Location = new Point(958, 508);
            btnxoanhaxuatban.Name = "btnxoanhaxuatban";
            btnxoanhaxuatban.Size = new Size(130, 30);
            btnxoanhaxuatban.TabIndex = 7;
            btnxoanhaxuatban.Text = "Xóa";
            btnxoanhaxuatban.UseVisualStyleBackColor = true;
            btnxoanhaxuatban.Click += btnxoanhaxuatban_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Red;
            btnthoat.ForeColor = Color.White;
            btnthoat.Location = new Point(958, 562);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(130, 30);
            btnthoat.TabIndex = 8;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // frmquanlynhaxuatban
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
            Controls.Add(btnthoat);
            Controls.Add(btnxoanhaxuatban);
            Controls.Add(btnthemnhaxuatban);
            Controls.Add(cboxoanhaxuatban);
            Controls.Add(txtthemnhaxuatban);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmquanlynhaxuatban";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhà Xuất Bản";
            Load += frmquanlynhaxuatban_Load;
            Resize += frmquanlynhaxuatban_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtthemnhaxuatban;
        private System.Windows.Forms.ComboBox cboxoanhaxuatban;
        private System.Windows.Forms.Button btnthemnhaxuatban;
        private System.Windows.Forms.Button btnxoanhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private Button btnthoat;
    }
}
