namespace ExperimentTreeViewV2
{
    partial class FormAddRole
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
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelParent = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Role";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parent Role";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(44, 214);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(240, 33);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Project Leader Role?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(54, 270);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(165, 43);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(414, 270);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(165, 43);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelParent
            // 
            this.labelParent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelParent.Enabled = false;
            this.labelParent.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelParent.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelParent.Location = new System.Drawing.Point(274, 108);
            this.labelParent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(336, 36);
            this.labelParent.TabIndex = 3;
            // 
            // textboxName
            // 
            this.textboxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textboxName.Location = new System.Drawing.Point(274, 162);
            this.textboxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(336, 36);
            this.textboxName.TabIndex = 3;
            // 
            // FormAddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelParent);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddRole";
            this.Text = "FormAddRole";
            this.Load += new System.EventHandler(this.FormAddRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox labelParent;
        private System.Windows.Forms.TextBox textboxName;
    }
}