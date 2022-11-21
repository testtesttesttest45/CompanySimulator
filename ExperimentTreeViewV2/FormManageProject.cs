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
    public partial class FormManageProject : Form
    {
        DataManager _dataManager;

        EmployeeTreeNode _selectedNode;
        TreeNode _currentSelectedNode;
        private ContextMenuStrip _employeeMenu;
        List<EmployeeTreeNode> leaderList = new List<EmployeeTreeNode>();
        List<EmployeeTreeNode> budgetLeaderList = new List<EmployeeTreeNode>();
        Employee _employee;
        Dictionary<string, string> selectedProject = null;

        public FormManageProject()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _selectedNode = null;
            comboboxMode.SelectedIndex = 0; // 0 is view, 1 is add, 2 is edit
        }
        private void FormManageProject_Load(object sender, EventArgs e)
        {
            InitializeMenuTreeView();
            

        }

        public void InitializeMenuTreeView()
        {
            treeViewEmployee.Nodes.Clear();
            _dataManager.LoadEntireData();
            //_dataManager.GenerateEmptyEmployeeStructure();
            treeViewEmployee.Nodes.Add(_dataManager.EmployeeTreeStructure);
            treeViewEmployee.ExpandAll();

            listViewProject.Clear();
            foreach (Dictionary<string, string> projectInfo in _dataManager.ProjectList)
            {
                string[] row = { projectInfo["ProjectUUID"], projectInfo["ProjectName"], projectInfo["Revenue"], projectInfo["LeaderName"] };
                listViewProject.Items.Add(new ListViewItem(row));
            }
            this.listViewProject.MouseDown += new MouseEventHandler(projectListViewItem_MouseDown);
            this.listViewProject.View = View.Details;
            this.listViewProject.AllowDrop = true;
            this.listViewProject.FullRowSelect = true;
            this.listViewProject.MultiSelect = false;

            ColumnHeader header1, header2, header3, header4;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();
            header3 = new ColumnHeader();
            header4 = new ColumnHeader();

            header1.Text = "UUID";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 120;
            header2.Text = "Project Name";
            header2.TextAlign = HorizontalAlignment.Left;
            header2.Width = 120;
            header3.Text = "Revenue";
            header3.TextAlign = HorizontalAlignment.Left;
            header3.Width = 120;
            header4.Text = "Team Leader";
            header4.TextAlign = HorizontalAlignment.Left;
            header4.Width = 120;


            listViewProject.Columns.Add(header1);
            listViewProject.Columns.Add(header2);
            listViewProject.Columns.Add(header3);
            listViewProject.Columns.Add(header4);
        }
        private void projectListViewItem_MouseDown(object sender, MouseEventArgs e)
        {  
        }
        private void comboboxMode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboboxMode.SelectedIndex == 0) // View Mode 
            {
                textboxProjectName.Enabled = false;
                textboxRevenue.Enabled = false;
                comboboxTeamLeader.Enabled = false;
                textboxProjectName2.Enabled = false;
                textboxRevenue2.Enabled = false;
                comboboxTeamLeader2.Enabled = false;
                buttonSearch.Enabled = false;
                buttonSearch2.Enabled = false;
                buttonCancel.Enabled = false;
                buttonEdit.Enabled = false;
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else if (comboboxMode.SelectedIndex == 1) // Add Mode
            {
                textboxProjectName.Enabled = true;
                textboxRevenue.Enabled = true;
                comboboxTeamLeader.Enabled = true;
                textboxProjectName2.Enabled = false;
                textboxRevenue2.Enabled = false;
                comboboxTeamLeader2.Enabled = false;
                buttonSearch.Enabled = true;
                buttonSearch2.Enabled = false;
                buttonCancel.Enabled = true;
                buttonEdit.Enabled = false;
                buttonAdd.Enabled = true;
                buttonDelete.Enabled = false;
            }
            else // Edit Mode
            {
                textboxProjectName.Enabled = false;
                textboxRevenue.Enabled = false;
                comboboxTeamLeader.Enabled = false;
                textboxProjectName2.Enabled = true;
                textboxRevenue2.Enabled = true;
                //comboboxTeamLeader2.Enabled = true;
                buttonSearch.Enabled = false;
                buttonSearch2.Enabled = true;
                buttonCancel.Enabled = false;
                buttonEdit.Enabled = true;
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //_dataManager.SaveEmployeeData();
            _dataManager.SaveEntireData();
            textboxAnalyze.Text = "Data saved successfully";
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            InitializeMenuTreeView();
            textboxAnalyze.Text = "Data loaded successfully";
        }

        

        private void buttonReset_Click(object sender, EventArgs e)
        {
            InitializeMenuTreeView();
            textboxAnalyze.Text = "Data reset to default";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textboxProjectName.Text = "";
            textboxRevenue.Text = "";
            comboboxTeamLeader.SelectedIndex = -1;
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            treeViewEmployee.ExpandAll();
        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            treeViewEmployee.CollapseAll();

        }

        private bool IsEmployeeHandlingProject(EmployeeTreeNode emp)
        {
            // linear search
            foreach(Dictionary<string, string> projectInfo in _dataManager.ProjectList)
            {
                if (projectInfo["LeaderUUID"] == emp.Employee.UUID)
                {
                    return true;
                }
            }
            return false;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            leaderList.Clear();
            budgetLeaderList.Clear();
            EmployeeTreeNode rootEmp = _dataManager.EmployeeTreeStructure;
            RoleTreeNode rootRole = _dataManager.RoleTreeStructure;
            rootEmp.GetAllLeaders(ref leaderList, rootRole);

            
            if (textboxProjectName.Text == "" || textboxRevenue.Text == "")
            {
                MessageBox.Show("Please fill in the project name and revenue");
                textboxAnalyze.Text = "Please fill in the project name and revenue";
                return;
            }
            try
            {
                int projectBudget = Convert.ToInt32(textboxRevenue.Text);
                List<string> budgetLeaderNames = new List<string>();
                foreach (EmployeeTreeNode leader in leaderList)
                {
                    leader.BackColor = Color.White;
                    if (leader.Revenue <= projectBudget && !IsEmployeeHandlingProject(leader))
                    {
                        budgetLeaderList.Add(leader);
                        budgetLeaderNames.Add(leader.Employee.Name);
                        leader.BackColor = Color.Yellow;
                    }

                }
                comboboxTeamLeader.Items.Clear();
                comboboxTeamLeader.Text = "";

                comboboxTeamLeader.Items.AddRange(budgetLeaderNames.ToArray());
                if (comboboxTeamLeader.Items.Count == 0)
                {
                    MessageBox.Show("No leader available");
                    textboxAnalyze.Text = "No leader available";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Please fill in the project revenue correctly");
                textboxAnalyze.Text = "Please fill in the project revenue correctly";
                return;
            }
            
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textboxProjectName.Text == "" || textboxRevenue.Text == "" || comboboxTeamLeader.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields");
                textboxAnalyze.Text = "Please fill in all fields";
                return;
            }
            if (comboboxTeamLeader.SelectedIndex >= 0)
            {
                Dictionary<String, String> projectInfo = new Dictionary<String, String>();
                projectInfo["LeaderUUID"] = budgetLeaderList[comboboxTeamLeader.SelectedIndex].Employee.UUID;
                projectInfo["LeaderName"] = budgetLeaderList[comboboxTeamLeader.SelectedIndex].Employee.Name;
                projectInfo["ProjectUUID"] = General.GenerateUUID();
                projectInfo["ProjectName"] = textboxProjectName.Text;
                projectInfo["Revenue"] = textboxRevenue.Text;
                _dataManager.ProjectList.Add(projectInfo);
                string[] row = { projectInfo["ProjectUUID"], projectInfo["ProjectName"], projectInfo["Revenue"], projectInfo["LeaderName"] };
                listViewProject.Items.Add(new ListViewItem(row));
            }
            textboxAnalyze.Text = "Project added\r\n" + "Name: " + textboxProjectName.Text + "\r\n" + "Revenue: " + textboxRevenue.Text + "\r\n" + "Team Leader: " + comboboxTeamLeader.Text;
            textboxProjectName.Text = "";
            textboxRevenue.Text = "";
            comboboxTeamLeader.SelectedIndex = -1;
            comboboxMode.SelectedIndex = 0;
            // unhighlight all the leaders
            foreach (EmployeeTreeNode leader in leaderList)
            {
                leader.BackColor = Color.White;
            }
        }

        private void listViewProject_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(_dataManager.ProjectList.Count == 0)
            {
                return;
            }
            selectedProject = _dataManager.ProjectList[e.ItemIndex];
            textboxUUID.Text = selectedProject["ProjectUUID"];
            textboxProjectName2.Text = selectedProject["ProjectName"];
            textboxRevenue2.Text = selectedProject["Revenue"];
            comboboxTeamLeader2.Items.Clear();
            comboboxTeamLeader2.Items.Add(selectedProject["LeaderName"]);
            comboboxTeamLeader2.SelectedIndex = 0;
            comboboxTeamLeader2.Enabled = false;
        }

        private void buttonSearch2_Click(object sender, EventArgs e)
        {
            if(selectedProject == null)
            {
                MessageBox.Show("Please select a project");
                textboxAnalyze.Text = "Please select a project";
                return;
            }
            leaderList.Clear();
            budgetLeaderList.Clear();
            comboboxTeamLeader2.Enabled = true;
            EmployeeTreeNode rootEmp = _dataManager.EmployeeTreeStructure;
            RoleTreeNode rootRole = _dataManager.RoleTreeStructure;
            rootEmp.GetAllLeaders(ref leaderList, rootRole);
            try
            {
                int projectBudget = Convert.ToInt32(textboxRevenue2.Text);
                List<string> budgetLeaderNames = new List<string>();
                foreach (EmployeeTreeNode leader in leaderList)
                {
                    leader.BackColor = Color.White;
                    if (leader.Revenue <= projectBudget && (!IsEmployeeHandlingProject(leader) || selectedProject["LeaderUUID"] == leader.Employee.UUID))
                    {
                        budgetLeaderList.Add(leader);
                        budgetLeaderNames.Add(leader.Employee.Name);
                        leader.BackColor = Color.Yellow;
                    }

                }
                comboboxTeamLeader2.Items.Clear();
                comboboxTeamLeader2.Text = "";

                comboboxTeamLeader2.Items.AddRange(budgetLeaderNames.ToArray());
                // if no leader is available, show message box: no leaders found
                if (comboboxTeamLeader2.Items.Count == 0)
                {
                    MessageBox.Show("No leader available");
                    textboxAnalyze.Text = "No leader available";
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please fill in the project revenue correctly");
                textboxAnalyze.Text = "Please fill in the project revenue correctly";
                return;
            }
             
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            // ensure revenue is int when clicking edit
            try
            {
                comboboxTeamLeader2.Enabled = false;
                if (listViewProject.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a project");
                    textboxAnalyze.Text = "Please select a project";
                    return;
                }
                selectedProject = _dataManager.ProjectList[listViewProject.SelectedItems[0].Index];
                if (selectedProject == null)
                {
                    return;
                }
                if (budgetLeaderList.Count > 0)
                {
                    selectedProject["LeaderUUID"] = budgetLeaderList[comboboxTeamLeader2.SelectedIndex].Employee.UUID;
                    selectedProject["LeaderName"] = budgetLeaderList[comboboxTeamLeader2.SelectedIndex].Employee.Name;
                }
                if (textboxProjectName2.Text == "")
                {
                    MessageBox.Show("Please fill in everything!");
                    return;
                }
                int projectBudget = Convert.ToInt32(textboxRevenue2.Text);
                selectedProject["ProjectName"] = textboxProjectName2.Text;
                selectedProject["Revenue"] = textboxRevenue2.Text;
                string[] row = { selectedProject["ProjectUUID"], selectedProject["ProjectName"], selectedProject["Revenue"], selectedProject["LeaderName"] };
                listViewProject.Items[listViewProject.SelectedItems[0].Index] = new ListViewItem(row);
                textboxAnalyze.Text = "Existing project edited\r\n" + "Name: " + textboxProjectName2.Text + "\r\n" + "Revenue: " + textboxRevenue2.Text + "\r\n" + "Team Leader: " + comboboxTeamLeader2.Text;
                textboxUUID.Text = "";
                textboxProjectName2.Text = "";
                textboxRevenue2.Text = "";
                comboboxTeamLeader2.SelectedIndex = -1;
                comboboxMode.SelectedIndex = 0;
                // unhighlight all the leaders
                foreach (EmployeeTreeNode leader in leaderList)
                {
                    leader.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Please fill everything!");
                textboxAnalyze.Text = "Please fill everything!";
                return;
            }


           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewProject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a project");
                textboxAnalyze.Text = "Please select a project";
                return;
            }
            int selectedProjIndex = listViewProject.SelectedItems[0].Index;
            selectedProject = _dataManager.ProjectList[selectedProjIndex];
            if (selectedProject == null)
            {
                return;
            }
            listViewProject.SelectedItems.Clear();
            _dataManager.ProjectList.RemoveAt(selectedProjIndex);
            listViewProject.Items.RemoveAt(selectedProjIndex);
            textboxAnalyze.Text = "Project deleted\r\n" + "Name: " + selectedProject["ProjectName"] + "\r\n" + "Revenue: " + selectedProject["Revenue"] + "\r\n" + "Team Leader: " + selectedProject["LeaderName"];
            textboxUUID.Text = "";
            textboxProjectName2.Text = "";
            textboxRevenue2.Text = "";
            comboboxTeamLeader2.SelectedIndex = -1; 
            comboboxMode.SelectedIndex = 0; // back to view mode
        }
    }
}
