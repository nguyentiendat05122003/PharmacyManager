using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class FrmLogin : Form
    {
        ITaiKhoanBUL tk = new TaiKhoanBUL();
        public FrmLogin()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
                txtPassword.UseSystemPasswordChar = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Trim() != "" && txtUserName.Text.Trim() != "")
            {
                // Kiểm tra mật khẩu
                bool isAccountExist = tk.checkTaiKhoan_IsExist(txtUserName.Text, txtPassword.Text);
                if (isAccountExist)
                {
                    int manvLogin = tk.TaiKhoanLogin(txtUserName.Text, txtPassword.Text).Manhanvien;
                    Bien.manhanvien = manvLogin;
                    NhanVien nvLogin = tk.GetNhanVien(manvLogin);
                    Bien.username = nvLogin.Hoten;
                    if(nvLogin.VaiTro == 1)
                    {
                        Bien.chucvu = "Quản lý";
                        FrmMain frm = new FrmMain();
                        Bien.loainv = 1;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        Bien.loainv = 1;
                        Bien.chucvu = "Nhân viên";
                        FrmMain frm = new FrmMain();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản của bạn không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản");
            }
        }

        private void pcbEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                pcbEye.Image = Properties.Resources.eye_slash_icon;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                pcbEye.Image = Properties.Resources._211739_eye_icon;
            }
        }
    }
}
