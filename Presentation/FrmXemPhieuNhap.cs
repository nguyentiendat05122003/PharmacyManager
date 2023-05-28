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
    public partial class FrmXemPhieuNhap : Form
    {
        IPhieuNhapBUL pn = new PhieuNhapBUL();
        public FrmXemPhieuNhap()
        {
            InitializeComponent();
        }

        private void FrmXemPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvphieunhap.DataSource = pn.GetAllJoinFull();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvphieunhap.DataSource = pn.SearchLinq(txtSearch.Text);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvphieunhap.DataSource = pn.GetAllJoinFull();
        }
    }
}
