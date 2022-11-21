using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeViewV2
{
    public partial class CompanyAssignment : Form
    {
        public FormManageRole fmr;
        public FormManageEmployee fme;
        public FormManageProject fmp;
        public CompanyAssignment()
        {
            InitializeComponent();
        }

        private void toolstripManageRole_Click(object sender, EventArgs e)
        {
            fmr = new FormManageRole();
            fmr.MdiParent = this;
            fmr.Show();
        }

        private void toolstripManageEmployee_Click(object sender, EventArgs e)
        {
            fme = new FormManageEmployee();
            fme.MdiParent = this;
            fme.Show();
        }

        private void toolstripManageProject_Click(object sender, EventArgs e)
        {
            fmp = new FormManageProject();
            fmp.MdiParent = this;
            fmp.Show();
        }
    }
}
