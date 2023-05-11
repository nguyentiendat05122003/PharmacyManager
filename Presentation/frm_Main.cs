using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void mnClass_Click(object sender, EventArgs e)
        {
            frm_Class frm_cls = new frm_Class();
            frm_cls.MdiParent = this;
            frm_cls.WindowState = FormWindowState.Maximized;
            frm_cls.Show();
        }

        private void mnStudent_Click(object sender, EventArgs e)
        {
            frm_Student frm_std = new frm_Student();
            frm_std.MdiParent = this;
            frm_std.WindowState = FormWindowState.Maximized;
            frm_std.Show();
        } 
    }
}
