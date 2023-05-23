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
    public partial class FrmProvider : Form
    {
        IProviderBUL provider = new ProviderBUL();
        public FrmProvider()
        {
            InitializeComponent();
        }

        private void FrmProvider_Load(object sender, EventArgs e)
        {
            dgvProvider.DataSource = provider.getAll();         
            LoadData();
            ResetForm();
        }
        private void ResetForm()
        {
            txtmancc.Text = "Mã lớp tự động tăng!";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txttenncc.Text = "";
            txtemail.Text = "";
        }

        public void LoadData()
        {
            dgvProvider.DataSource = provider.getAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txttenncc.Text == "" || txtdiachi.Text == "" || txtdienthoai.Text=="" || txtemail.Text=="")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = provider.Insert(new Provider(txttenncc.Text, txtdiachi.Text, txtdienthoai.Text,txtemail.Text,radioYes.Checked));
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
            Provider cl = new Provider();
            cl.Mancc = int.Parse(txtmancc.Text);
            cl.Tenncc = txttenncc.Text;
            cl.Diachi = txtdiachi.Text;
            cl.Dienthoai = txtdienthoai.Text;
            cl.Email = txtemail.Text;
            cl.Ngunghoptac = radioYes.Checked;  
            try
            {
                int val = provider.Update(cl);
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
                int val = provider.Delete(int.Parse(txtmancc.Text));
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmancc.Text = dgvProvider[0, dgvProvider.CurrentCell.RowIndex].Value.ToString();
            txttenncc.Text = dgvProvider[1, dgvProvider.CurrentCell.RowIndex].Value.ToString();
            txtdiachi.Text = dgvProvider[2, dgvProvider.CurrentCell.RowIndex].Value.ToString();
            txtdienthoai.Text = dgvProvider[3, dgvProvider.CurrentCell.RowIndex].Value.ToString();
            txtemail.Text = dgvProvider[4, dgvProvider.CurrentCell.RowIndex].Value.ToString();

            string state = dgvProvider[5, dgvProvider.CurrentCell.RowIndex].Value.ToString();
            if (state == "True")
            {
                radioYes.Checked = true;
            }
            else if (state == "False")
            {
                radioNo.Checked = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
