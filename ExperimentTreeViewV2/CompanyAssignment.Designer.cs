namespace ExperimentTreeViewV2
{
    partial class CompanyAssignment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripManageRole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripManageEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripManageProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolstrip
            // 
            this.toolstrip.BackColor = System.Drawing.Color.LightGreen;
            this.toolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripManageRole,
            this.toolstripManageEmployee,
            this.toolstripManageProject});
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(210, 33);
            this.toolstrip.Text = "Choose forms here";
            // 
            // toolstripManageRole
            // 
            this.toolstripManageRole.Name = "toolstripManageRole";
            this.toolstripManageRole.Size = new System.Drawing.Size(284, 34);
            this.toolstripManageRole.Text = "Manage Role";
            this.toolstripManageRole.Click += new System.EventHandler(this.toolstripManageRole_Click);
            // 
            // toolstripManageEmployee
            // 
            this.toolstripManageEmployee.Name = "toolstripManageEmployee";
            this.toolstripManageEmployee.Size = new System.Drawing.Size(284, 34);
            this.toolstripManageEmployee.Text = "Manage Employee";
            this.toolstripManageEmployee.Click += new System.EventHandler(this.toolstripManageEmployee_Click);
            // 
            // toolstripManageProject
            // 
            this.toolstripManageProject.Name = "toolstripManageProject";
            this.toolstripManageProject.Size = new System.Drawing.Size(284, 34);
            this.toolstripManageProject.Text = "Manage Project";
            this.toolstripManageProject.Click += new System.EventHandler(this.toolstripManageProject_Click);
            // 
            // CompanyAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CompanyAssignment";
            this.Text = "CompanyAssignment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolstrip;
        private System.Windows.Forms.ToolStripMenuItem toolstripManageRole;
        private System.Windows.Forms.ToolStripMenuItem toolstripManageEmployee;
        private System.Windows.Forms.ToolStripMenuItem toolstripManageProject;
    }
}