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
    public partial class FrmCustomer : Form
    {
        IKhachHangBUL kh = new KhachHangBUL();
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void LoadData()
        {
            dgvkhachhang.DataSource = kh.getAll();
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }
        private void ResetForm()
        {
            txtmakh.Text = "Mã khách hàng tự động tăng!";
            txthoten.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == ""|| txtsdt.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = kh.Insert(new KhachHang(txthoten.Text, txtdiachi.Text, txtsdt.Text,txtemail.Text));
                    LoadData();
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAdd.Text = "Thêm mới";
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            KhachHang cl = new KhachHang();
            cl.Makhachhang = int.Parse(txtmakh.Text);
            cl.Hoten = txthoten.Text;
            cl.Diachi = txtdiachi.Text;
            cl.Dienthoai = txtsdt.Text;
            cl.Email = txtemail.Text;
            try
            {
                int val = kh.Update(cl);
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int val = kh.Delete(int.Parse(txtmakh.Text));
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

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {      
            txtmakh.Text = dgvkhachhang[0, dgvkhachhang.CurrentCell.RowIndex].Value.ToString();
            txthoten.Text = dgvkhachhang[1, dgvkhachhang.CurrentCell.RowIndex].Value.ToString();
            txtdiachi.Text = dgvkhachhang[2, dgvkhachhang.CurrentCell.RowIndex].Value.ToString();
            txtdiachi.Text = dgvkhachhang[3, dgvkhachhang.CurrentCell.RowIndex].Value.ToString();
            txtemail.Text = dgvkhachhang[4, dgvkhachhang.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvkhachhang.DataSource = kh.SearchLinq(txtSearch.Text);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
