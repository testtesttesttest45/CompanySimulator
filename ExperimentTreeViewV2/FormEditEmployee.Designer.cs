namespace ExperimentTreeViewV2
{
    partial class FormEditEmployee
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textboxUUID = new System.Windows.Forms.TextBox();
            this.textboxReportingOfficer = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxSalary = new System.Windows.Forms.TextBox();
            this.textboxRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Employee Details";
            // 
            // labelUUID
            // 
            this.labelUUID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUUID.Location = new System.Drawing.Point(22, 66);
            this.labelUUID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(77, 30);
            this.labelUUID.TabIndex = 0;
            this.labelUUID.Text = "UUID";
            // 
            // labelReportingOfficer
            // 
            this.labelReportingOfficer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReportingOfficer.Location = new System.Drawing.Point(22, 106);
            this.labelReportingOfficer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReportingOfficer.Name = "labelReportingOfficer";
            this.labelReportingOfficer.Size = new System.Drawing.Size(196, 30);
            this.labelReportingOfficer.TabIndex = 0;
            this.labelReportingOfficer.Text = "Reporting Officer";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(22, 150);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 30);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelSalary
            // 
            this.labelSalary.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalary.Location = new System.Drawing.Point(22, 194);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(135, 30);
            this.labelSalary.TabIndex = 0;
            this.labelSalary.Text = "Salary(S$)";
            // 
            // labelRole
            // 
            this.labelRole.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRole.Location = new System.Drawing.Point(22, 236);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(77, 30);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Role";
            // 
            // checkboxDummy
            // 
            this.checkboxDummy.AutoSize = true;
            this.checkboxDummy.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkboxDummy.Location = new System.Drawing.Point(22, 286);
            this.checkboxDummy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkboxDummy.Name = "checkboxDummy";
            this.checkboxDummy.Size = new System.Drawing.Size(177, 33);
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
            this.checkboxSalary.Location = new System.Drawing.Point(260, 286);
            this.checkboxSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkboxSalary.Name = "checkboxSalary";
            this.checkboxSalary.Size = new System.Drawing.Size(237, 33);
            this.checkboxSalary.TabIndex = 1;
            this.checkboxSalary.Text = "Salary Accountable?";
            this.checkboxSalary.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Location = new System.Drawing.Point(337, 322);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(186, 46);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEdit.Location = new System.Drawing.Point(46, 330);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(186, 46);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textboxUUID
            // 
            this.textboxUUID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxUUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxUUID.Enabled = false;
            this.textboxUUID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxUUID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxUUID.Location = new System.Drawing.Point(204, 62);
            this.textboxUUID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxUUID.Name = "textboxUUID";
            this.textboxUUID.Size = new System.Drawing.Size(338, 36);
            this.textboxUUID.TabIndex = 3;
            // 
            // textboxReportingOfficer
            // 
            this.textboxReportingOfficer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxReportingOfficer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxReportingOfficer.Enabled = false;
            this.textboxReportingOfficer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxReportingOfficer.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxReportingOfficer.Location = new System.Drawing.Point(204, 104);
            this.textboxReportingOfficer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxReportingOfficer.Name = "textboxReportingOfficer";
            this.textboxReportingOfficer.Size = new System.Drawing.Size(338, 36);
            this.textboxReportingOfficer.TabIndex = 3;
            // 
            // textboxName
            // 
            this.textboxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxName.Location = new System.Drawing.Point(204, 147);
            this.textboxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(338, 36);
            this.textboxName.TabIndex = 3;
            // 
            // textboxSalary
            // 
            this.textboxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxSalary.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxSalary.Location = new System.Drawing.Point(204, 191);
            this.textboxSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxSalary.Name = "textboxSalary";
            this.textboxSalary.Size = new System.Drawing.Size(338, 36);
            this.textboxSalary.TabIndex = 3;
            // 
            // textboxRole
            // 
            this.textboxRole.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxRole.Enabled = false;
            this.textboxRole.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxRole.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxRole.Location = new System.Drawing.Point(204, 233);
            this.textboxRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxRole.Name = "textboxRole";
            this.textboxRole.Size = new System.Drawing.Size(338, 36);
            this.textboxRole.TabIndex = 3;
            // 
            // FormEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 386);
            this.Controls.Add(this.textboxRole);
            this.Controls.Add(this.textboxSalary);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.textboxReportingOfficer);
            this.Controls.Add(this.textboxUUID);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkboxSalary);
            this.Controls.Add(this.checkboxDummy);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelReportingOfficer);
            this.Controls.Add(this.labelUUID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEditEmployee";
            this.Text = "FormEditEmployee";
            this.Load += new System.EventHandler(this.FormEditEmployee_Load);
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
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textboxUUID;
        private System.Windows.Forms.TextBox textboxReportingOfficer;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxSalary;
        private System.Windows.Forms.TextBox textboxRole;
    }
}