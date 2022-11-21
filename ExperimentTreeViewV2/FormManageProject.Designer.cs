namespace ExperimentTreeViewV2
{
    partial class FormManageProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelEmployeeTreeView = new System.Windows.Forms.Label();
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.groupboxAddProject = new System.Windows.Forms.GroupBox();
            this.comboboxTeamLeader = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textboxRevenue = new System.Windows.Forms.TextBox();
            this.textboxProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStep3 = new System.Windows.Forms.Label();
            this.labelStep2 = new System.Windows.Forms.Label();
            this.labelStep1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxEditProject = new System.Windows.Forms.GroupBox();
            this.comboboxTeamLeader2 = new System.Windows.Forms.ComboBox();
            this.textboxRevenue2 = new System.Windows.Forms.TextBox();
            this.textboxProjectName2 = new System.Windows.Forms.TextBox();
            this.textboxUUID = new System.Windows.Forms.TextBox();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelTeamLeader2 = new System.Windows.Forms.Label();
            this.labelRevenue2 = new System.Windows.Forms.Label();
            this.labelProjectName2 = new System.Windows.Forms.Label();
            this.labelUUID = new System.Windows.Forms.Label();
            this.labelConsole = new System.Windows.Forms.Label();
            this.textboxAnalyze = new System.Windows.Forms.TextBox();
            this.labelProjectList = new System.Windows.Forms.Label();
            this.comboboxMode = new System.Windows.Forms.ComboBox();
            this.listViewProject = new System.Windows.Forms.ListView();
            this.groupboxAddProject.SuspendLayout();
            this.groupboxEditProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(206, 20);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(148, 39);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReset.Location = new System.Drawing.Point(10, 20);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(148, 39);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Location = new System.Drawing.Point(359, 20);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(148, 39);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.BackColor = System.Drawing.Color.Khaki;
            this.buttonExpand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExpand.Location = new System.Drawing.Point(256, 68);
            this.buttonExpand.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(123, 36);
            this.buttonExpand.TabIndex = 0;
            this.buttonExpand.Text = "Expand All";
            this.buttonExpand.UseVisualStyleBackColor = false;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.BackColor = System.Drawing.Color.Moccasin;
            this.buttonCollapse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCollapse.Location = new System.Drawing.Point(384, 68);
            this.buttonCollapse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(123, 36);
            this.buttonCollapse.TabIndex = 0;
            this.buttonCollapse.Text = "Collapse All";
            this.buttonCollapse.UseVisualStyleBackColor = false;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // labelMode
            // 
            this.labelMode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMode.Location = new System.Drawing.Point(1242, 33);
            this.labelMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(63, 30);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Mode:";
            // 
            // labelEmployeeTreeView
            // 
            this.labelEmployeeTreeView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeTreeView.Location = new System.Drawing.Point(10, 95);
            this.labelEmployeeTreeView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeTreeView.Name = "labelEmployeeTreeView";
            this.labelEmployeeTreeView.Size = new System.Drawing.Size(192, 36);
            this.labelEmployeeTreeView.TabIndex = 1;
            this.labelEmployeeTreeView.Text = "Employee Tree View";
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeViewEmployee.Location = new System.Drawing.Point(10, 125);
            this.treeViewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(498, 656);
            this.treeViewEmployee.TabIndex = 2;
            // 
            // groupboxAddProject
            // 
            this.groupboxAddProject.Controls.Add(this.comboboxTeamLeader);
            this.groupboxAddProject.Controls.Add(this.buttonAdd);
            this.groupboxAddProject.Controls.Add(this.buttonCancel);
            this.groupboxAddProject.Controls.Add(this.buttonSearch);
            this.groupboxAddProject.Controls.Add(this.textboxRevenue);
            this.groupboxAddProject.Controls.Add(this.textboxProjectName);
            this.groupboxAddProject.Controls.Add(this.label3);
            this.groupboxAddProject.Controls.Add(this.labelStep3);
            this.groupboxAddProject.Controls.Add(this.labelStep2);
            this.groupboxAddProject.Controls.Add(this.labelStep1);
            this.groupboxAddProject.Controls.Add(this.label13);
            this.groupboxAddProject.Controls.Add(this.label12);
            this.groupboxAddProject.Controls.Add(this.label11);
            this.groupboxAddProject.Controls.Add(this.label2);
            this.groupboxAddProject.Controls.Add(this.label1);
            this.groupboxAddProject.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupboxAddProject.Location = new System.Drawing.Point(525, 68);
            this.groupboxAddProject.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxAddProject.Name = "groupboxAddProject";
            this.groupboxAddProject.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxAddProject.Size = new System.Drawing.Size(455, 440);
            this.groupboxAddProject.TabIndex = 3;
            this.groupboxAddProject.TabStop = false;
            this.groupboxAddProject.Text = "Add New Project";
            // 
            // comboboxTeamLeader
            // 
            this.comboboxTeamLeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTeamLeader.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboboxTeamLeader.FormattingEnabled = true;
            this.comboboxTeamLeader.Location = new System.Drawing.Point(152, 328);
            this.comboboxTeamLeader.Name = "comboboxTeamLeader";
            this.comboboxTeamLeader.Size = new System.Drawing.Size(270, 36);
            this.comboboxTeamLeader.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(305, 369);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 57);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Confirm Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(161, 369);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(139, 57);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(17, 369);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 57);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search For Teams";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textboxRevenue
            // 
            this.textboxRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxRevenue.Enabled = false;
            this.textboxRevenue.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxRevenue.Location = new System.Drawing.Point(152, 266);
            this.textboxRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.textboxRevenue.Name = "textboxRevenue";
            this.textboxRevenue.Size = new System.Drawing.Size(270, 36);
            this.textboxRevenue.TabIndex = 2;
            // 
            // textboxProjectName
            // 
            this.textboxProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxProjectName.Enabled = false;
            this.textboxProjectName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxProjectName.Location = new System.Drawing.Point(152, 206);
            this.textboxProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.textboxProjectName.Name = "textboxProjectName";
            this.textboxProjectName.Size = new System.Drawing.Size(270, 36);
            this.textboxProjectName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Step 3";
            // 
            // labelStep3
            // 
            this.labelStep3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStep3.Location = new System.Drawing.Point(92, 158);
            this.labelStep3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep3.Name = "labelStep3";
            this.labelStep3.Size = new System.Drawing.Size(273, 30);
            this.labelStep3.TabIndex = 1;
            this.labelStep3.Text = "Click the \"Confirm Add\"  button";
            // 
            // labelStep2
            // 
            this.labelStep2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStep2.Location = new System.Drawing.Point(92, 94);
            this.labelStep2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep2.Name = "labelStep2";
            this.labelStep2.Size = new System.Drawing.Size(343, 71);
            this.labelStep2.TabIndex = 1;
            this.labelStep2.Text = "Select team leader via the dropdown(Highlighted in Employee Tree View)";
            // 
            // labelStep1
            // 
            this.labelStep1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStep1.Location = new System.Drawing.Point(92, 41);
            this.labelStep1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(343, 44);
            this.labelStep1.TabIndex = 1;
            this.labelStep1.Text = "Enter project name and revenue, then click on the \"Search For Teams\" button";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(17, 327);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "Team Leader";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(17, 270);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 30);
            this.label12.TabIndex = 1;
            this.label12.Text = "Revenue(S$)";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(17, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step 2:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Step 1: ";
            // 
            // groupboxEditProject
            // 
            this.groupboxEditProject.Controls.Add(this.comboboxTeamLeader2);
            this.groupboxEditProject.Controls.Add(this.textboxRevenue2);
            this.groupboxEditProject.Controls.Add(this.textboxProjectName2);
            this.groupboxEditProject.Controls.Add(this.textboxUUID);
            this.groupboxEditProject.Controls.Add(this.buttonSearch2);
            this.groupboxEditProject.Controls.Add(this.buttonEdit);
            this.groupboxEditProject.Controls.Add(this.buttonDelete);
            this.groupboxEditProject.Controls.Add(this.labelTeamLeader2);
            this.groupboxEditProject.Controls.Add(this.labelRevenue2);
            this.groupboxEditProject.Controls.Add(this.labelProjectName2);
            this.groupboxEditProject.Controls.Add(this.labelUUID);
            this.groupboxEditProject.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupboxEditProject.Location = new System.Drawing.Point(1003, 68);
            this.groupboxEditProject.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxEditProject.Name = "groupboxEditProject";
            this.groupboxEditProject.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxEditProject.Size = new System.Drawing.Size(453, 306);
            this.groupboxEditProject.TabIndex = 4;
            this.groupboxEditProject.TabStop = false;
            this.groupboxEditProject.Text = "View/Edit Project";
            // 
            // comboboxTeamLeader2
            // 
            this.comboboxTeamLeader2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTeamLeader2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboboxTeamLeader2.FormattingEnabled = true;
            this.comboboxTeamLeader2.Location = new System.Drawing.Point(172, 189);
            this.comboboxTeamLeader2.Name = "comboboxTeamLeader2";
            this.comboboxTeamLeader2.Size = new System.Drawing.Size(270, 36);
            this.comboboxTeamLeader2.TabIndex = 3;
            // 
            // textboxRevenue2
            // 
            this.textboxRevenue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxRevenue2.Enabled = false;
            this.textboxRevenue2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxRevenue2.Location = new System.Drawing.Point(172, 136);
            this.textboxRevenue2.Margin = new System.Windows.Forms.Padding(2);
            this.textboxRevenue2.Name = "textboxRevenue2";
            this.textboxRevenue2.Size = new System.Drawing.Size(265, 36);
            this.textboxRevenue2.TabIndex = 2;
            // 
            // textboxProjectName2
            // 
            this.textboxProjectName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxProjectName2.Enabled = false;
            this.textboxProjectName2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxProjectName2.Location = new System.Drawing.Point(172, 86);
            this.textboxProjectName2.Margin = new System.Windows.Forms.Padding(2);
            this.textboxProjectName2.Name = "textboxProjectName2";
            this.textboxProjectName2.Size = new System.Drawing.Size(265, 36);
            this.textboxProjectName2.TabIndex = 2;
            // 
            // textboxUUID
            // 
            this.textboxUUID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxUUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxUUID.Enabled = false;
            this.textboxUUID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxUUID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxUUID.Location = new System.Drawing.Point(172, 38);
            this.textboxUUID.Margin = new System.Windows.Forms.Padding(2);
            this.textboxUUID.Name = "textboxUUID";
            this.textboxUUID.Size = new System.Drawing.Size(265, 36);
            this.textboxUUID.TabIndex = 2;
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSearch2.Enabled = false;
            this.buttonSearch2.Location = new System.Drawing.Point(15, 235);
            this.buttonSearch2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(139, 57);
            this.buttonSearch2.TabIndex = 1;
            this.buttonSearch2.Text = "Search For Teams";
            this.buttonSearch2.UseVisualStyleBackColor = false;
            this.buttonSearch2.Click += new System.EventHandler(this.buttonSearch2_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(159, 235);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(139, 57);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Confirm Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(303, 235);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 57);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelTeamLeader2
            // 
            this.labelTeamLeader2.AutoSize = true;
            this.labelTeamLeader2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTeamLeader2.Location = new System.Drawing.Point(15, 189);
            this.labelTeamLeader2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTeamLeader2.Name = "labelTeamLeader2";
            this.labelTeamLeader2.Size = new System.Drawing.Size(115, 24);
            this.labelTeamLeader2.TabIndex = 0;
            this.labelTeamLeader2.Text = "Team Leader";
            // 
            // labelRevenue2
            // 
            this.labelRevenue2.AutoSize = true;
            this.labelRevenue2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRevenue2.Location = new System.Drawing.Point(15, 136);
            this.labelRevenue2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRevenue2.Name = "labelRevenue2";
            this.labelRevenue2.Size = new System.Drawing.Size(113, 24);
            this.labelRevenue2.TabIndex = 0;
            this.labelRevenue2.Text = "Revenue(S$)";
            // 
            // labelProjectName2
            // 
            this.labelProjectName2.AutoSize = true;
            this.labelProjectName2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProjectName2.Location = new System.Drawing.Point(15, 86);
            this.labelProjectName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProjectName2.Name = "labelProjectName2";
            this.labelProjectName2.Size = new System.Drawing.Size(123, 24);
            this.labelProjectName2.TabIndex = 0;
            this.labelProjectName2.Text = "Project Name";
            // 
            // labelUUID
            // 
            this.labelUUID.AutoSize = true;
            this.labelUUID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUUID.Location = new System.Drawing.Point(15, 40);
            this.labelUUID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(54, 24);
            this.labelUUID.TabIndex = 0;
            this.labelUUID.Text = "UUID";
            // 
            // labelConsole
            // 
            this.labelConsole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConsole.Location = new System.Drawing.Point(525, 510);
            this.labelConsole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(98, 38);
            this.labelConsole.TabIndex = 5;
            this.labelConsole.Text = "Console";
            // 
            // textboxAnalyze
            // 
            this.textboxAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxAnalyze.Enabled = false;
            this.textboxAnalyze.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxAnalyze.Location = new System.Drawing.Point(525, 536);
            this.textboxAnalyze.Margin = new System.Windows.Forms.Padding(2);
            this.textboxAnalyze.Multiline = true;
            this.textboxAnalyze.Name = "textboxAnalyze";
            this.textboxAnalyze.Size = new System.Drawing.Size(456, 244);
            this.textboxAnalyze.TabIndex = 6;
            // 
            // labelProjectList
            // 
            this.labelProjectList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProjectList.Location = new System.Drawing.Point(1003, 393);
            this.labelProjectList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProjectList.Name = "labelProjectList";
            this.labelProjectList.Size = new System.Drawing.Size(110, 30);
            this.labelProjectList.TabIndex = 5;
            this.labelProjectList.Text = "Project List";
            // 
            // comboboxMode
            // 
            this.comboboxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxMode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxMode.FormattingEnabled = true;
            this.comboboxMode.Items.AddRange(new object[] {
            "View",
            "Add",
            "Edit"});
            this.comboboxMode.Location = new System.Drawing.Point(1310, 33);
            this.comboboxMode.Margin = new System.Windows.Forms.Padding(2);
            this.comboboxMode.Name = "comboboxMode";
            this.comboboxMode.Size = new System.Drawing.Size(146, 29);
            this.comboboxMode.TabIndex = 7;
            this.comboboxMode.SelectedValueChanged += new System.EventHandler(this.comboboxMode_SelectedValueChanged);
            // 
            // listViewProject
            // 
            this.listViewProject.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewProject.HideSelection = false;
            this.listViewProject.Location = new System.Drawing.Point(1003, 437);
            this.listViewProject.Name = "listViewProject";
            this.listViewProject.Size = new System.Drawing.Size(503, 344);
            this.listViewProject.TabIndex = 8;
            this.listViewProject.UseCompatibleStateImageBehavior = false;
            this.listViewProject.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewProject_ItemSelectionChanged);
            // 
            // FormManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 790);
            this.Controls.Add(this.listViewProject);
            this.Controls.Add(this.comboboxMode);
            this.Controls.Add(this.textboxAnalyze);
            this.Controls.Add(this.labelProjectList);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.groupboxEditProject);
            this.Controls.Add(this.groupboxAddProject);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.labelEmployeeTreeView);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonCollapse);
            this.Controls.Add(this.buttonExpand);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManageProject";
            this.Text = "FormManageProject";
            this.Load += new System.EventHandler(this.FormManageProject_Load);
            this.groupboxAddProject.ResumeLayout(false);
            this.groupboxAddProject.PerformLayout();
            this.groupboxEditProject.ResumeLayout(false);
            this.groupboxEditProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelEmployeeTreeView;
        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.GroupBox groupboxAddProject;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStep3;
        private System.Windows.Forms.Label labelStep2;
        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupboxEditProject;
        private System.Windows.Forms.TextBox textboxRevenue2;
        private System.Windows.Forms.TextBox textboxProjectName2;
        private System.Windows.Forms.TextBox textboxUUID;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelTeamLeader2;
        private System.Windows.Forms.Label labelRevenue2;
        private System.Windows.Forms.Label labelProjectName2;
        private System.Windows.Forms.Label labelUUID;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.TextBox textboxAnalyze;
        private System.Windows.Forms.Label labelProjectList;
        private System.Windows.Forms.TextBox textboxRevenue;
        private System.Windows.Forms.TextBox textboxProjectName;
        private System.Windows.Forms.ComboBox comboboxMode;
        private System.Windows.Forms.ComboBox comboboxTeamLeader;
        private System.Windows.Forms.ComboBox comboboxTeamLeader2;
        private System.Windows.Forms.ListView listViewProject;
    }
}