using BusinessLogicLayer.Interface;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentation
{
    public partial class FrmEmployee : Form
    {
        INhanVienBUL NV = new NhanVienBUL();
        ILoaiNhanVienBUL loainv = new LoaiNhanVienBUL();
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public void LoadData()
        {
            dgvnhanvien.DataSource = NV.getAllJoin(loainv);
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            dgvnhanvien.AutoGenerateColumns = false;
            LoadData();
            txtmanv.Text = "Mã nhân viên tự động tăng!";
            cbbvaitro.DataSource = loainv.getAll();
            SetDisplayCbb(cbbvaitro, "MaLoai", "TenLoai");
        }
        private void SetDisplayCbb(System.Windows.Forms.ComboBox cbb, string value, string name)
        {
            cbb.ValueMember = value;
            cbb.DisplayMember = name;
            cbb.Enabled = true;
        }
        private void ResetForm()
        {
            txtmanv.Text = "Mã nhân viên tự động tăng!";
            txthoten.Text = "";         
            txtemail.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtngaysinh.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == "" || txtemail.Text == "" || txtdiachi.Text == "" || txtdienthoai.Text == "" || txtngaysinh.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try {

                    int val = NV.Insert(new NhanVien(((int)cbbvaitro.SelectedValue), txthoten.Text, radioMale.Checked, DateTime.Parse(txtngaysinh.Text), txtdiachi.Text, txtdienthoai.Text, txtemail.Text));
                    LoadData(); 
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAdd.Text = "Thêm mới";
                    }
                    ResetForm();
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NhanVien pro = new NhanVien();
            pro.MaNhanVien = int.Parse(txtmanv.Text);
            pro.VaiTro = (int)cbbvaitro.SelectedValue;
            pro.Hoten = txthoten.Text;
            pro.Gioitinh = radioMale.Checked;
            pro.Ngaysinh = DateTime.Parse(txtngaysinh.Text);
            pro.Diachi = txtdiachi.Text;
            pro.Email = txtemail.Text;
            pro.Dienthoai = txtdienthoai.Text;         
            try
            {
                int val = NV.Update(pro);
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
        
        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dgvnhanvien[0, dgvnhanvien.CurrentCell.RowIndex].Value.ToString();
            cbbvaitro.Text = dgvnhanvien[1, dgvnhanvien.CurrentCell.RowIndex].Value.ToString();
            txthoten.Text = dgvnhanvien[2, dgvnhanvien.CurrentCell.RowIndex].Value.ToString();
            txtngaysinh.Text = Utility.Tools.CatXauDate(dgvnhanvien[3, dgvnhanvien.CurrentCell.RowIndex].Value.ToString());
            string gender = dgvnhanvien[4, dgvnhanvien.CurrentCell.RowIndex].Value.ToString();
                if (gender == "True")
                {
                    radioMale.Checked = true;
                }
                else if (gender == "False")
                {
                    radioFeMale.Checked = true;
                }
            txtdiachi.Text = dgvnhanvien[5, dgvnhanvien.CurrentCell.RowIndex].Value.ToString();
            txtdienthoai.Text = dgvnhanvien[6, dgvnhanvien.CurrentCell.RowIndex].Value.ToString();
            txtemail.Text = dgvnhanvien[7, dgvnhanvien.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int val = NV.Delete(int.Parse(txtmanv.Text));
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

        private void dgvnhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvnhanvien.Columns[e.ColumnIndex].Name == "clGioitinh")
            {
                bool gioiTinh = (bool)e.Value;
                if (gioiTinh == false)
                {
                    e.Value = "Nữ";
                }
                else if (gioiTinh == true)
                {
                    e.Value = "Nam";
                }
                e.FormattingApplied = true;

            }
        }
    }
}
