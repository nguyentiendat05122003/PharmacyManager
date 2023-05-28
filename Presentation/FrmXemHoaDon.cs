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
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmXemHoaDon : Form
    {
        IHoaDonBanBUL hoadon = new HoaDonBanBUL();
        public FrmXemHoaDon()
        {
            InitializeComponent();
        }

        private void FrmXemHoaDon_Load(object sender, EventArgs e)
        {
            dgvhoadon.DataSource = hoadon.GetAllJoinFull();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvhoadon.DataSource =  hoadon.SearchLinq(txtSearch.Text);
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvhoadon.DataSource = hoadon.GetAllJoinFull();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
