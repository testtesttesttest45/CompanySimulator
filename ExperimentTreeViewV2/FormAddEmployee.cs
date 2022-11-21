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
    public partial class FormAddEmployee : Form
    {
        public delegate void AddEmployeeDelegate(string parent, string newemployeeName, int salary, string roleUUID,  bool isDummy);
        public AddEmployeeDelegate AddEmployeeCallback;
        Dictionary<String, String> childrenRoles;
        public FormAddEmployee()
        {
            InitializeComponent();
        }
        public FormAddEmployee(string parent, Dictionary<String, String> childrenRoleNodes)
        {
            InitializeComponent();
            textboxReportingOfficer.Text = parent;
            childrenRoles = childrenRoleNodes;
            comboboxRole.DataSource = new BindingSource(childrenRoles, null);
            comboboxRole.DisplayMember = "Value";
            comboboxRole.ValueMember = "Key";
            comboboxRole.SelectedIndex = -1;
            

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //int salary = int.Parse(textboxSalary.Text);
            if (textboxSalary.Text == "" || textboxName.Text == "" || comboboxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please input a valid employee information.");
                return;
            }
            
            int salary;
            string parent;
            string name;
            try
            {
                salary = Convert.ToInt32(textboxSalary.Text);
                parent = textboxReportingOfficer.Text;
                name = textboxName.Text;
            }
            catch
            {
                MessageBox.Show("Please input a valid employee information.");
                return;
            }
            if (salary <= 0)
            {
                MessageBox.Show("Employee salary must not be zero or negative. Please input a valid employee salary." ,"Invalid Employee Salary");
                return;
            }
            
            AddEmployeeCallback(parent, name, salary, comboboxRole.SelectedValue.ToString(), checkboxDummy.Checked);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkboxDummy_CheckedChanged(object sender, EventArgs e)
        {
            // if this checkbox is checked, the textboxName will be autofilled to "Dummy" and gets disabled
            if (checkboxDummy.Checked)
            {
                textboxName.Text = "Dummy";
                textboxName.Enabled = false;
            }
            else
            {
                textboxName.Text = "";
                textboxName.Enabled = true;
            }
        }
    }
}
