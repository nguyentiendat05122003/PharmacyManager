using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmTaiKhoan : Form
    {
        INhanVienBUL nv = new NhanVienBUL();
        ITaiKhoanBUL tk = new TaiKhoanBUL();
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetDisplayCbb(System.Windows.Forms.ComboBox cbb, string value, string name)
        {
            cbb.ValueMember = value;
            cbb.DisplayMember = name;
            cbb.Enabled = true;
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
           cbbManv.DataSource = nv.getAll();
           SetDisplayCbb(cbbManv,"MaNhanVien", "HoTen");
           txtmatk.Text = "Mã tài khoản tự tăng";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string password = txtmk.Text;
            string hashedPassword = tk.Encrypt(password);
            if (txttentk.Text == "" || txtmk.Text == "" || cbbManv.ValueMember == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = tk.Insert(new TaiKhoan(txttentk.Text, hashedPassword, (int)cbbManv.SelectedValue));
                    //LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAdd.Text = "Thêm mới";
                        //ResetForm();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
