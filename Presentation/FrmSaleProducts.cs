using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;

namespace Presentation
{
    public partial class FrmSaleProducts : Form
    {
        IProductBUL product = new ProductBUL();
        IChiTietHoaDonBUL chitiethd = new ChiTietHoaDonBUL();
        IHoaDonBanBUL hoadon = new HoaDonBanBUL();
        public void InsertChiTietHoaDon()
        {
            foreach (DataGridViewRow row in dgvhoadon.Rows)
            {
                int soluong =int.Parse(row.Cells[3].Value.ToString());
                int mathuoc = int.Parse(row.Cells[0].Value.ToString());
                float priceProduct = float.Parse(row.Cells[2].Value.ToString());
                int mahoadon = hoadon.GetLastHD().Mahoadon;
                chitiethd.Insert(new ChiTietHoaDonBan(mahoadon,priceProduct,mathuoc,soluong));                  
            }
        }
        public void ResetDgv()
        {
            dgvhoadon.Rows.Clear();
            dgvhoadon.DataSource = null;
            lbPrice.Text = "0";
        }
        public FrmSaleProducts()
        {
            InitializeComponent();
        }

        private void FrmSaleProducts_Load(object sender, EventArgs e)
        {
            dgvproduct.AutoGenerateColumns = false;
            dgvproduct.DataSource = product.getAll();
            btnPay.Enabled= false;  
            btnDestroy.Enabled= false;
        }

        private void dgvproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            
            
            int selectedRowIndex = e.RowIndex;
            if (e.RowIndex >= 0 && e.RowIndex < dgvproduct.RowCount)
            {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvproduct.Rows[selectedRowIndex];
                int soLuong = product.getAll()
                    .Where(t => t.Mathuoc == int.Parse(selectedRow.Cells["clmathuoc"].Value.ToString()))
                    .Select(t => t.Soluong)
                    .FirstOrDefault();
                    if (soLuong == 0)
                    {
                        MessageBox.Show("Số lượng thuốc không đủ để bán");
                    }
                    else
                    {
                    DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();
                    for (int i = 0; i < selectedRow.Cells.Count; i++)
                    {
                    newRow.Cells[i].Value = selectedRow.Cells[i].Value;                         
                    }
                    // Thêm hàng mới vào DataGridView mới
                    AddRowIfNotExist(dgvhoadon, newRow);
                    foreach (DataGridViewRow row in dgvhoadon.Rows)
                    {
                        DataGridViewButtonCell quantityCell = new DataGridViewButtonCell();
                        quantityCell.Value = "+";
                        DataGridViewButtonCell quantityCell2 = new DataGridViewButtonCell();
                        quantityCell2.Value = "-";
                        row.Cells["btnIncrease"] = quantityCell;
                        row.Cells["btnDecrement"] = quantityCell2;
                        row.Cells["clsoluong"].Value = 1;
                    }   
                    CheckSateBtn();
                    CaculatorPrice();
                    }
                }
            }           

            
        }
        private bool IsRowExist(DataGridView dataGridView, DataGridViewRow newRow)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool isExist = true;

                for (int i = 0; i < 2; i++)
                {                     
                    // So sánh giá trị của ô trong hai dòng
                    if (row.Cells[i].Value != null && !row.Cells[i].Value.Equals(newRow.Cells[i].Value))
                    {
                        isExist = false;
                        break;
                    }
                }
                if (isExist)
                {
                    // Dòng đã tồn tại trong DataGridView
                    return true;
                }
            }
            // Dòng chưa tồn tại trong DataGridView
            return false;
        }
        private void AddRowIfNotExist(DataGridView dataGridView, DataGridViewRow newRow)
        {
            if (!IsRowExist(dataGridView, newRow))
            {
                dataGridView.Rows.Add(newRow);         
                
            }
        }

        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {               
                DataGridViewRow row = dgvhoadon.Rows[e.RowIndex];
                int currentValue = Convert.ToInt32(row.Cells["clsoluong"].Value); 
                int mathuoc = int.Parse(row.Cells["clmasp"].Value.ToString());
                int soLuong = product.GetSoluong(mathuoc);
                if (dgvhoadon.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvhoadon.Columns[e.ColumnIndex].Name == "btnIncrease")
                {
                    currentValue++;
                }
                else if (dgvhoadon.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvhoadon.Columns[e.ColumnIndex].Name == "btnDecrement")
                {
                    if (currentValue > 0)
                    {
                        currentValue--;
                    }
                }
                row.Cells["clsoluong"].Value = currentValue.ToString();
                CaculatorPrice();
                if (currentValue == 0)
                {
                    int selectedIndex = dgvhoadon.CurrentCell.RowIndex;
                    dgvhoadon.Rows.RemoveAt(selectedIndex);
                    CheckSateBtn();
                }
                if (soLuong == 0 || soLuong < currentValue)
                {
                    MessageBox.Show("Số lượng thuốc không đủ để bán");
                    btnPay.Enabled = false;
                }                         
        }
        private void btnDestroy_Click(object sender, EventArgs e)
        {
            dgvhoadon.Rows.Clear();
            dgvhoadon.DataSource = null;
            lbPrice.Text = "0";
        }
        public void CheckSateBtn()
        {
            if (dgvhoadon.RowCount > 0)
            {
                btnPay.Enabled = true;
                btnDestroy.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
                btnDestroy.Enabled = false;
            }
        }
        public void CaculatorPrice()
        {
            float sumPrice = 0;
            foreach (DataGridViewRow row in dgvhoadon.Rows)
            {
                string soluong = row.Cells["clsoluong"].Value?.ToString();
                string gia = row.Cells["cldongia"].Value?.ToString();
                sumPrice += float.Parse(soluong) * float.Parse(gia);
            }
            lbPrice.Text = sumPrice.ToString("#,##0 VND");
            Bien.tonghoadon = sumPrice;
        }     
        private void btnPay_Click(object sender, EventArgs e)
        {
            FrmImportSale frm = new FrmImportSale(this);
            frm.ShowDialog();
        }

        private void btnSearch_click(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            dgvproduct.DataSource =  product.SearchLinq(value);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvproduct.AutoGenerateColumns = false;
            dgvproduct.DataSource = product.getAll();
        }
    }
}
