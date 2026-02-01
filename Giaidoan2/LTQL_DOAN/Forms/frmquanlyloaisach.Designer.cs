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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvloaisach = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtthemloaisach = new System.Windows.Forms.TextBox();
            this.btnthemloaisach = new System.Windows.Forms.Button();
            this.btnxoaloaisach = new System.Windows.Forms.Button();
            this.cboxoaloaisach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC LOẠI SÁCH HIỆN CÓ";
            // 
            // dgvloaisach
            // 
            this.dgvloaisach.BackgroundColor = System.Drawing.Color.White;
            this.dgvloaisach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaisach.Location = new System.Drawing.Point(16, 59);
            this.dgvloaisach.Name = "dgvloaisach";
            this.dgvloaisach.ReadOnly = true;
            this.dgvloaisach.RowHeadersWidth = 51;
            this.dgvloaisach.RowTemplate.Height = 24;
            this.dgvloaisach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvloaisach.Size = new System.Drawing.Size(1072, 322);
            this.dgvloaisach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÊM LOẠI SÁCH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "XÓA LOẠI SÁCH:";
            // 
            // txtthemloaisach
            // 
            this.txtthemloaisach.Location = new System.Drawing.Point(206, 437);
            this.txtthemloaisach.Name = "txtthemloaisach";
            this.txtthemloaisach.Size = new System.Drawing.Size(745, 30);
            this.txtthemloaisach.TabIndex = 4;
            // 
            // btnthemloaisach
            // 
            this.btnthemloaisach.Location = new System.Drawing.Point(968, 437);
            this.btnthemloaisach.Name = "btnthemloaisach";
            this.btnthemloaisach.Size = new System.Drawing.Size(117, 31);
            this.btnthemloaisach.TabIndex = 6;
            this.btnthemloaisach.Text = "Thêm";
            this.btnthemloaisach.UseVisualStyleBackColor = true;
            // 
            // btnxoaloaisach
            // 
            this.btnxoaloaisach.Location = new System.Drawing.Point(968, 501);
            this.btnxoaloaisach.Name = "btnxoaloaisach";
            this.btnxoaloaisach.Size = new System.Drawing.Size(117, 27);
            this.btnxoaloaisach.TabIndex = 7;
            this.btnxoaloaisach.Text = "Xóa";
            this.btnxoaloaisach.UseVisualStyleBackColor = true;
            // 
            // cboxoaloaisach
            // 
            this.cboxoaloaisach.FormattingEnabled = true;
            this.cboxoaloaisach.Location = new System.Drawing.Point(206, 503);
            this.cboxoaloaisach.Name = "cboxoaloaisach";
            this.cboxoaloaisach.Size = new System.Drawing.Size(745, 30);
            this.cboxoaloaisach.TabIndex = 8;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.cboxoaloaisach);
            this.Controls.Add(this.btnxoaloaisach);
            this.Controls.Add(this.btnthemloaisach);
            this.Controls.Add(this.txtthemloaisach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvloaisach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Quản Lý Loại Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}