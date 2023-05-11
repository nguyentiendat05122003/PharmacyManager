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
    public partial class frm_Student : Form
    {
        IClassBUL cls = new ClassBUL();
        IStudentBUL std = new StudentBUL();
        public frm_Student()
        {
            InitializeComponent();
        }
        public void Load_Class()
        {
            IList<Class> list = cls.getAll();
            cboClass.ValueMember = "classID";
            cboClass.DisplayMember = "className";
            cboClass.DataSource = list;
        }
        public void Load_Student(int classID)
        {
            dgvStudent.DataSource = std.getAll(classID);
        }
        private void frm_Student_Load(object sender, EventArgs e)
        {
            Load_Class();
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Student(int.Parse(cboClass.SelectedValue.ToString()));
        }

        private void ThemExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.DefaultExt = "*.xlsx";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    std.ThemTuExcel(saveFileDialog.FileName);
                    Load_Student(int.Parse(cboClass.SelectedValue.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
            }
        }

        private void KetXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Excel | *.xlsx";
            saveFileDialog.Title = "Lưu danh sách sinh viên";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    std.KetXuatExcel(int.Parse(cboClass.SelectedValue.ToString()), @"Template\SinhVien_Template.xlsx", saveFileDialog.FileName);
                    MessageBox.Show("Kết xuất thành công!");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
               
            }
        }
    }
}
