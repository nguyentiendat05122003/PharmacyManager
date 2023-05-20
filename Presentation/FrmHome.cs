using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

namespace Presentation
{
    public partial class FrmHome : Form
    {
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
            //    LbDate.Text = DateTime.Now.ToString();
            //    chartRevenue.Series["SeriesRevenue"].Points.AddXY("1", 1000);
            //    chartRevenue.Series["SeriesRevenue"].Points.AddXY("2", 500);
            //    chartRevenue.Series["SeriesRevenue"].Points.AddXY("3", 700);
            //    chartRevenue.Series["SeriesRevenue"].Points.AddXY("4", 1000);
            //    chartRevenue.Series["SeriesRevenue"].Points.AddXY("5", 700);
            //    chartRevenue.Series["SeriesRevenue"].Points.AddXY("6", 1000);
            //}
            lbtentk.Text = Bien.username.ToString();
            lbchucvu.Text = Bien.chucvu.ToString();          
        }

       

        private void btnTK_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan frm = new FrmTaiKhoan();
            frm.ShowDialog();
        }
    }
}
