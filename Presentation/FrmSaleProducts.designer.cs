namespace Presentation
{
    partial class FrmSaleProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPriceText = new System.Windows.Forms.Label();
            this.btnDestroy = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.dgvhoadon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncrease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDecrement = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvproduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsolg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 1100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbPrice);
            this.panel3.Controls.Add(this.lbPriceText);
            this.panel3.Controls.Add(this.btnDestroy);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.dgvhoadon);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1786, 1100);
            this.panel3.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(160, 925);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(27, 29);
            this.lbPrice.TabIndex = 13;
            this.lbPrice.Text = "0";
            // 
            // lbPriceText
            // 
            this.lbPriceText.AutoSize = true;
            this.lbPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceText.Location = new System.Drawing.Point(60, 925);
            this.lbPriceText.Name = "lbPriceText";
            this.lbPriceText.Size = new System.Drawing.Size(95, 29);
            this.lbPriceText.TabIndex = 12;
            this.lbPriceText.Text = "Tổng : ";
            // 
            // btnDestroy
            // 
            this.btnDestroy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDestroy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDestroy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDestroy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDestroy.FillColor = System.Drawing.Color.Red;
            this.btnDestroy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDestroy.ForeColor = System.Drawing.Color.White;
            this.btnDestroy.Location = new System.Drawing.Point(495, 1018);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(334, 69);
            this.btnDestroy.TabIndex = 11;
            this.btnDestroy.Text = "Hủy";
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnPay
            // 
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(52, 1018);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(334, 69);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvhoadon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvhoadon.ColumnHeadersHeight = 50;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmasp,
            this.clten,
            this.cldongia,
            this.clsoluong,
            this.btnIncrease,
            this.btnDecrement});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhoadon.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvhoadon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhoadon.Location = new System.Drawing.Point(0, 85);
            this.dgvhoadon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhoadon.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvhoadon.RowHeadersVisible = false;
            this.dgvhoadon.RowHeadersWidth = 62;
            this.dgvhoadon.Size = new System.Drawing.Size(886, 582);
            this.dgvhoadon.TabIndex = 8;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvhoadon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvhoadon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvhoadon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhoadon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvhoadon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvhoadon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhoadon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvhoadon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvhoadon.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvhoadon.ThemeStyle.ReadOnly = true;
            this.dgvhoadon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvhoadon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvhoadon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhoadon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvhoadon.ThemeStyle.RowsStyle.Height = 22;
            this.dgvhoadon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhoadon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvhoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellContentClick);
            // 
            // clmasp
            // 
            this.clmasp.HeaderText = "Mã thuốc";
            this.clmasp.MinimumWidth = 8;
            this.clmasp.Name = "clmasp";
            this.clmasp.ReadOnly = true;
            // 
            // clten
            // 
            this.clten.FillWeight = 89.48863F;
            this.clten.HeaderText = "Tên thuốc";
            this.clten.MinimumWidth = 8;
            this.clten.Name = "clten";
            this.clten.ReadOnly = true;
            // 
            // cldongia
            // 
            this.cldongia.FillWeight = 89.48863F;
            this.cldongia.HeaderText = "Đơn giá";
            this.cldongia.MinimumWidth = 8;
            this.cldongia.Name = "cldongia";
            this.cldongia.ReadOnly = true;
            // 
            // clsoluong
            // 
            this.clsoluong.FillWeight = 89.48863F;
            this.clsoluong.HeaderText = "Số lượng";
            this.clsoluong.MinimumWidth = 8;
            this.clsoluong.Name = "clsoluong";
            this.clsoluong.ReadOnly = true;
            // 
            // btnIncrease
            // 
            this.btnIncrease.FillWeight = 50F;
            this.btnIncrease.HeaderText = "";
            this.btnIncrease.MinimumWidth = 8;
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.ReadOnly = true;
            this.btnIncrease.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnIncrease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDecrement
            // 
            this.btnDecrement.FillWeight = 50F;
            this.btnDecrement.HeaderText = "";
            this.btnDecrement.MinimumWidth = 8;
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.ReadOnly = true;
            this.btnDecrement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDecrement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1786, 77);
            this.panel5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(300, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(898, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 1100);
            this.panel2.TabIndex = 1;
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
            this.btnReload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReload.Location = new System.Drawing.Point(753, 85);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 86);
            this.btnReload.TabIndex = 48;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dgvproduct);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(39, 182);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(826, 1069);
            this.guna2GroupBox1.TabIndex = 40;
            this.guna2GroupBox1.Text = "Thông tin sản phẩm";
            // 
            // dgvproduct
            // 
            this.dgvproduct.AllowUserToAddRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.dgvproduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvproduct.ColumnHeadersHeight = 50;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmathuoc,
            this.colName,
            this.colPrice,
            this.clsolg});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproduct.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvproduct.Location = new System.Drawing.Point(0, 40);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvproduct.RowHeadersVisible = false;
            this.dgvproduct.RowHeadersWidth = 62;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.dgvproduct.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvproduct.RowTemplate.Height = 35;
            this.dgvproduct.Size = new System.Drawing.Size(826, 1029);
            this.dgvproduct.TabIndex = 0;
            this.dgvproduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvproduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvproduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvproduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvproduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvproduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvproduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvproduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvproduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvproduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvproduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvproduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvproduct.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvproduct.ThemeStyle.ReadOnly = true;
            this.dgvproduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvproduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvproduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvproduct.ThemeStyle.RowsStyle.Height = 35;
            this.dgvproduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvproduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduct_CellClick);
            // 
            // clmathuoc
            // 
            this.clmathuoc.DataPropertyName = "MaThuoc";
            this.clmathuoc.HeaderText = "Mã thuốc";
            this.clmathuoc.MinimumWidth = 8;
            this.clmathuoc.Name = "clmathuoc";
            this.clmathuoc.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "TenThuoc";
            this.colName.HeaderText = "Tên thuốc";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "GiaBan";
            this.colPrice.HeaderText = "Giá bán";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // clsolg
            // 
            this.clsolg.DataPropertyName = "Soluong";
            this.clsolg.HeaderText = "Số lượng";
            this.clsolg.MinimumWidth = 8;
            this.clsolg.Name = "clsolg";
            this.clsolg.ReadOnly = true;
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
            this.btnSearch.Location = new System.Drawing.Point(484, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(260, 57);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_click);
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
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(39, 106);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập tên thuốc ....";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(438, 65);
            this.txtSearch.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(882, 77);
            this.panel7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(320, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "BỘ LỌC";
            // 
            // FrmSaleProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1780, 1100);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSaleProducts";
            this.Text = "FrmSaleProducts";
            this.Load += new System.EventHandler(this.FrmSaleProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnDestroy;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvproduct;
        private Guna.UI2.WinForms.Guna2DataGridView dgvhoadon;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPriceText;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoluong;
        private System.Windows.Forms.DataGridViewButtonColumn btnIncrease;
        private System.Windows.Forms.DataGridViewButtonColumn btnDecrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsolg;
    }
}