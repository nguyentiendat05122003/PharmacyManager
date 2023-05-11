using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using Entities;

namespace Presentation
{
    public partial class frm_Class : Form
    {
        IClassBUL cls = new ClassBUL();
        public frm_Class()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvClass.DataSource = cls.getAll();
            txtClassName.Focus();
        }
        private void frm_Class_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }
        private void ResetForm()
        {
            txtClassID.Text = "Mã lớp tự động tăng!";
            txtClassName.Text = "";
            txtMonitorName.Text = "";
            txtTeacherName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text == "" || txtMonitorName.Text == "" || txtTeacherName.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = cls.Insert(new Class(txtClassName.Text, txtMonitorName.Text, txtTeacherName.Text));
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Class cl = new Class();
            cl.ClassName = txtClassName.Text;
            cl.MonitorName = txtMonitorName.Text;
            cl.TeacherName = txtTeacherName.Text;
            //dgvClass.DataSource = cls.Search(cl);
            dgvClass.DataSource = cls.SearchLinq(cl);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Class cl = new Class();
            cl.ClassID = int.Parse(txtClassID.Text);
            cl.ClassName = txtClassName.Text;
            cl.MonitorName = txtMonitorName.Text;
            cl.TeacherName = txtTeacherName.Text;
            try
            {
                int val = cls.Update(cl);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = cls.Delete(int.Parse(txtClassID.Text));
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

        private void dgvClass_Click(object sender, EventArgs e)
        {
            txtClassID.Text = dgvClass[0, dgvClass.CurrentCell.RowIndex].Value.ToString();
            txtClassName.Text = dgvClass[1, dgvClass.CurrentCell.RowIndex].Value.ToString();
            txtMonitorName.Text = dgvClass[2, dgvClass.CurrentCell.RowIndex].Value.ToString();
            txtTeacherName.Text = dgvClass[3, dgvClass.CurrentCell.RowIndex].Value.ToString();
        }

        private void LamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void KetXuatWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin lớp";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    cls.KetXuatWord(int.Parse(txtClassID.Text), @"Template\Lop_Template.docx", saveFileDialog.FileName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }

            }
            
        }
    }
}
