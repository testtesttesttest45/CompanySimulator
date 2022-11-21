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
    public partial class FormManageEmployee : Form
    {
        DataManager _dataManager;

        EmployeeTreeNode _selectedNode;
        TreeNode _currentSelectedNode;
        private ContextMenuStrip _employeeMenu;
        private ToolStripMenuItem _edit;

        Employee _employee;
        //Create some menu items.

        ToolStripMenuItem _removeMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _addMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _swapMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _changeMenuItem = new ToolStripMenuItem();
        public FormManageEmployee()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _selectedNode = null;
        }
        private void FormManageEmployee_Load(object sender, EventArgs e)
        {
            InitializeMenuTreeView();
            checkboxSalary.Checked = true;
            textboxAnalyze.Text = "Each employee can have maximum 2 employee nodes.";
        }
        public void InitializeMenuTreeView()
        {

            // Create the ContextMenuStrip.
            _employeeMenu = new ContextMenuStrip();
            _edit = new ToolStripMenuItem();

            _addMenuItem.Text = "Add Employee";
            _edit.Text = "Edit Employee";
            _updateMenuItem.Text = "Edit Employee Details";
            _removeMenuItem.Text = "Remove Employee";
            _swapMenuItem.Text = "Swap Employee";
            _changeMenuItem.Text = "Change Role/Reporting officer";
            _employeeMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            //When the menu is opening, need some logic to inspect the selected node's info so that
            //the correct menu item is displayed or enabled. The logic is defined inside the contextMenu_Opening method
            _employeeMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);

            //Add the menu items to the menu.
            _employeeMenu.Items.AddRange(new ToolStripMenuItem[] { _addMenuItem, _edit, _removeMenuItem, _swapMenuItem });
            _edit.DropDownItems.Add(_updateMenuItem);
            _edit.DropDownItems.Add(_changeMenuItem);

            _edit.DropDownItems[0].Click += dropdownClick;
            _edit.DropDownItems[1].Click += dropdownClick;
            //Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewEmployee.ContextMenuStrip = _employeeMenu;

            treeViewEmployee.Nodes.Clear();
            _dataManager.LoadEntireData();
            //_dataManager.GenerateEmptyEmployeeStructure();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
        }
        private void dropdownClick(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (item != null)
            {
                if (item.Text == "Edit Employee Details")
                {  /**** A sample code which is frequently used to get a parent form work with a child form ****/
                    Employee employee = _selectedNode.Employee;
                    //fee stands for form edit employee
                    FormEditEmployee fee = new FormEditEmployee(employee.UUID, employee.Name, _selectedNode.ParentEmployeeTreeNode.Employee.Name, employee.Salary, _selectedNode.isDummy, employee.EmpRole);
                    fee.EditEmployeeCallback = new FormEditEmployee.EditEmployeeDelegate(this.EditEmployeeCallbackFn);
                    fee.ShowDialog();
                }
                else if (item.Text == "Change Role/Reporting officer")
                {
                    _currentSelectedNode = treeViewEmployee.SelectedNode;

                    Employee employee = _selectedNode.Employee;
                    EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                    string name = employeeTreeNode.Employee.Name;

                    Dictionary<String, HashSet<String>> roleEmployees = new Dictionary<String, HashSet<String>>();

                    //RoleTreeNode rootRoleNode = _dataManager.RoleTreeStructure;
                    _dataManager.EmployeeTreeStructure.GetAllUniqueRolesAndEmployeeNames(ref roleEmployees);
                    if (roleEmployees.Count > 0)
                    {//fcr means form change role
                        FormEmployeeChangeRoleOrOfficer fcr = new FormEmployeeChangeRoleOrOfficer(employee.UUID, employee.Name, _selectedNode.ParentEmployeeTreeNode.Employee.Name, employee.Salary, _selectedNode.isDummy, employee.EmpRole, roleEmployees);
                        fcr.ChangeRoleCallback = ChangeRoleCallbackFn;
                        fcr.ShowDialog();
                    }

                }
            }

        }
        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;
            if ((item != null) && (_selectedNode != null))
            {
                if (item.Text == "Add Employee")
                {
                    _currentSelectedNode = treeViewEmployee.SelectedNode;

                    if (_currentSelectedNode == null)
                    {
                        textboxAnalyze.Text = "You must select a employee node to add a new one. ";
                    }
                    else
                    {
                        EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                        string name = employeeTreeNode.Employee.Name;
                        //textboxAnalyze.Text = "Adding a new employee node under " + name;

                        Dictionary<String, String> childrenList = new Dictionary<String, String>();
                        RoleTreeNode rootRoleNode = _dataManager.RoleTreeStructure;
                        if (employeeTreeNode.Employee.EmpRoleUUID == "ROOT")
                        {
                            // if dont have parent, root node

                            foreach (RoleTreeNode r in rootRoleNode.ChildRoleTreeNodes)
                            {
                                childrenList.Add(r.Role.UUID, r.Role.Name);
                            }
                        }
                        else
                        {
                            List<RoleTreeNode> resultNodes = new List<RoleTreeNode>(); // store my role inside
                            if (employeeTreeNode.Employee.isSecondary)
                            {
                                rootRoleNode.SearchByUUID(employeeTreeNode.Employee.EmpRoleUUID2, ref resultNodes); // find my role
                            }
                            else
                            {
                                rootRoleNode.SearchByUUID(employeeTreeNode.Employee.EmpRoleUUID, ref resultNodes); // find my role
                            }
                            if (resultNodes.Count > 0)
                            {
                                RoleTreeNode myRoleNode = resultNodes[0];
                                // if my child is empty, then i wont add anything into children list
                                foreach (RoleTreeNode r in myRoleNode.ChildRoleTreeNodes)
                                {
                                    // add all the chile role and role name.
                                    childrenList.Add(r.Role.UUID, r.Role.Name);
                                }
                            }

                        }

                        if (childrenList.Count > 0)
                        {
                            FormAddEmployee fae = new FormAddEmployee(name, childrenList);
                            fae.AddEmployeeCallback = AddEmployeeCallbackFn;
                            fae.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No more child for your gang.");
                        }

                    }
                    //MessageBox.Show("No modal form created to service the add role operation.");
                }
                if (item.Text == "Remove Employee")
                {
                    _employeeMenu.Visible = false;
                    EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)_selectedNode;
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.OKCancel);
                    // allow removable only if textboxProject is == No Projects and the selected node has no childern.
                    if (textboxProjects.Text == "No Projects" && employeeTreeNode.Nodes.Count == 0)
                    {
                        if (dialogResult == DialogResult.OK)
                        {
                            //_dataManager.RemoveEmployee(employeeTreeNode.Employee.UUID);
                            treeViewEmployee.Nodes.Remove(_selectedNode);
                            List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
                            _dataManager.EmployeeTreeStructure.SearchByUUID(employeeTreeNode.Employee.UUID, ref resultNodes);
                            foreach (EmployeeTreeNode myself in resultNodes)
                            {
                                if (employeeTreeNode.Employee.isSecondary && !myself.Employee.isSecondary)
                                {
                                    // sub one going to delete
                                    myself.Employee.EmpRole2 = "";
                                    myself.Employee.EmpRoleUUID2 = "";
                                    myself.Employee.ReportingOfficer2 = "";
                                    myself.UpdateTextDisplay();
                                }
                                else if (!employeeTreeNode.Employee.isSecondary && myself.Employee.isSecondary)
                                {
                                    // first one going to delete
                                    myself.Employee.isSecondary = false;
                                    myself.Employee.EmpRole = myself.Employee.EmpRole2;
                                    myself.Employee.EmpRoleUUID = myself.Employee.EmpRoleUUID2;
                                    myself.Employee.Parent = myself.Employee.ReportingOfficer2;
                                    myself.Employee.EmpRole2 = "";
                                    myself.Employee.EmpRoleUUID2 = "";
                                    myself.Employee.ReportingOfficer2 = "";
                                    myself.UpdateTextDisplay();
                                }
                            }
                            
                            if (employeeTreeNode.RemoveMyselfFromParent())
                            {
                                MessageBox.Show("Removed", "Alert");
                            }
                        }
                        else
                        {
                            this.DialogResult = DialogResult.No;
                            return;
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Unable to delete selected employee. There are currently projects under the selected employee.", "Execute Employee Swap", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        DialogResult dialogResult2 = MessageBox.Show("The employee can only be removed if there are no subordinates, no assigned projects or if after removal will still remain a full team. Would you like to swap the employee with another first?", "Execute Employee Swap", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        // if button ok is clicked, open the FormEmployeeSwap
                        if (dialogResult2 == DialogResult.OK)
                        {
                            Employee employee = _selectedNode.Employee;
                            FormEmployeeSwap fes = new FormEmployeeSwap(employee.UUID, employee.Name, _selectedNode.ParentEmployeeTreeNode.Text, employee.Salary, _dataManager.EmployeeTreeStructure);
                            fes.SwapEmployeeCallback = new FormEmployeeSwap.SwapEmployeeDelegate(this.SwapEmployeeCallback);
                            fes.ShowDialog();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.No;
                            return;
                        }

                    }



                    //RoleTreeNode parentSelected = roleTreeNode.ParentRoleTreeNode;
                    //parentSelected.re
                    //MessageBox.Show("Unable to delete selected role. There are currently employees under the selected role.");
                }
                if (item.Text == "Swap Employee")
                {
                    Employee employee = _selectedNode.Employee;

                    //fee stands for form edit employee
                    FormEmployeeSwap fes = new FormEmployeeSwap(employee.UUID, employee.Name, _selectedNode.ParentEmployeeTreeNode.Text, employee.Salary, _dataManager.EmployeeTreeStructure);
                    fes.SwapEmployeeCallback = new FormEmployeeSwap.SwapEmployeeDelegate(this.SwapEmployeeCallback);
                    fes.ShowDialog();
                    //treeViewEmployee.Nodes.Clear();
                    //treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
                    //treeViewEmployee.ExpandAll();
                }
            }

        }//end of contextMenu_ItemClicked
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;
            //Enable all menu items first. Then disable the menu items which are not appropriate
            foreach (ToolStripMenuItem item in _employeeMenu.Items)
            {
                item.Enabled = true;
            }


            if (_selectedNode.Employee.Name == "ROOT")
            {
                this._updateMenuItem.Enabled = false;
                this._removeMenuItem.Enabled = false;
                this._swapMenuItem.Enabled = false;
                this._changeMenuItem.Enabled = false;
            }
            if (_selectedNode.Employee.Name != "ROOT")
            {

                //if (_selectedNode.ChildEmployeeTreeNodes.Count > 0)
                //{
                this._updateMenuItem.Enabled = true;
                this._changeMenuItem.Enabled = true;
                //Should not allow the user to remove the RoleTreeNode object
                //because there are child TreeNodes detected.
                this._removeMenuItem.Enabled = true;

                //}
                //if (_selectedNode.ParentEmployeeTreeNode.isLeader)
                //{
                //    this._addMenuItem.Enabled = false;
                // }
                // else
                //{
                //    this._addMenuItem.Enabled = true;
                // }
            }
        }

        private void SwapEmployeeCallback(string uuidMain, string uuidSwap)
        {
            //if (uuidSwap == "ROOT")
            //{
            //    MessageBox.Show("Cannot swap boss");
            //    return;
            //}
            // create an exception handler, if the selected item has no parent, then return.

            List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
            _dataManager.EmployeeTreeStructure.SearchByUUID(uuidMain, ref resultNodes);
            List<EmployeeTreeNode> resultNodes2 = new List<EmployeeTreeNode>();
            _dataManager.EmployeeTreeStructure.SearchByUUID(uuidSwap, ref resultNodes2);
            string mainName = resultNodes[0].Employee.Name;
            int mainSalary = resultNodes[0].Employee.Salary;
            string empName = resultNodes[0].Text;
            resultNodes[0].Employee.Name = resultNodes2[0].Employee.Name;
            resultNodes[0].Employee.Salary = resultNodes2[0].Employee.Salary;
            // resultNodes[0].Name = resultNodes2[0].Text;
            //resultNodes[0].Text = resultNodes2[0].Text;
            resultNodes[0].UpdateTextDisplay();

            resultNodes2[0].Employee.Name = mainName;
            resultNodes2[0].Employee.Salary = mainSalary;
            //resultNodes2[0].Text = empName;
            resultNodes2[0].UpdateTextDisplay();
            //treeViewEmployee.Nodes.Clear();
            //treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            //treeViewEmployee.ExpandAll();
        }
        private void AddEmployeeCallbackFn(string parent, string newEmployeeName, int salary, string roleUUID, bool isDummy)
        {
            List<RoleTreeNode> resultNodes = new List<RoleTreeNode>();
            _dataManager.RoleTreeStructure.SearchByUUID(roleUUID, ref resultNodes);

            EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)_currentSelectedNode; // casting here
            textboxAnalyze.Text = "Employee added: " + "\r\nName: " + newEmployeeName + "\r\nSalary: " + salary + "\r\nRole: " + employeeTreeNode.Employee.EmpRole + "\r\nReporting to: " + parent;
            _employee = new Employee(newEmployeeName, salary, resultNodes[0].Role.Name, resultNodes[0].Role.UUID);

            EmployeeTreeNode tempEmployee = new EmployeeTreeNode(_employee);
            tempEmployee.isDummy = isDummy;
            employeeTreeNode.AddChildEmployeeTreeNode(tempEmployee); // initially cannot access AddChildRoleTreeNode method at first because is a treenode type object,not RoleTreeNode typeobject, must conversion first  
        }
        private void ChangeRoleCallbackFn(string uuid, string subReportingOfficer, string subRole)
        {
            List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
            _dataManager.EmployeeTreeStructure.SearchByUUID(uuid, ref resultNodes);
            resultNodes[0].Employee.EmpRole2 = subRole;
            resultNodes[0].Employee.ReportingOfficer2 = subReportingOfficer;

            List<EmployeeTreeNode> reportingOfficers = new List<EmployeeTreeNode>();
            EmployeeTreeNode newReportingOfficer = null;
            _dataManager.EmployeeTreeStructure.GetReportingOfficerByName(subReportingOfficer, ref reportingOfficers);
            bool foundRole = false;
            for (int i = 0; i < reportingOfficers.Count; i++)
            {
                List<RoleTreeNode> roles = new List<RoleTreeNode>();
                RoleTreeNode rootRoleNode = _dataManager.RoleTreeStructure;
                // Taking my role node
                rootRoleNode.SearchByUUID(reportingOfficers[i].Employee.EmpRoleUUID, ref roles);
                if (roles.Count > 0)
                {
                    RoleTreeNode myRoleNode = roles[0];
                    // if my child is empty, then i wont add anything into children list
                    foreach (RoleTreeNode r in myRoleNode.ChildRoleTreeNodes)
                    {
                        if (r.Role.Name == subRole)
                        {
                            newReportingOfficer = reportingOfficers[i];
                            resultNodes[0].Employee.EmpRoleUUID2 = r.Role.UUID;
                            foundRole = true;
                            break;
                        }

                    }

                }
                if (foundRole)
                {
                    break;
                }
            }
            resultNodes[0].UpdateTextDisplay();
            Employee newEmployee = new Employee(resultNodes[0].Employee);
            newEmployee.isSecondary = true;
            EmployeeTreeNode tempEmployee = new EmployeeTreeNode(newEmployee);
            newReportingOfficer.AddChildEmployeeTreeNode(tempEmployee);
        }
        private void EditEmployeeCallbackFn(string uuid, string Name, string parent, int salary, bool isDummy)
        {
            List<EmployeeTreeNode> resultNodes = new List<EmployeeTreeNode>();
            //Find the EmployeeTreeNode object which has the Employee  object containing the matching
            //UUID value.
            _dataManager.EmployeeTreeStructure.SearchByUUID(uuid, ref resultNodes);
            //By right, there should only be one EmployeeTreeNode object found. Therefore,
            //I directly point to the first element inside the List to access the Employee object's Name and Text property data.
            resultNodes[0].Employee.Name = Name;
            resultNodes[0].Text = Name;
            resultNodes[0].isDummy = isDummy;
            EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)_selectedNode;
            employeeTreeNode.EditEmployee(Name, salary);
            textboxAnalyze.Text = "Employee details edited: " + "\r\nName: " + Name + "\r\nSalary: " + salary;
        }//end of EditEmployeeCallbackFn method




        private void buttonReset_Click(object sender, EventArgs e)
        {
            treeViewEmployee.Nodes.Clear();
            _dataManager.GenerateEmptyEmployeeStructure();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
            textboxAnalyze.Text = "Reset success";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //_dataManager.SaveEmployeeData();
            _dataManager.SaveEntireData();
            textboxAnalyze.Text = "Data saved successfully";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //_dataManager.LoadEmployeeData();
            _dataManager.LoadEntireData();
            treeViewEmployee.Nodes.Clear();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();
            textboxAnalyze.Text = "Data loaded successfully";
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            treeViewEmployee.ExpandAll();
        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            treeViewEmployee.CollapseAll();
        }
        private void treeViewRole_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedNode = (EmployeeTreeNode)treeViewEmployee.SelectedNode;

            if (e.Node.IsSelected)
            {
                EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)e.Node;
                if (_selectedNode.Employee.Name == "ROOT")
                {
                    textboxUUID.Text = "ROOT";
                    textboxReportingOfficer.Text = "N.A.";
                    textboxName.Text = employeeTreeNode.Employee.Name;
                    textboxSalary.Text = "N.A.";
                    textboxRole.Text = "ROOT";
                    textboxProjects.Text = "No Projects";
                    return;
                }

                textboxUUID.Text = employeeTreeNode.Employee.UUID;
                textboxSalary.Text = employeeTreeNode.Employee.Salary.ToString();
                if (employeeTreeNode.Employee.isSecondary)
                {
                    textboxRole.Text = employeeTreeNode.Employee.EmpRole2;
                }
                else
                {
                    textboxRole.Text = employeeTreeNode.Employee.EmpRole;
                }

                textboxReportingOfficer.Text = _selectedNode.ParentEmployeeTreeNode.Employee.Name;
                textboxName.Text = employeeTreeNode.Employee.Name;
                // display dummy checked or not
                if (employeeTreeNode.isDummy)
                {
                    checkboxDummy.Checked = true;
                }
                else
                {
                    checkboxDummy.Checked = false;
                }
                if (employeeTreeNode.EmpProjectList.Count > 0)
                {
                    textboxProjects.Text = "";
                    for (int i = 0; i < employeeTreeNode.EmpProjectList.Count; i++)
                    {
                        textboxProjects.Text += employeeTreeNode.EmpProjectList[i];
                        if (i < employeeTreeNode.EmpProjectList.Count - 1)
                        {
                            textboxProjects.Text += ", ";
                        }
                    }
                }
                else
                {
                    textboxProjects.Text = "No Projects";
                }

            }

        }



    }
}
