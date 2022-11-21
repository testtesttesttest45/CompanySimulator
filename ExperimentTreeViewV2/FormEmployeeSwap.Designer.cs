namespace ExperimentTreeViewV2
{
    partial class FormEmployeeSwap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxReplacing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeViewEmployee2 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textboxProjects = new System.Windows.Forms.TextBox();
            this.textboxRole = new System.Windows.Forms.TextBox();
            this.textboxSalary = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxReportingOfficer = new System.Windows.Forms.TextBox();
            this.textboxUUID = new System.Windows.Forms.TextBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.labelProjects = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelReportingOfficer = new System.Windows.Forms.Label();
            this.labelUUID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "You are replacing";
            // 
            // textboxReplacing
            // 
            this.textboxReplacing.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxReplacing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxReplacing.Enabled = false;
            this.textboxReplacing.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxReplacing.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxReplacing.Location = new System.Drawing.Point(180, 42);
            this.textboxReplacing.Margin = new System.Windows.Forms.Padding(2);
            this.textboxReplacing.Name = "textboxReplacing";
            this.textboxReplacing.Size = new System.Drawing.Size(287, 36);
            this.textboxReplacing.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select employee node to replace with:";
            // 
            // treeViewEmployee2
            // 
            this.treeViewEmployee2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeViewEmployee2.Location = new System.Drawing.Point(22, 113);
            this.treeViewEmployee2.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewEmployee2.Name = "treeViewEmployee2";
            this.treeViewEmployee2.Size = new System.Drawing.Size(438, 413);
            this.treeViewEmployee2.TabIndex = 2;
            this.treeViewEmployee2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmployee2_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.textboxProjects);
            this.groupBox1.Controls.Add(this.textboxRole);
            this.groupBox1.Controls.Add(this.textboxSalary);
            this.groupBox1.Controls.Add(this.textboxName);
            this.groupBox1.Controls.Add(this.textboxReportingOfficer);
            this.groupBox1.Controls.Add(this.textboxUUID);
            this.groupBox1.Controls.Add(this.buttonSwap);
            this.groupBox1.Controls.Add(this.labelProjects);
            this.groupBox1.Controls.Add(this.labelRole);
            this.groupBox1.Controls.Add(this.labelSalary);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelReportingOfficer);
            this.groupBox1.Controls.Add(this.labelUUID);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(481, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(553, 412);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replace With";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Location = new System.Drawing.Point(405, 334);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 39);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textboxProjects
            // 
            this.textboxProjects.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxProjects.Enabled = false;
            this.textboxProjects.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxProjects.Location = new System.Drawing.Point(203, 272);
            this.textboxProjects.Margin = new System.Windows.Forms.Padding(2);
            this.textboxProjects.Name = "textboxProjects";
            this.textboxProjects.Size = new System.Drawing.Size(333, 36);
            this.textboxProjects.TabIndex = 2;
            // 
            // textboxRole
            // 
            this.textboxRole.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxRole.Enabled = false;
            this.textboxRole.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxRole.Location = new System.Drawing.Point(203, 230);
            this.textboxRole.Margin = new System.Windows.Forms.Padding(2);
            this.textboxRole.Name = "textboxRole";
            this.textboxRole.Size = new System.Drawing.Size(333, 36);
            this.textboxRole.TabIndex = 2;
            // 
            // textboxSalary
            // 
            this.textboxSalary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxSalary.Enabled = false;
            this.textboxSalary.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxSalary.Location = new System.Drawing.Point(203, 184);
            this.textboxSalary.Margin = new System.Windows.Forms.Padding(2);
            this.textboxSalary.Name = "textboxSalary";
            this.textboxSalary.Size = new System.Drawing.Size(333, 36);
            this.textboxSalary.TabIndex = 2;
            // 
            // textboxName
            // 
            this.textboxName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxName.Enabled = false;
            this.textboxName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxName.Location = new System.Drawing.Point(203, 139);
            this.textboxName.Margin = new System.Windows.Forms.Padding(2);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(333, 36);
            this.textboxName.TabIndex = 2;
            // 
            // textboxReportingOfficer
            // 
            this.textboxReportingOfficer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxReportingOfficer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxReportingOfficer.Enabled = false;
            this.textboxReportingOfficer.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxReportingOfficer.Location = new System.Drawing.Point(203, 99);
            this.textboxReportingOfficer.Margin = new System.Windows.Forms.Padding(2);
            this.textboxReportingOfficer.Name = "textboxReportingOfficer";
            this.textboxReportingOfficer.Size = new System.Drawing.Size(333, 36);
            this.textboxReportingOfficer.TabIndex = 2;
            // 
            // textboxUUID
            // 
            this.textboxUUID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxUUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxUUID.Enabled = false;
            this.textboxUUID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxUUID.Location = new System.Drawing.Point(203, 55);
            this.textboxUUID.Margin = new System.Windows.Forms.Padding(2);
            this.textboxUUID.Name = "textboxUUID";
            this.textboxUUID.Size = new System.Drawing.Size(333, 36);
            this.textboxUUID.TabIndex = 2;
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.Violet;
            this.buttonSwap.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSwap.Location = new System.Drawing.Point(238, 334);
            this.buttonSwap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(131, 39);
            this.buttonSwap.TabIndex = 1;
            this.buttonSwap.Text = "Swap";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // labelProjects
            // 
            this.labelProjects.AutoSize = true;
            this.labelProjects.Location = new System.Drawing.Point(19, 272);
            this.labelProjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProjects.Name = "labelProjects";
            this.labelProjects.Size = new System.Drawing.Size(94, 29);
            this.labelProjects.TabIndex = 0;
            this.labelProjects.Text = "Projects";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(19, 230);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(58, 29);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Role";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(19, 184);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(111, 29);
            this.labelSalary.TabIndex = 0;
            this.labelSalary.Text = "Salary(S$)";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 139);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelReportingOfficer
            // 
            this.labelReportingOfficer.AutoSize = true;
            this.labelReportingOfficer.Location = new System.Drawing.Point(19, 99);
            this.labelReportingOfficer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReportingOfficer.Name = "labelReportingOfficer";
            this.labelReportingOfficer.Size = new System.Drawing.Size(184, 29);
            this.labelReportingOfficer.TabIndex = 0;
            this.labelReportingOfficer.Text = "Reporting Officer";
            // 
            // labelUUID
            // 
            this.labelUUID.AutoSize = true;
            this.labelUUID.Location = new System.Drawing.Point(19, 55);
            this.labelUUID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(66, 29);
            this.labelUUID.TabIndex = 0;
            this.labelUUID.Text = "UUID";
            // 
            // FormEmployeeSwap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeViewEmployee2);
            this.Controls.Add(this.textboxReplacing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployeeSwap";
            this.Text = "FormEmployeeSwap";
            this.Load += new System.EventHandler(this.FormEmployeeSwap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxReplacing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeViewEmployee2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxProjects;
        private System.Windows.Forms.TextBox textboxRole;
        private System.Windows.Forms.TextBox textboxSalary;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxReportingOfficer;
        private System.Windows.Forms.TextBox textboxUUID;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Label labelProjects;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelReportingOfficer;
        private System.Windows.Forms.Label labelUUID;
        private System.Windows.Forms.Button buttonCancel;
    }
}