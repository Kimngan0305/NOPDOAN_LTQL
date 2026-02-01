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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlinhvuc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtthemlinhvuc = new System.Windows.Forms.TextBox();
            this.cboxoalinhvuc = new System.Windows.Forms.ComboBox();
            this.btnthemlinhvuc = new System.Windows.Forms.Button();
            this.btnxoalinhvuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlinhvuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC TÊN LĨNH VỰC HIỆN CÓ";
            // 
            // dgvlinhvuc
            // 
            this.dgvlinhvuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvlinhvuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlinhvuc.Location = new System.Drawing.Point(16, 61);
            this.dgvlinhvuc.Name = "dgvlinhvuc";
            this.dgvlinhvuc.ReadOnly = true;
            this.dgvlinhvuc.RowHeadersWidth = 51;
            this.dgvlinhvuc.RowTemplate.Height = 24;
            this.dgvlinhvuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlinhvuc.Size = new System.Drawing.Size(1072, 357);
            this.dgvlinhvuc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÊM LĨNH VỰC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "XÓA LĨNH VỰC:";
            // 
            // txtthemlinhvuc
            // 
            this.txtthemlinhvuc.Location = new System.Drawing.Point(186, 450);
            this.txtthemlinhvuc.Name = "txtthemlinhvuc";
            this.txtthemlinhvuc.Size = new System.Drawing.Size(751, 30);
            this.txtthemlinhvuc.TabIndex = 4;
            // 
            // cboxoalinhvuc
            // 
            this.cboxoalinhvuc.FormattingEnabled = true;
            this.cboxoalinhvuc.Location = new System.Drawing.Point(186, 523);
            this.cboxoalinhvuc.Name = "cboxoalinhvuc";
            this.cboxoalinhvuc.Size = new System.Drawing.Size(751, 30);
            this.cboxoalinhvuc.TabIndex = 5;
            // 
            // btnthemlinhvuc
            // 
            this.btnthemlinhvuc.Location = new System.Drawing.Point(966, 450);
            this.btnthemlinhvuc.Name = "btnthemlinhvuc";
            this.btnthemlinhvuc.Size = new System.Drawing.Size(122, 30);
            this.btnthemlinhvuc.TabIndex = 6;
            this.btnthemlinhvuc.Text = "Thêm";
            this.btnthemlinhvuc.UseVisualStyleBackColor = true;
            // 
            // btnxoalinhvuc
            // 
            this.btnxoalinhvuc.Location = new System.Drawing.Point(966, 523);
            this.btnxoalinhvuc.Name = "btnxoalinhvuc";
            this.btnxoalinhvuc.Size = new System.Drawing.Size(122, 30);
            this.btnxoalinhvuc.TabIndex = 7;
            this.btnxoalinhvuc.Text = "Xóa";
            this.btnxoalinhvuc.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnxoalinhvuc);
            this.Controls.Add(this.btnthemlinhvuc);
            this.Controls.Add(this.cboxoalinhvuc);
            this.Controls.Add(this.txtthemlinhvuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvlinhvuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Quản Lý Lĩnh Vực";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlinhvuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlinhvuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtthemlinhvuc;
        private System.Windows.Forms.ComboBox cboxoalinhvuc;
        private System.Windows.Forms.Button btnthemlinhvuc;
        private System.Windows.Forms.Button btnxoalinhvuc;
    }
}