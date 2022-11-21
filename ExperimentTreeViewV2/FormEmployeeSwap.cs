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
    public partial class FormEmployeeSwap : Form
    {
        private Employee _oneEmployee;
        EmployeeTreeNode _selectedNode;
        public delegate void SwapEmployeeDelegate(string uuidMain, string uuidSwap);
        public SwapEmployeeDelegate SwapEmployeeCallback;
        EmployeeTreeNode _cloneNode;
        public FormEmployeeSwap()
        {
            InitializeComponent();
        }
        public FormEmployeeSwap(string uuid, string Name, string parent, int salary, EmployeeTreeNode empNode)
        {
            InitializeComponent();
            this._oneEmployee = new Employee(Name, 0,"","");
            this._oneEmployee.Name = Name;
            this._oneEmployee.UUID = uuid;
            this._oneEmployee.Parent = parent;
            this._oneEmployee.Salary = salary;
            _cloneNode = (EmployeeTreeNode)empNode.Clone();
            treeViewEmployee2.Nodes.Add(_cloneNode);
            treeViewEmployee2.ExpandAll();
        }

        


        private void FormEmployeeSwap_Load(object sender, EventArgs e)
        {
            textboxReplacing.Text = _oneEmployee.Name;


        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {

            if (_selectedNode.ParentEmployeeTreeNode == null)
            {
                MessageBox.Show("Cannot swap boss");
                return;
            }
            
            else
            {
                SwapEmployeeCallback(this._oneEmployee.UUID, _selectedNode.Employee.UUID);
                this.DialogResult = DialogResult.OK;
            }

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void treeViewEmployee2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedNode = (EmployeeTreeNode)treeViewEmployee2.SelectedNode;

            if (e.Node.IsSelected)
            {
                EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)e.Node;
                if (_selectedNode.Employee.Name == "ROOT")
                {
                    textboxUUID.Text = "Root";
                    textboxReportingOfficer.Text = "N.A.";
                    textboxName.Text = employeeTreeNode.Employee.Name;
                    textboxSalary.Text = "N.A.";
                    textboxRole.Text = "Root";
                    textboxProjects.Text = "No Projects";
                    return;
                }

                textboxUUID.Text = employeeTreeNode.Employee.UUID;
                textboxSalary.Text = employeeTreeNode.Employee.Salary.ToString();
                textboxRole.Text = employeeTreeNode.Employee.EmpRole;
                textboxReportingOfficer.Text = _selectedNode.ParentEmployeeTreeNode.Employee.Name;
                textboxName.Text = employeeTreeNode.Employee.Name;


            }
        }
    }
}
