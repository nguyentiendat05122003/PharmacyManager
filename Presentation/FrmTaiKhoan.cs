using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
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
        public void LoadData()
        {
            dgnv.DataSource = tk.getAll();
        }

        private void ResetForm()
        {
            txtmatk.Text = "Mã tài khoản tự động tăng!";
            txttentk.Text = "";
            txtmk.Text = "";
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
            txttentk.Focus();
            if(Bien.loainv == 1)
            {
                dgnv.AutoGenerateColumns = false;
                dgnv.DataSource = tk.getAllJoin();
            }
            else
            {
                dgnv.AutoGenerateColumns = false;
                dgnv.DataSource = tk.Gettk(Bien.manhanvien);
            }
           cbbManv.DataSource = nv.getAll();
           SetDisplayCbb(cbbManv,"MaNhanVien", "HoTen");
           txtmatk.Text = "Mã tài khoản tự tăng";
            if(Bien.loainv == 2)
            {
                btnAdd.Hide();
                btnRemove.Hide();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txttentk.Text == "" || txtmk.Text == "" || cbbManv.ValueMember == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    Console.WriteLine((int)cbbManv.SelectedValue);
                    int val = tk.Insert(new TaiKhoan(txttentk.Text, txtmk.Text, (int)cbbManv.SelectedValue));
                    LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAdd.Text = "Thêm mới";
                        ResetForm();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int val = tk.Delete(int.Parse(txtmatk.Text));
                LoadData();
                if (val == -1)
                    MessageBox.Show("Xóa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TaiKhoan cl = new TaiKhoan();
            cl.Matk = int.Parse(txtmatk.Text);
            cl.Tentaikhoan = txttentk.Text;
            cl.Matkhau = txtmk.Text;
            cl.Manhanvien = (int)cbbManv.SelectedValue;
            try
            {
                int val = tk.Update(cl);
                LoadData();
                if (val == -1)
                    MessageBox.Show("Sửa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã sửa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
            }
            catch
            {
                MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtmatk.Text = dgnv[0, dgnv.CurrentCell.RowIndex].Value.ToString();
            txttentk.Text = dgnv[1, dgnv.CurrentCell.RowIndex].Value.ToString();
            txtmk.Text = dgnv[2, dgnv.CurrentCell.RowIndex].Value.ToString();          
            cbbManv.Text = dgnv[3, dgnv.CurrentCell.RowIndex].Value.ToString();
        }
    }
}
