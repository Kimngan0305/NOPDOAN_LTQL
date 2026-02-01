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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtthemnhaxuatban = new System.Windows.Forms.TextBox();
            this.cboxoanhaxuatban = new System.Windows.Forms.ComboBox();
            this.btnthemnhaxuatban = new System.Windows.Forms.Button();
            this.btnxoanhaxuatban = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC NHÀ XUẤT BẢN HIỆN CÓ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 340);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÊM NHÀ XUẤT BẢN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "XÓA NHÀ XUẤT BẢN:";
            // 
            // txtthemnhaxuatban
            // 
            this.txtthemnhaxuatban.Location = new System.Drawing.Point(249, 441);
            this.txtthemnhaxuatban.Name = "txtthemnhaxuatban";
            this.txtthemnhaxuatban.Size = new System.Drawing.Size(692, 30);
            this.txtthemnhaxuatban.TabIndex = 4;
            // 
            // cboxoanhaxuatban
            // 
            this.cboxoanhaxuatban.FormattingEnabled = true;
            this.cboxoanhaxuatban.Location = new System.Drawing.Point(249, 508);
            this.cboxoanhaxuatban.Name = "cboxoanhaxuatban";
            this.cboxoanhaxuatban.Size = new System.Drawing.Size(692, 30);
            this.cboxoanhaxuatban.TabIndex = 5;
            // 
            // btnthemnhaxuatban
            // 
            this.btnthemnhaxuatban.Location = new System.Drawing.Point(958, 440);
            this.btnthemnhaxuatban.Name = "btnthemnhaxuatban";
            this.btnthemnhaxuatban.Size = new System.Drawing.Size(130, 31);
            this.btnthemnhaxuatban.TabIndex = 6;
            this.btnthemnhaxuatban.Text = "Thêm";
            this.btnthemnhaxuatban.UseVisualStyleBackColor = true;
            // 
            // btnxoanhaxuatban
            // 
            this.btnxoanhaxuatban.Location = new System.Drawing.Point(958, 508);
            this.btnxoanhaxuatban.Name = "btnxoanhaxuatban";
            this.btnxoanhaxuatban.Size = new System.Drawing.Size(130, 30);
            this.btnxoanhaxuatban.TabIndex = 7;
            this.btnxoanhaxuatban.Text = "Xóa";
            this.btnxoanhaxuatban.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnxoanhaxuatban);
            this.Controls.Add(this.btnthemnhaxuatban);
            this.Controls.Add(this.cboxoanhaxuatban);
            this.Controls.Add(this.txtthemnhaxuatban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form7";
            this.Text = "Quản Lý Nhà Xuất Bản";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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