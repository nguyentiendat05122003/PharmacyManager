using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Presentation
{
    public partial class FrmImportProducts : Form
    {
        IProductBUL product = new ProductBUL();
        IProviderBUL provider = new ProviderBUL();
        IPhieuNhapBUL phieunhap = new PhieuNhapBUL();
        IChiTietPhieuNhapBUL chitietpn = new ChiTietPhieuNhapBUL();
        IProviderBUL ncc = new ProviderBUL();   
        public FrmImportProducts()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            txtmathuoc.Text = "";
            txtmancc.Text = "";
            txtsoluong.Text = "";
            txttenncc.Text = "";
            txtdongia.Text = "";
            txttenthuoc.Text = "";
            btnOK.Enabled = false;
            btnDestroy.Enabled = false;
        }
        private void FrmImportProducts_Load(object sender, EventArgs e)
        {
            dgvsanpham.AutoGenerateColumns = false;
            dgvncc.AutoGenerateColumns = false;
            dgvncc.DataSource = provider.GetProviderIsContact();
            dgvsanpham.DataSource = product.getAllFilter();
            lbtongtien.Text = "0 VND";
            btnOK.Enabled = false;
            btnDestroy.Enabled = false;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvsanpham.DataSource =  product.SearchLinq(txtSearch.Text);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvsanpham.DataSource = product.SearchLinq(txtSearch.Text);
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(txtmancc.Text =="" && txttenncc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin nhà cung cấp trước");
            }
            else
            {
            txtmathuoc.Text = dgvsanpham[0, dgvsanpham.CurrentCell.RowIndex].Value.ToString();
            txttenthuoc.Text = dgvsanpham[2, dgvsanpham.CurrentCell.RowIndex].Value.ToString();
            }
        }
        private void tinhTien()
        {
            float sum = 0;

            foreach (DataGridViewRow row in dgvphieunhap.Rows)
            {
                if (row.Cells["cltongtien"].Value != null)
                {
                    string value = row.Cells["cltongtien"].Value.ToString();
                    float number;
                    if (float.TryParse(value, out number))
                    {
                        sum += number;
                    }
                }
            }
            lbtongtien.Text = sum.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            dgvphieunhap.Rows.Add(row);
            int rowIndex = dgvphieunhap.Rows.Count - 1;
            dgvphieunhap.Rows[rowIndex].Cells[0].Value = txtmathuoc.Text;
            dgvphieunhap.Rows[rowIndex].Cells[1].Value = txttenthuoc.Text;
            dgvphieunhap.Rows[rowIndex].Cells[2].Value = txtmancc.Text;
            dgvphieunhap.Rows[rowIndex].Cells[3].Value = txtdongia.Text;
            dgvphieunhap.Rows[rowIndex].Cells[4].Value = txtsoluong.Text;
            float tongtien = float.Parse(txtsoluong.Text) * float.Parse(txtdongia.Text);
            dgvphieunhap.Rows[rowIndex].Cells[5].Value = tongtien.ToString();
            tinhTien();
            ResetForm();
            btnOK.Enabled = true;
            btnDestroy.Enabled = true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            string mancc = "";
            object value = dgvphieunhap.Rows[0].Cells["clncc"].Value;
            mancc = value.ToString();
            string nameNcc = provider.GetProviderName(int.Parse(mancc));
            if (dgvphieunhap.Rows.Count > 0)
            {
                try
                {
                    int val = phieunhap.Insert(new PhieuNhap(int.Parse(mancc), today, float.Parse(lbtongtien.Text), Bien.manhanvien));
                    foreach (DataGridViewRow row in dgvphieunhap.Rows)
                    {
                        PhieuNhap lastPN = phieunhap.GetLastPN();
                        int mathuoc =int.Parse(row.Cells["clmathuoc"].Value.ToString());
                        MessageBox.Show(lastPN.Maphieunhap.ToString());
                        int chitietpnVal = chitietpn.Insert(new ChiTietPhieuNhap(lastPN.Maphieunhap,mathuoc,int.Parse(row.Cells["clsoluong"].Value.ToString()), float.Parse(row.Cells["cldongia"].Value.ToString())));
                        if (chitietpnVal == -1)
                            MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvphieunhap.Rows.Clear();
                        ResetForm();
                    }
                    lbtongtien.Text = "0 VND";
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            XuatWord(phieunhap.GetLastPN(),Bien.username,today, nameNcc);
        }

        private void dgvphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            txtmathuoc.Text = dgvphieunhap[0, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
            txttenthuoc.Text = dgvphieunhap[1, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
            txtmancc.Text = dgvphieunhap[2, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
            txtdongia.Text = dgvphieunhap[3, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
            txtsoluong.Text = dgvphieunhap[4, dgvphieunhap.CurrentCell.RowIndex].Value.ToString();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvphieunhap.Rows)
            {
                string code = row.Cells["clmathuoc"].Value?.ToString();
                if (code == txtmathuoc.Text)
                {
                    row.Cells[1].Value = txttenthuoc.Text;
                    row.Cells[2].Value = txtmancc.Text;
                    row.Cells[3].Value = txtdongia.Text;
                    row.Cells[4].Value = txtsoluong.Text;
                    float tongtien = float.Parse(txtsoluong.Text) * float.Parse(txtdongia.Text);
                    row.Cells[5].Value = tongtien.ToString();
                    tinhTien();
                    ResetForm();
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvphieunhap.Rows)
            {
                string code = row.Cells["clmathuoc"].Value?.ToString();
                if (code == txtmathuoc.Text)
                {
                    dgvphieunhap.Rows.Remove(row);
                }
            }
            ResetForm();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            ResetForm();
            dgvphieunhap.Rows.Clear();
            lbtongtien.Text = "0 VND";
        }

        private void txtSearchncc_TextChanged(object sender, EventArgs e)
        {
            dgvncc.DataSource = provider.SearchLinq(txtSearchncc.Text.ToLower());
        }

        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if(dgvphieunhap.Rows.Count > 0)
            {
                if(dgvncc[0, dgvncc.CurrentCell.RowIndex].Value.ToString() != dgvphieunhap.Rows[0].Cells["clncc"].Value.ToString())
                {
                    MessageBox.Show("Vui chỉ tạo phiếu nhập với một nhà cung cấp");
                }
                else
                {
                txtmancc.Text = dgvncc[0, dgvncc.CurrentCell.RowIndex].Value.ToString();
                txttenncc.Text = dgvncc[1, dgvncc.CurrentCell.RowIndex].Value.ToString();
                }
            }
            else
            {
                txtmancc.Text = dgvncc[0, dgvncc.CurrentCell.RowIndex].Value.ToString();
                txttenncc.Text = dgvncc[1, dgvncc.CurrentCell.RowIndex].Value.ToString();
                List<Product> danhSachSanPham = product.GetSanPhamByNhaCungCap(int.Parse(dgvncc[0, dgvncc.CurrentCell.RowIndex].Value.ToString()));
                dgvsanpham.DataSource = danhSachSanPham;
            }
        }
        private void XuatWord(PhieuNhap maph,string tennv,DateTime today, string ncc)
        {
            //Xuất file phiếu nhập
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin lớp";
            string filePath = "D:\\WorkSpace\\Đồ án 1\\Phiếu Nhập\\" + maph.Maphieunhap.ToString() + " - Phiếu nhập" + today.Day.ToString() + "-" + today.Month.ToString() + "-" + today.Year.ToString() + "-" + ncc + "-" + Bien.username.ToString() + ".docx";
            FileInfo fi = new FileInfo(filePath);
            fi.Create().Close();
            if (fi.FullName != "")
            {
                try
                {
                    chitietpn.KetXuatWord(maph,tennv,ncc, @"Template\Chitietphieunhap.docx", fi.FullName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
            }
        }      
        private void btnreload_Click(object sender, EventArgs e)
        {
            ResetForm();
            FrmImportProducts_Load(sender, e);
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            FrmXemPhieuNhap frm = new FrmXemPhieuNhap();
            frm.Show();
        }
    }
}
