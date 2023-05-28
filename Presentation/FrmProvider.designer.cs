namespace Presentation
{
    partial class FrmProvider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProvider));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvProvider = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhoptac = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtdienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttenncc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmancc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dgvProvider);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 432);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1940, 668);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // dgvProvider
            // 
            this.dgvProvider.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProvider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProvider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProvider.ColumnHeadersHeight = 50;
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProvider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colncc,
            this.colTenncc,
            this.colDiaChi,
            this.colDienThoai,
            this.Colemail,
            this.clhoptac});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProvider.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProvider.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProvider.Location = new System.Drawing.Point(0, 40);
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.ReadOnly = true;
            this.dgvProvider.RowHeadersVisible = false;
            this.dgvProvider.RowHeadersWidth = 62;
            this.dgvProvider.RowTemplate.Height = 35;
            this.dgvProvider.Size = new System.Drawing.Size(1940, 603);
            this.dgvProvider.TabIndex = 0;
            this.dgvProvider.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProvider.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProvider.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProvider.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProvider.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProvider.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProvider.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProvider.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProvider.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProvider.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProvider.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProvider.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProvider.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvProvider.ThemeStyle.ReadOnly = true;
            this.dgvProvider.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProvider.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProvider.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProvider.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvProvider.ThemeStyle.RowsStyle.Height = 35;
            this.dgvProvider.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProvider.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProvider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvider_CellClick);
            this.dgvProvider.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvProvider_RowPrePaint);
            // 
            // colncc
            // 
            this.colncc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colncc.DataPropertyName = "MaNCC";
            this.colncc.FillWeight = 80F;
            this.colncc.HeaderText = "Mã nhà cung cấp";
            this.colncc.MinimumWidth = 8;
            this.colncc.Name = "colncc";
            this.colncc.ReadOnly = true;
            this.colncc.Width = 200;
            // 
            // colTenncc
            // 
            this.colTenncc.DataPropertyName = "TenNCC";
            this.colTenncc.FillWeight = 55.9691F;
            this.colTenncc.HeaderText = "Tên nhà cung cấp";
            this.colTenncc.MinimumWidth = 8;
            this.colTenncc.Name = "colTenncc";
            this.colTenncc.ReadOnly = true;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.FillWeight = 55.9691F;
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 8;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.FillWeight = 55.9691F;
            this.colDienThoai.HeaderText = "Điện thoại";
            this.colDienThoai.MinimumWidth = 8;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.ReadOnly = true;
            // 
            // Colemail
            // 
            this.Colemail.DataPropertyName = "Email";
            this.Colemail.FillWeight = 55.9691F;
            this.Colemail.HeaderText = "Email";
            this.Colemail.MinimumWidth = 8;
            this.Colemail.Name = "Colemail";
            this.Colemail.ReadOnly = true;
            // 
            // clhoptac
            // 
            this.clhoptac.DataPropertyName = "NgungHopTac";
            this.clhoptac.HeaderText = "Trạng thái";
            this.clhoptac.MinimumWidth = 8;
            this.clhoptac.Name = "clhoptac";
            this.clhoptac.ReadOnly = true;
            this.clhoptac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clhoptac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.btnSearch.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btnSearch.Location = new System.Drawing.Point(1216, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(214, 69);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(552, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 28);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tìm kiếm : ";
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
            this.txtSearch.Location = new System.Drawing.Point(711, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập thông tin nhà cung cấp ...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(468, 55);
            this.txtSearch.TabIndex = 51;
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
            this.btnReload.ImageOffset = new System.Drawing.Point(-6, 0);
            this.btnReload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReload.Location = new System.Drawing.Point(1527, 322);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(216, 78);
            this.btnReload.TabIndex = 55;
            this.btnReload.Text = "Tải lại";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnEdit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageOffset = new System.Drawing.Point(-6, 0);
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(1240, 322);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(216, 78);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageOffset = new System.Drawing.Point(-6, 0);
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(958, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(216, 78);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdienthoai.DefaultText = "";
            this.txtdienthoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdienthoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdienthoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdienthoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdienthoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdienthoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdienthoai.Location = new System.Drawing.Point(1119, 186);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(6);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.PasswordChar = '\0';
            this.txtdienthoai.PlaceholderText = "";
            this.txtdienthoai.SelectedText = "";
            this.txtdienthoai.Size = new System.Drawing.Size(381, 42);
            this.txtdienthoai.TabIndex = 47;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.DefaultText = "";
            this.txtdiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachi.Location = new System.Drawing.Point(1119, 106);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(6);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.PasswordChar = '\0';
            this.txtdiachi.PlaceholderText = "";
            this.txtdiachi.SelectedText = "";
            this.txtdiachi.Size = new System.Drawing.Size(381, 42);
            this.txtdiachi.TabIndex = 46;
            // 
            // txttenncc
            // 
            this.txttenncc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenncc.DefaultText = "";
            this.txttenncc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenncc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenncc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenncc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenncc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenncc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenncc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenncc.Location = new System.Drawing.Point(321, 186);
            this.txttenncc.Margin = new System.Windows.Forms.Padding(6);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.PasswordChar = '\0';
            this.txttenncc.PlaceholderText = "";
            this.txttenncc.SelectedText = "";
            this.txttenncc.Size = new System.Drawing.Size(388, 42);
            this.txttenncc.TabIndex = 41;
            // 
            // txtmancc
            // 
            this.txtmancc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmancc.DefaultText = "";
            this.txtmancc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmancc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmancc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmancc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmancc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmancc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmancc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmancc.Location = new System.Drawing.Point(321, 106);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(6);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.PasswordChar = '\0';
            this.txtmancc.PlaceholderText = "";
            this.txtmancc.SelectedText = "";
            this.txtmancc.Size = new System.Drawing.Size(388, 42);
            this.txtmancc.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(912, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 48;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tên nhà cung cấp : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(912, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã nhà cung cấp : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 58;
            this.label2.Text = "Email : ";
            // 
            // txtemail
            // 
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(321, 255);
            this.txtemail.Margin = new System.Windows.Forms.Padding(6);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(388, 42);
            this.txtemail.TabIndex = 59;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1658, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 65);
            this.btnExit.TabIndex = 60;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYes.Location = new System.Drawing.Point(1119, 248);
            this.radioYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(120, 33);
            this.radioYes.TabIndex = 93;
            this.radioYes.Text = "Hợp tác";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNo.Location = new System.Drawing.Point(1329, 248);
            this.radioNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(194, 33);
            this.radioNo.TabIndex = 92;
            this.radioNo.Text = "Ngừng hợp tác";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(912, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 28);
            this.label13.TabIndex = 91;
            this.label13.Text = "Trạng thái : ";
            // 
            // FrmProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.radioYes);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProvider";
            this.Text = "FrmProvider";
            this.Load += new System.EventHandler(this.FrmProvider_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProvider;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtdienthoai;
        private Guna.UI2.WinForms.Guna2TextBox txtdiachi;
        private Guna.UI2.WinForms.Guna2TextBox txttenncc;
        private Guna.UI2.WinForms.Guna2TextBox txtmancc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn colncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colemail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clhoptac;
    }
}