using BusinessLogicLayer;
using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using System.Windows.Forms.DataVisualization.Charting;

namespace Presentation
{
    public partial class FrmHome : Form
    {
        IProductBUL product = new ProductBUL();
        IKhachHangBUL kh = new KhachHangBUL();
        INhanVienBUL nv = new NhanVienBUL();
        IHoaDonBUL hoadon = new HoaDonBUL();
        private float currentDoanhThu;
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
       
        private void FrmHome_Load(object sender, EventArgs e)
        {
            PaintChart();
            GetDataForm();
        }
        private float GetDataForMonth(int month, int year)
        {
            if(month == DateTime.Now.Month)
            {
                currentDoanhThu = hoadon.GetDoanhThu(month, year) /  1000000f;
            }
            float tonghoadon =  hoadon.GetDoanhThu(month, year);
            float result = tonghoadon / 1000000f;
            return result;
        }      
        private void btnTK_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan frm = new FrmTaiKhoan();
            frm.ShowDialog();
        }
        private void GetDataForm()
        {
            LbDate.Text = DateTime.Now.ToString();
            lbtentk.Text = Bien.username.ToString();
            lbchucvu.Text = Bien.chucvu.ToString();
            lbProduct.Text = product.getAll().Count.ToString();
            lbEmloyee.Text = nv.getAll().Count.ToString();  
            lbCustormer.Text = kh.getAll().Count.ToString();
            lbDoanhThu.Text = currentDoanhThu.ToString() + " (triệu)";
        }

        private void PaintChart()
        {
            int currentYear = DateTime.Now.Year;
            chartRevenue.Series.Clear();
            chartRevenue.Series.Add("RevenueData");
            chartRevenue.Series["RevenueData"].ChartType = SeriesChartType.Column;
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            for (int month = 1; month <= 12; month++)
            {
                // Giả sử bạn có dữ liệu cho từng tháng lưu trong một mảng hoặc danh sách
                float monthData = GetDataForMonth(month, currentYear);
                // Thêm điểm dữ liệu cho từng tháng
                chartRevenue.Series["RevenueData"].Points.AddXY(month.ToString(), monthData);
            }
            chartRevenue.ChartAreas[0].AxisX.Title = "Tháng";
            chartRevenue.Series["RevenueData"].LegendText = "Doanh Thu (triệu)";
        }
    }
}
