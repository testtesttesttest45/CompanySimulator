using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExperimentTreeViewV2.Classes;

namespace ExperimentTreeViewV2
{
    public partial class FormEmployeeChangeRoleOrOfficer : Form
    {
        private Employee _oneEmployee;
        public delegate void ChangeEmployeeDelegate(string uuid, string reportingOfficer, string subRole);
        public ChangeEmployeeDelegate ChangeRoleCallback;

        public FormEmployeeChangeRoleOrOfficer(string uuid, string Name, string parent, int salary, bool isDummy, string role, Dictionary<String, HashSet<String>> roleEmployees)
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
            comboboxReportingOfficer.Items.AddRange(roleEmployees[role].ToArray()); // populate comboboxReportingOfficer dropdown with the reporting officers of current employee
            comboboxRole.Text = role; // set to current role
            comboboxRole.Items.AddRange(roleEmployees.Keys.ToArray());
            // after an item is selected in the combobox dropdown, update comboboxReportingOfficer dropdown with the employees of the selected role
            comboboxRole.SelectedIndexChanged += (sender, e) =>
            {
                comboboxReportingOfficer.Text = "";
                comboboxReportingOfficer.Items.Clear();
                comboboxReportingOfficer.Items.AddRange(roleEmployees[comboboxRole.SelectedItem.ToString()].ToArray());
            };
            


        }

        private void FormEmployeeChangeRoleOrOfficer_Load(object sender, EventArgs e)
        {
            this.textboxName.Text = _oneEmployee.Name;
            this.textboxUUID.Text = _oneEmployee.UUID;
            this.textboxSalary.Text = _oneEmployee.Salary.ToString();
            //this.comboboxRole.Text = _oneEmployee.EmpRole;
            comboboxReportingOfficer.Text = _oneEmployee.Parent;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ChangeRoleCallback(this._oneEmployee.UUID, comboboxReportingOfficer.Text, comboboxRole.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
    
}
