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
            label2 = new Label();
            label3 = new Label();
            txtthemnhaxuatban = new TextBox();
            cboxoanhaxuatban = new ComboBox();
            btnthemnhaxuatban = new Button();
            btnxoanhaxuatban = new Button();
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
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1072, 340);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 441);
            label2.Name = "label2";
            label2.Size = new Size(222, 22);
            label2.TabIndex = 2;
            label2.Text = "THÊM NHÀ XUẤT BẢN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 511);
            label3.Name = "label3";
            label3.Size = new Size(208, 22);
            label3.TabIndex = 3;
            label3.Text = "XÓA NHÀ XUẤT BẢN:";
            // 
            // txtthemnhaxuatban
            // 
            txtthemnhaxuatban.Location = new Point(249, 441);
            txtthemnhaxuatban.Name = "txtthemnhaxuatban";
            txtthemnhaxuatban.Size = new Size(692, 30);
            txtthemnhaxuatban.TabIndex = 4;
            // 
            // cboxoanhaxuatban
            // 
            cboxoanhaxuatban.FormattingEnabled = true;
            cboxoanhaxuatban.Location = new Point(249, 508);
            cboxoanhaxuatban.Name = "cboxoanhaxuatban";
            cboxoanhaxuatban.Size = new Size(692, 30);
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
            // 
            // frmquanlynhaxuatban
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 619);
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
            Text = "Quản Lý Nhà Xuất Bản";
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
    }
}