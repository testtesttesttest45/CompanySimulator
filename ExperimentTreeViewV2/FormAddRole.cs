using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExperimentTreeViewV2.Classes;

namespace ExperimentTreeViewV2
{
    
    public partial class FormAddRole : Form
    {
        public delegate void AddRoleDelegate(string parent, string newRoleName, bool isLeader);
        public AddRoleDelegate AddRoleCallback; // can reference a method, multiple form can work together

        public FormAddRole()
        {
            InitializeComponent();
        }
        public FormAddRole(string parent)
        {
            InitializeComponent();
            labelParent.Text = parent; 
            
        }
        private void FormAddRole_Load(object sender, EventArgs e)
        {

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // if name is empty, show error message
            if (textboxName.Text == "")
            {
                MessageBox.Show("Please enter a role name");
                return;
            }
            string parent = labelParent.Text;
            string name = textboxName.Text;
            AddRoleCallback(parent, name, checkBox1.Checked);
            this.DialogResult = DialogResult.OK;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
