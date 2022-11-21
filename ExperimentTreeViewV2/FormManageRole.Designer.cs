namespace ExperimentTreeViewV2
{
    partial class FormManageRole
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
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.treeViewRole = new System.Windows.Forms.TreeView();
            this.textboxAnalyze = new System.Windows.Forms.TextBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkboxProjectLeader = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLoadFromFile.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadFromFile.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLoadFromFile.Location = new System.Drawing.Point(286, 346);
            this.buttonLoadFromFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(117, 37);
            this.buttonLoadFromFile.TabIndex = 13;
            this.buttonLoadFromFile.Text = "Load";
            this.buttonLoadFromFile.UseVisualStyleBackColor = false;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // treeViewRole
            // 
            this.treeViewRole.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeViewRole.Location = new System.Drawing.Point(478, 100);
            this.treeViewRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeViewRole.Name = "treeViewRole";
            this.treeViewRole.Size = new System.Drawing.Size(962, 690);
            this.treeViewRole.TabIndex = 12;
            this.treeViewRole.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRole_AfterSelect);
            // 
            // textboxAnalyze
            // 
            this.textboxAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxAnalyze.Enabled = false;
            this.textboxAnalyze.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxAnalyze.Location = new System.Drawing.Point(10, 473);
            this.textboxAnalyze.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxAnalyze.Multiline = true;
            this.textboxAnalyze.Name = "textboxAnalyze";
            this.textboxAnalyze.Size = new System.Drawing.Size(454, 285);
            this.textboxAnalyze.TabIndex = 11;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSaveToFile.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveToFile.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveToFile.Location = new System.Drawing.Point(151, 346);
            this.buttonSaveToFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(122, 37);
            this.buttonSaveToFile.TabIndex = 14;
            this.buttonSaveToFile.Text = "Save";
            this.buttonSaveToFile.UseVisualStyleBackColor = false;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReset.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReset.Location = new System.Drawing.Point(17, 346);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(127, 37);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Console";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkboxProjectLeader);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(447, 273);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Role Node Information";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(159, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Read-only";
            // 
            // checkboxProjectLeader
            // 
            this.checkboxProjectLeader.AutoSize = true;
            this.checkboxProjectLeader.Enabled = false;
            this.checkboxProjectLeader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkboxProjectLeader.Location = new System.Drawing.Point(41, 166);
            this.checkboxProjectLeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkboxProjectLeader.Name = "checkboxProjectLeader";
            this.checkboxProjectLeader.Size = new System.Drawing.Size(235, 33);
            this.checkboxProjectLeader.TabIndex = 2;
            this.checkboxProjectLeader.Text = "Project Leader role?";
            this.checkboxProjectLeader.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.Location = new System.Drawing.Point(169, 108);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 36);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Location = new System.Drawing.Point(169, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 36);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "UUID";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(478, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Role Node Tree View";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(478, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(593, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Right click to perform actions such as edit, remove or add roles. ";
            // 
            // buttonExpand
            // 
            this.buttonExpand.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExpand.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExpand.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExpand.Location = new System.Drawing.Point(1127, 55);
            this.buttonExpand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(147, 38);
            this.buttonExpand.TabIndex = 19;
            this.buttonExpand.Text = "Expand All";
            this.buttonExpand.UseVisualStyleBackColor = false;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCollapse.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCollapse.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCollapse.Location = new System.Drawing.Point(1278, 55);
            this.buttonCollapse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(162, 38);
            this.buttonCollapse.TabIndex = 19;
            this.buttonCollapse.Text = "Collapse All";
            this.buttonCollapse.UseVisualStyleBackColor = false;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // FormManageRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 790);
            this.Controls.Add(this.buttonCollapse);
            this.Controls.Add(this.buttonExpand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.treeViewRole);
            this.Controls.Add(this.textboxAnalyze);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormManageRole";
            this.Text = "Manage_Roles";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.TreeView treeViewRole;
        private System.Windows.Forms.TextBox textboxAnalyze;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkboxProjectLeader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Button buttonCollapse;
    }
}