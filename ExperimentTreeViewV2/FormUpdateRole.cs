using ExperimentTreeViewV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeViewV2
{
    public partial class FormUpdateRole : Form
    {
        private Role _oneRole;
        public delegate void ModifyItemDelegate(string uuid, string roleName, string parent, bool isLeader);
        public ModifyItemDelegate ModifyItemCallback;
        public FormUpdateRole()
        {
            InitializeComponent();
        }
        //need a constructor which can receive role name input
        public FormUpdateRole(string uuid, string roleName, string parent)
        {

            InitializeComponent();
            this._oneRole = new Role(roleName);
            this._oneRole.Name = roleName;
            this._oneRole.UUID = uuid;
            textboxParent.Text = parent;
        }

        public FormUpdateRole(string uuid, string roleName, string parent, bool isLeader)
        {

            InitializeComponent();
            this._oneRole = new Role(roleName);
            this._oneRole.Name = roleName;
            this._oneRole.UUID = uuid;
            textboxParent.Text = parent;
            checkboxProjectLeader.Checked = isLeader;
        }
        private void FormUpdateRole_Load(object sender, EventArgs e)
        {
            this.textboxRoleName.Text = _oneRole.Name;
            this.textboxUUID.Text = _oneRole.UUID;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {

            string name = textboxRoleName.Text.Trim();
            string uuid = textboxUUID.Text.Trim();
            string parent = textboxParent.Text.Trim();
            if (name != "")
            {
                ModifyItemCallback(uuid, name, parent, checkboxProjectLeader.Checked);
                this.DialogResult = DialogResult.OK;
            }
             else
            {
                MessageBox.Show("Please enter a role name");
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
