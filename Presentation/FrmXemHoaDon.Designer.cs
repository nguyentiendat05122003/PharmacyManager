namespace Presentation
{
    partial class FrmXemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXemHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvhoadon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mahoado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clslg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1676, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 65);
            this.btnExit.TabIndex = 63;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(1038, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(260, 65);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(418, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập ngày bán ...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(590, 66);
            this.txtSearch.TabIndex = 64;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1988, 878);
            this.panel1.TabIndex = 66;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dgvhoadon);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1988, 878);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Thông tin hóa đơn";
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvhoadon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvhoadon.ColumnHeadersHeight = 50;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoado,
            this.cltenkh,
            this.cltenv,
            this.cltongtien,
            this.cltenthuoc,
            this.clslg,
            this.clngayban});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhoadon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvhoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhoadon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhoadon.Location = new System.Drawing.Point(0, 40);
            this.dgvhoadon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.RowHeadersVisible = false;
            this.dgvhoadon.RowHeadersWidth = 62;
            this.dgvhoadon.RowTemplate.Height = 35;
            this.dgvhoadon.Size = new System.Drawing.Size(1988, 838);
            this.dgvhoadon.TabIndex = 0;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvhoadon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvhoadon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhoadon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvhoadon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvhoadon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhoadon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvhoadon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvhoadon.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvhoadon.ThemeStyle.ReadOnly = false;
            this.dgvhoadon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvhoadon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvhoadon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhoadon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvhoadon.ThemeStyle.RowsStyle.Height = 35;
            this.dgvhoadon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhoadon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // mahoado
            // 
            this.mahoado.DataPropertyName = "MaHoaDon";
            this.mahoado.HeaderText = "Mã hóa đơn";
            this.mahoado.MinimumWidth = 8;
            this.mahoado.Name = "mahoado";
            // 
            // cltenkh
            // 
            this.cltenkh.DataPropertyName = "Tenkh";
            this.cltenkh.HeaderText = "Tên khách hàng";
            this.cltenkh.MinimumWidth = 8;
            this.cltenkh.Name = "cltenkh";
            // 
            // cltenv
            // 
            this.cltenv.DataPropertyName = "Tenv";
            this.cltenv.HeaderText = "Nhân viên";
            this.cltenv.MinimumWidth = 8;
            this.cltenv.Name = "cltenv";
            // 
            // cltongtien
            // 
            this.cltongtien.DataPropertyName = "TongTien";
            this.cltongtien.HeaderText = "Tổng tiền";
            this.cltongtien.MinimumWidth = 8;
            this.cltongtien.Name = "cltongtien";
            // 
            // cltenthuoc
            // 
            this.cltenthuoc.DataPropertyName = "Tenthuoc";
            this.cltenthuoc.HeaderText = "Tên thuốc";
            this.cltenthuoc.MinimumWidth = 8;
            this.cltenthuoc.Name = "cltenthuoc";
            // 
            // clslg
            // 
            this.clslg.DataPropertyName = "Soluong";
            this.clslg.HeaderText = "Số lượng";
            this.clslg.MinimumWidth = 8;
            this.clslg.Name = "clslg";
            // 
            // clngayban
            // 
            this.clngayban.DataPropertyName = "NgayBan";
            this.clngayban.HeaderText = "Ngày bán";
            this.clngayban.MinimumWidth = 8;
            this.clngayban.Name = "clngayban";
            // 
            // btnReload
            // 
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnReload.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnReload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReload.Location = new System.Drawing.Point(1335, 51);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(228, 66);
            this.btnReload.TabIndex = 67;
            this.btnReload.Text = "Tải lại";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FrmXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1988, 1050);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmXemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXemHoaDon";
            this.Load += new System.EventHandler(this.FrmXemHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clslg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngayban;
        private Guna.UI2.WinForms.Guna2Button btnReload;
    }
}