using ExperimentTreeViewV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExperimentTreeViewV2
{
    public partial class FormManageRole : Form
    {
        DataManager _dataManager;
        RoleTreeNode _selectedNode;
        TreeNode _currentSelectedNode;
        private ContextMenuStrip _roleMenu;
        Role _role;
        //Create some menu items.
        ToolStripMenuItem _removeMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _addMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem _updateMenuItem = new ToolStripMenuItem();
  
        public FormManageRole()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _selectedNode = null;
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            //_dataManager.LoadRoleData();
            _dataManager.LoadEntireData();
            treeViewRole.Nodes.Clear();
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
            textboxAnalyze.Text = "Role data loaded";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeMenuTreeView();
            textboxAnalyze.Text = "Roles cannot be added if there are projects assigned.\r\nRoles cannot be removed if there are employees under it.\r\nOnly one level of role is allowed under a project leader role.";
        }
        //Reference: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-attach-a-shortcut-menu-to-a-treeview-node?view=netframeworkdesktop-4.8
        //Declare the ContextMenuStrip
        


        public void InitializeMenuTreeView()
        {

            // Create the ContextMenuStrip.
            _roleMenu = new ContextMenuStrip();
            _removeMenuItem.Text = "Remove role";
            _addMenuItem.Text = "Add role";
            _updateMenuItem.Text = "Update role";

            //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
            //When the menu item is clicked, need the logic inside the contextMenu_ItemClicked method to
            //decide on operations such as make a form interface to appear for update, make a dialog interface appear to confirm delete etc.
            _roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            //When the menu is opening, need some logic to inspect the selected node's info so that
            //the correct menu item is displayed or enabled. The logic is defined inside the contextMenu_Opening method
            _roleMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);

            //Add the menu items to the menu.
            _roleMenu.Items.AddRange(new ToolStripMenuItem[]{_removeMenuItem, _addMenuItem, _updateMenuItem});
            //Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewRole.ContextMenuStrip = _roleMenu;
            
            treeViewRole.Nodes.Clear();
            _dataManager.GenerateEmptyTreeStructure();
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
        }

        //public void treeViewRole
        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            if ((item != null )&& (_selectedNode!=null))
            {
                if(item.Text == "Update role")
                {   /**** A sample code which is frequently used to get a parent form work with a child form ****/
                    Role role = _selectedNode.Role;
                    //fur stands for form update role (ran out of naming ideas)
                    FormUpdateRole fur = new FormUpdateRole(role.UUID,role.Name, _selectedNode.ParentRoleTreeNode.Text, _selectedNode.isLeader);
                    fur.ModifyItemCallback = new FormUpdateRole.ModifyItemDelegate(this.ModifyItemCallbackFn);
                    fur.ShowDialog();
                }
                if (item.Text == "Add role")
                {
                    _currentSelectedNode = treeViewRole.SelectedNode;
                    if (_currentSelectedNode == null)
                    {
                        textboxAnalyze.Text = "You must select a role node to add a new one. ";
                    }
                    else
                    {
                        RoleTreeNode roleTreeNode = (RoleTreeNode)_currentSelectedNode;
                        string name = roleTreeNode.Role.Name;
                        //textboxAnalyze.Text = "Adding a new role node under " + name;
                        FormAddRole far = new FormAddRole(name);
                        far.AddRoleCallback = AddRoleCallbackFn;
                        far.ShowDialog();
                    }
                    //MessageBox.Show("No modal form created to service the add role operation.");
                }
                if (item.Text == "Remove role")
                {
                    _roleMenu.Visible = false;
                    RoleTreeNode roleTreeNode = (RoleTreeNode)_selectedNode;
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the role?  Child roles will also be deleted.", "Confirm Deletion", MessageBoxButtons.OKCancel);

                    if (dialogResult == DialogResult.OK)
                    {
                        if (roleTreeNode.RemoveMyselfFromParent())
                        {
                            MessageBox.Show("Removed", "Alert");
                            textboxAnalyze.Text = "Role removed";
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete selected role. There are currently employees under the selected role.", "Problem");
                            textboxAnalyze.Text = "Unable to delete selected role. There are currently employees under the selected role.";
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                    }
                    
                    //RoleTreeNode parentSelected = roleTreeNode.ParentRoleTreeNode;
                    //parentSelected.re
                    //MessageBox.Show("Unable to delete selected role. There are currently employees under the selected role.");
                }
            }

        }//end of contextMenu_ItemClicked

        private void ModifyItemCallbackFn(string uuid, string roleName, string parent, bool isLeader)
        {
            List<RoleTreeNode> resultNodes = new List<RoleTreeNode>();
            //Find the RoleTreeNode object which has the role  object containing the matching
            //UUID value.
            _dataManager.RoleTreeStructure.SearchByUUID(uuid, ref resultNodes);
            //By right, there should only be one RoleTreeNode object found. Therefore,
            //I directly point to the first element inside the List to access the Role object's Name and Text property data.
            resultNodes[0].Role.Name = roleName;
            resultNodes[0].Text = roleName;
            resultNodes[0].isLeader = isLeader;

        }//end of ModifyItemCallbackFn method

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            //_dataManager.SaveRoleData();
            _dataManager.SaveEntireData();
            MessageBox.Show("Data saved to file.");
            textboxAnalyze.Text = "Data saved to file.";
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            _selectedNode = (RoleTreeNode)treeViewRole.SelectedNode;
            //Enable all menu items first. Then disable the menu items which are not appropriate
            foreach(ToolStripMenuItem item in _roleMenu.Items)
            {
                item.Enabled = true; 
            }


            if (_selectedNode.Text == "ROOT")
            {
                this._updateMenuItem.Enabled = false;
                this._removeMenuItem.Enabled = false;
            }
            if (_selectedNode.Text != "ROOT")
            {
                
                if (_selectedNode.ChildRoleTreeNodes.Count > 0)
                {
                    this._updateMenuItem.Enabled = true;
                    this._removeMenuItem.Enabled = true;
                    
                }
                if (_selectedNode.ParentRoleTreeNode.isLeader)
                {
                    this._addMenuItem.Enabled = false;
                }
                else
                {
                    this._addMenuItem.Enabled = true;
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            treeViewRole.Nodes.Clear();
            _dataManager.GenerateEmptyTreeStructure();
            treeViewRole.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
        }

        
        private void AddRoleCallbackFn(string parent, string newRoleName, bool isLeader)
        {
            textboxAnalyze.Text = "Role added under: "+parent+"\r\nNew role: "+newRoleName;
            RoleTreeNode roleTreeNode = (RoleTreeNode)_currentSelectedNode; // casting here
            _role = new Role(newRoleName);
            RoleTreeNode tempRole = new RoleTreeNode(_role);
            tempRole.isLeader = isLeader;
            roleTreeNode.AddChildRoleTreeNode(tempRole); // initially cannot access AddChildRoleTreeNode method at first because is a treenode type object,not RoleTreeNode typeobject, must conversion first  
        }

        

        private void treeViewRole_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.IsSelected)
            {
                RoleTreeNode roleTreeNode = (RoleTreeNode)e.Node;
                textBox1.Text = roleTreeNode.Role.UUID;
                textBox2.Text = roleTreeNode.Role.Name;
                checkboxProjectLeader.Checked = roleTreeNode.isLeader;

            }

        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            treeViewRole.ExpandAll();
        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            treeViewRole.CollapseAll();
        }
    }//end of class


}
