using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmImportSale : Form
    {
        IKhachHangBUL kh = new KhachHangBUL();
        IHoaDonBUL hoadon = new HoaDonBUL();
        IChiTietHoaDonBUL chitiet = new ChiTietHoaDonBUL();
        FrmSaleProducts frm;
        public FrmImportSale(FrmSaleProducts frm1)
        {
            InitializeComponent();
            frm = frm1;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void FrmImportSale_Load(object sender, EventArgs e)
        {
            lbprice.Text = Bien.tonghoadon.ToString("#,##0 VND");
            btnPay.Enabled = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {          
            if(!cbIsExit.Checked)
            {
                kh.Insert(new Entities.KhachHang(txtName.Text,"", txtPhone.Text,""));
            }         
            string sdt = txtPhone.Text;
            int makh;
            if (!cbIsExit.Checked)
            {
                makh = kh.getAll().LastOrDefault().Makhachhang;
            }
            else
            {
                makh = kh.SearchLinq(sdt)[0].Makhachhang;
            }
            DateTime today = DateTime.Today;
            float tongtien = Bien.tonghoadon;
            int manv = Bien.manhanvien;
            hoadon.Insert(new Entities.HoaDon(today,tongtien,makh,manv));
            List<HoaDon> danhSachSapXep = hoadon.getAll().OrderByDescending(hd => hd.Mahoadon).ToList();
            // Lấy mã hóa đơn mới nhất
            int maHoaDonMoiNhat = danhSachSapXep.First().Mahoadon;
            frm.InsertChiTietHoaDon();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin lớp";
            string filePath = "D:\\WorkSpace\\Đồ án 1\\Hóa Đơn\\" + "Hóa đơn" + today.Day.ToString() + "-" + today.Month.ToString() + "-" + today.Year.ToString() + "-" + makh.ToString() + ".docx";
            FileInfo fi = new FileInfo(filePath);
            fi.Create().Close();
            if (fi.FullName != "")
            {
                try
                {
                    chitiet.KetXuatWord(txtName.Text,maHoaDonMoiNhat,tongtien, @"Template\Chitiethoadon_Template.docx", fi.FullName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }

            }
            frm.ResetDgv();
            this.Close();
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string value = txtPhone.Text.Trim();
            cbIsExit.ForeColor = Color.Transparent;
            if (value != "" && kh.SearchLinq(value).Count > 0)
            {
                cbIsExit.Checked = true;
                cbIsExit.ForeColor = Color.Green;
                txtName.Text = kh.SearchLinq(value)[0].Hoten;
            }
            else
            {
                cbIsExit.Checked = false;
                cbIsExit.ForeColor = Color.Transparent;
                txtName.Text = "";
            }
        }
        private void txtbuy_TextChanged(object sender, EventArgs e)
        {
            if (txtbuy.Text != "" && Bien.tonghoadon <= float.Parse(txtbuy.Text))
            {
                btnPay.Enabled = true;
                float priceBack = float.Parse(txtbuy.Text) -  Bien.tonghoadon;
                lbRest.Text = priceBack.ToString("#,##0 VND");
            }
            else
            {
                btnPay.Enabled = false;
                lbRest.Text = "";
            }
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
