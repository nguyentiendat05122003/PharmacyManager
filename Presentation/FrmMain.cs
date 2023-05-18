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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
           
        }
        private Form currentformchild;
        private void OpenchildForm(Form childForm)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childForm;
            childForm.TopLevel = false;

            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {      
            OpenchildForm(new FrmHome());
        }

        private void btnSaleProduct_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmSaleProducts());
        }   

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmProduct());
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmImportProducts());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmEmployee());
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmProvider());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmCustomer());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenchildForm(new FrmHome());
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
