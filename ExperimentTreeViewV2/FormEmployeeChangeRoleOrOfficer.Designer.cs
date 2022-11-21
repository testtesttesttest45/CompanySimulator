namespace ExperimentTreeViewV2
{
    partial class FormEmployeeChangeRoleOrOfficer
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
            this.labelUUID = new System.Windows.Forms.Label();
            this.labelReportingOfficer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.checkboxDummy = new System.Windows.Forms.CheckBox();
            this.checkboxSalary = new System.Windows.Forms.CheckBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textboxUUID = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxSalary = new System.Windows.Forms.TextBox();
            this.comboboxReportingOfficer = new System.Windows.Forms.ComboBox();
            this.comboboxRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Role and/or Reporting Officer";
            // 
            // labelUUID
            // 
            this.labelUUID.AutoSize = true;
            this.labelUUID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUUID.Location = new System.Drawing.Point(33, 89);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(76, 35);
            this.labelUUID.TabIndex = 0;
            this.labelUUID.Text = "UUID";
            // 
            // labelReportingOfficer
            // 
            this.labelReportingOfficer.AutoSize = true;
            this.labelReportingOfficer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReportingOfficer.Location = new System.Drawing.Point(33, 145);
            this.labelReportingOfficer.Name = "labelReportingOfficer";
            this.labelReportingOfficer.Size = new System.Drawing.Size(213, 35);
            this.labelReportingOfficer.TabIndex = 0;
            this.labelReportingOfficer.Text = "Reporting Officer";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(33, 196);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 35);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalary.Location = new System.Drawing.Point(33, 247);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(131, 35);
            this.labelSalary.TabIndex = 0;
            this.labelSalary.Text = "Salary(S$)";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRole.Location = new System.Drawing.Point(33, 301);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(67, 35);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Role";
            // 
            // checkboxDummy
            // 
            this.checkboxDummy.AutoSize = true;
            this.checkboxDummy.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkboxDummy.Location = new System.Drawing.Point(39, 366);
            this.checkboxDummy.Name = "checkboxDummy";
            this.checkboxDummy.Size = new System.Drawing.Size(207, 39);
            this.checkboxDummy.TabIndex = 1;
            this.checkboxDummy.Text = "Dummy Data?";
            this.checkboxDummy.UseVisualStyleBackColor = true;
            // 
            // checkboxSalary
            // 
            this.checkboxSalary.AutoSize = true;
            this.checkboxSalary.Checked = true;
            this.checkboxSalary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxSalary.Enabled = false;
            this.checkboxSalary.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkboxSalary.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkboxSalary.Location = new System.Drawing.Point(398, 366);
            this.checkboxSalary.Name = "checkboxSalary";
            this.checkboxSalary.Size = new System.Drawing.Size(277, 39);
            this.checkboxSalary.TabIndex = 1;
            this.checkboxSalary.Text = "Salary Accountable?";
            this.checkboxSalary.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonChange.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChange.ForeColor = System.Drawing.Color.Transparent;
            this.buttonChange.Location = new System.Drawing.Point(70, 411);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(225, 43);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Location = new System.Drawing.Point(398, 411);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(225, 43);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textboxUUID
            // 
            this.textboxUUID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxUUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxUUID.Enabled = false;
            this.textboxUUID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxUUID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxUUID.Location = new System.Drawing.Point(252, 89);
            this.textboxUUID.Name = "textboxUUID";
            this.textboxUUID.Size = new System.Drawing.Size(423, 42);
            this.textboxUUID.TabIndex = 3;
            // 
            // textboxName
            // 
            this.textboxName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxName.Enabled = false;
            this.textboxName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxName.Location = new System.Drawing.Point(252, 196);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(423, 42);
            this.textboxName.TabIndex = 3;
            // 
            // textboxSalary
            // 
            this.textboxSalary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxSalary.Enabled = false;
            this.textboxSalary.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxSalary.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxSalary.Location = new System.Drawing.Point(252, 247);
            this.textboxSalary.Name = "textboxSalary";
            this.textboxSalary.Size = new System.Drawing.Size(423, 42);
            this.textboxSalary.TabIndex = 3;
            // 
            // comboboxReportingOfficer
            // 
            this.comboboxReportingOfficer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboboxReportingOfficer.FormattingEnabled = true;
            this.comboboxReportingOfficer.Location = new System.Drawing.Point(252, 145);
            this.comboboxReportingOfficer.Name = "comboboxReportingOfficer";
            this.comboboxReportingOfficer.Size = new System.Drawing.Size(423, 43);
            this.comboboxReportingOfficer.TabIndex = 4;
            // 
            // comboboxRole
            // 
            this.comboboxRole.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboboxRole.FormattingEnabled = true;
            this.comboboxRole.Location = new System.Drawing.Point(252, 301);
            this.comboboxRole.Name = "comboboxRole";
            this.comboboxRole.Size = new System.Drawing.Size(423, 43);
            this.comboboxRole.TabIndex = 4;
            // 
            // FormEmployeeChangeRoleOrOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 482);
            this.Controls.Add(this.comboboxRole);
            this.Controls.Add(this.comboboxReportingOfficer);
            this.Controls.Add(this.textboxSalary);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.textboxUUID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.checkboxSalary);
            this.Controls.Add(this.checkboxDummy);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelReportingOfficer);
            this.Controls.Add(this.labelUUID);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployeeChangeRoleOrOfficer";
            this.Text = "FormEmployeeChangeRoleOrOfficer";
            this.Load += new System.EventHandler(this.FormEmployeeChangeRoleOrOfficer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUUID;
        private System.Windows.Forms.Label labelReportingOfficer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.CheckBox checkboxDummy;
        private System.Windows.Forms.CheckBox checkboxSalary;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textboxUUID;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxSalary;
        private System.Windows.Forms.ComboBox comboboxReportingOfficer;
        private System.Windows.Forms.ComboBox comboboxRole;
    }
}