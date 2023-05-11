namespace Presentation
{
    partial class frm_Class
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtMonitorName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.LamMoi = new System.Windows.Forms.Button();
            this.KetXuatWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật thông tin lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp trưởng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giáo viên chủ nhiệm";
            // 
            // txtClassID
            // 
            this.txtClassID.Enabled = false;
            this.txtClassID.Location = new System.Drawing.Point(199, 81);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(132, 22);
            this.txtClassID.TabIndex = 5;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(199, 116);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(247, 22);
            this.txtClassName.TabIndex = 5;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(199, 185);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(247, 22);
            this.txtTeacherName.TabIndex = 5;
            // 
            // txtMonitorName
            // 
            this.txtMonitorName.Location = new System.Drawing.Point(199, 153);
            this.txtMonitorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonitorName.Name = "txtMonitorName";
            this.txtMonitorName.Size = new System.Drawing.Size(315, 22);
            this.txtMonitorName.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 232);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Lưu lại";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(293, 232);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(395, 232);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 38);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(601, 232);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tim kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(61, 294);
            this.dgvClass.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(753, 208);
            this.dgvClass.TabIndex = 7;
            this.dgvClass.Click += new System.EventHandler(this.dgvClass_Click);
            // 
            // LamMoi
            // 
            this.LamMoi.Location = new System.Drawing.Point(498, 232);
            this.LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.LamMoi.Name = "LamMoi";
            this.LamMoi.Size = new System.Drawing.Size(95, 38);
            this.LamMoi.TabIndex = 6;
            this.LamMoi.Text = "Làm mới";
            this.LamMoi.UseVisualStyleBackColor = true;
            this.LamMoi.Click += new System.EventHandler(this.LamMoi_Click);
            // 
            // KetXuatWord
            // 
            this.KetXuatWord.Location = new System.Drawing.Point(703, 232);
            this.KetXuatWord.Name = "KetXuatWord";
            this.KetXuatWord.Size = new System.Drawing.Size(111, 38);
            this.KetXuatWord.TabIndex = 8;
            this.KetXuatWord.Text = "Kết xuất Word";
            this.KetXuatWord.UseVisualStyleBackColor = true;
            this.KetXuatWord.Click += new System.EventHandler(this.KetXuatWord_Click);
            // 
            // frm_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.KetXuatWord);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.LamMoi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMonitorName);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Class";
            this.Text = "Class";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtMonitorName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Button LamMoi;
        private System.Windows.Forms.Button KetXuatWord;
    }
}