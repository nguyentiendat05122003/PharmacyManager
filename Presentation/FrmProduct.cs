using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Presentation
{
    //foreach (object item in product_provider)
    //{
    //    string maSP = (string)item.GetType().GetProperty("Tenncc").GetValue(item, null);
    //}
    public partial class FrmProduct : Form
    {
        IProductBUL product = new ProductBUL();
        IProviderBUL provider = new ProviderBUL(); 
        IDonViTinhBUL donViTinh = new DonViTinhBUL();
        public FrmProduct()
        {
            InitializeComponent();
        }     
        public void LoadData()
        {
            var product_provider = product.getAllJoin();
            dgvProduct.DataSource = product_provider;
            cbbNcc.DataSource = provider.getAll();
            cbbDonvitinh.DataSource = donViTinh.getAll();
        }
        private void ResetForm()
        {
            txtmathuoc.Text = "Mã thuốc tự động tăng!";
            txttenthuoc.Text = "";
            txtgiaban.Text = "";
            txthansudung.Text = "";
            txtSearch.Text = "";
            cbbDonvitinh.DataSource = donViTinh.getAll();
            cbbNcc.DataSource = provider.getAll();
        }
        private void SetDisplayCbb(System.Windows.Forms.ComboBox cbb,string value,string name)
        {
            cbb.ValueMember = value;
            cbb.DisplayMember = name;
            cbb.Enabled = true;
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var product_provider = product.getAllJoin();
            txtmathuoc.Text = "Mã thuốc tự động tăng!";        
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = product_provider;
            cbbNcc.DataSource = provider.getAll();            
            SetDisplayCbb(cbbNcc, "MaNCC", "TenNCC");
            cbbDonvitinh.DataSource = donViTinh.getAll();
            SetDisplayCbb(cbbDonvitinh, "MaDonViTinh", "TenDonViTinh");         
        }                        
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txttenthuoc.Text == "" || txtgiaban.Text == "" || cbbDonvitinh.ValueMember == "" || cbbNcc.ValueMember == "")
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int val = product.Insert(new Product(txttenthuoc.Text, float.Parse(txtgiaban.Text),DateTime.Parse(txthansudung.Text), ((int)cbbNcc.SelectedValue),(int)cbbDonvitinh.SelectedValue));
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

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Mathuoc = int.Parse(txtmathuoc.Text);
            pro.Tenthuoc = txttenthuoc.Text;
            pro.Giaban = int.Parse(txtgiaban.Text);
            pro.Hansudung = DateTime.Parse(txthansudung.Text);
            pro.Mancc = (int)cbbNcc.SelectedValue;
            pro.Madonvitinh = (int)cbbDonvitinh.SelectedValue;
            try
            {
                int val = product.Update(pro);
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int val = product.Delete(int.Parse(txtmathuoc.Text));
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

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }
        private void dgvProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmathuoc.Text = dgvProduct[0, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txttenthuoc.Text = dgvProduct[1, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txtgiaban.Text = dgvProduct[2, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txthansudung.Text = Utility.Tools.CatXauDate(dgvProduct[3, dgvProduct.CurrentCell.RowIndex].Value.ToString());
            cbbNcc.Text =  dgvProduct[4, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            cbbDonvitinh.Text = dgvProduct[5, dgvProduct.CurrentCell.RowIndex].Value.ToString();
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.DefaultExt = "*.xlsx";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    product.ThemTuExcel(saveFileDialog.FileName);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
            }
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = product.SearchLinq(txtSearch.Text);
        }

        private void btnexportWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin lớp";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    product.KetXuatWord(@"Template\SanPham.docx", saveFileDialog.FileName);
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
