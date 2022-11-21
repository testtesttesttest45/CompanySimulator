namespace ExperimentTreeViewV2
{
    partial class FormUpdateRole
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
            this.textboxRoleName = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkboxProjectLeader = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textboxUUID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxParent = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxRoleName
            // 
            this.textboxRoleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxRoleName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxRoleName.Location = new System.Drawing.Point(217, 131);
            this.textboxRoleName.Name = "textboxRoleName";
            this.textboxRoleName.Size = new System.Drawing.Size(510, 42);
            this.textboxRoleName.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonEdit.Location = new System.Drawing.Point(46, 309);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(272, 56);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkboxProjectLeader);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.textboxUUID);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textboxParent);
            this.groupBox1.Controls.Add(this.textboxRoleName);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 399);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update role";
            // 
            // checkboxProjectLeader
            // 
            this.checkboxProjectLeader.AutoSize = true;
            this.checkboxProjectLeader.Location = new System.Drawing.Point(38, 250);
            this.checkboxProjectLeader.Name = "checkboxProjectLeader";
            this.checkboxProjectLeader.Size = new System.Drawing.Size(280, 39);
            this.checkboxProjectLeader.TabIndex = 9;
            this.checkboxProjectLeader.Text = "Project Leader Role?";
            this.checkboxProjectLeader.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "UUID";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCancel.Location = new System.Drawing.Point(360, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(271, 56);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textboxUUID
            // 
            this.textboxUUID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textboxUUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxUUID.Enabled = false;
            this.textboxUUID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxUUID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxUUID.Location = new System.Drawing.Point(217, 68);
            this.textboxUUID.Name = "textboxUUID";
            this.textboxUUID.Size = new System.Drawing.Size(510, 42);
            this.textboxUUID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parent Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // textboxParent
            // 
            this.textboxParent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textboxParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxParent.Enabled = false;
            this.textboxParent.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxParent.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxParent.Location = new System.Drawing.Point(217, 192);
            this.textboxParent.Name = "textboxParent";
            this.textboxParent.Size = new System.Drawing.Size(510, 42);
            this.textboxParent.TabIndex = 0;
            // 
            // FormUpdateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 522);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUpdateRole";
            this.Text = "FormUpdateRole";
            this.Load += new System.EventHandler(this.FormUpdateRole_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textboxRoleName;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxUUID;
        private System.Windows.Forms.CheckBox checkboxProjectLeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxParent;
    }
}