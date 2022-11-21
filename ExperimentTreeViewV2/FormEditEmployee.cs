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
    public partial class FormEditEmployee : Form
    {
        private Employee _oneEmployee;
        public delegate void EditEmployeeDelegate(string uuid, string Name, string parent, int salary, bool isDummy);
        public EditEmployeeDelegate EditEmployeeCallback;
        public FormEditEmployee()
        {
            InitializeComponent();
        }
        public FormEditEmployee(string uuid, string Name, string parent, int salary, bool isDummy, string role)
        {

            InitializeComponent();
            this._oneEmployee = new Employee(Name, salary, "", "");
            this._oneEmployee.Name = Name;
            this._oneEmployee.UUID = uuid;
            this._oneEmployee.Salary = salary;
            this._oneEmployee.Parent = parent;
            this._oneEmployee.EmpRole = role;
            textboxSalary.Text = salary.ToString();
            checkboxDummy.Checked = isDummy;

        }
        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            this.textboxName.Text = _oneEmployee.Name;
            this.textboxUUID.Text = _oneEmployee.UUID;
            this.textboxSalary.Text = _oneEmployee.Salary.ToString();
            this.textboxRole.Text = _oneEmployee.EmpRole;
            textboxReportingOfficer.Text = _oneEmployee.Parent;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string uuid = textboxUUID.Text.Trim();
            //string name = textboxName.Text.Trim();
            //int salary = int.Parse(textboxSalary.Text);
            //string parent = textboxReportingOfficer.Text.Trim();
            if (textboxSalary.Text == "" || textboxName.Text == "")
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
                MessageBox.Show("Employee salary must not be zero or negative. Please input a valid employee salary.", "Invalid Employee Salary");
                return;
            }
            if (name != "")
            {
                EditEmployeeCallback(uuid, name, parent,salary,checkboxDummy.Checked);
                this.DialogResult = DialogResult.OK;

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
