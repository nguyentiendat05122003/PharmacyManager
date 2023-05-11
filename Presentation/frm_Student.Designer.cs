namespace Presentation
{
    partial class frm_Student
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
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.ThemExcel = new System.Windows.Forms.Button();
            this.KetXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(92, 26);
            this.cboClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(180, 24);
            this.cboClass.TabIndex = 0;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // dgvStudent
            // 
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(37, 76);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.Size = new System.Drawing.Size(867, 316);
            this.dgvStudent.TabIndex = 2;
            // 
            // ThemExcel
            // 
            this.ThemExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemExcel.Location = new System.Drawing.Point(652, 30);
            this.ThemExcel.Name = "ThemExcel";
            this.ThemExcel.Size = new System.Drawing.Size(117, 39);
            this.ThemExcel.TabIndex = 3;
            this.ThemExcel.Text = "Thêm từ Excel";
            this.ThemExcel.UseVisualStyleBackColor = true;
            this.ThemExcel.Click += new System.EventHandler(this.ThemExcel_Click);
            // 
            // KetXuatExcel
            // 
            this.KetXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KetXuatExcel.Location = new System.Drawing.Point(787, 30);
            this.KetXuatExcel.Name = "KetXuatExcel";
            this.KetXuatExcel.Size = new System.Drawing.Size(117, 39);
            this.KetXuatExcel.TabIndex = 3;
            this.KetXuatExcel.Text = "Kết xuất Excel";
            this.KetXuatExcel.UseVisualStyleBackColor = true;
            this.KetXuatExcel.Click += new System.EventHandler(this.KetXuatExcel_Click);
            // 
            // frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 416);
            this.Controls.Add(this.KetXuatExcel);
            this.Controls.Add(this.ThemExcel);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClass);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Student";
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button ThemExcel;
        private System.Windows.Forms.Button KetXuatExcel;
    }
}