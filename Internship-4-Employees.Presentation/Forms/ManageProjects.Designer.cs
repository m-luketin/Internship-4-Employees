namespace Internship_4_Employees.Forms
{
    partial class ManageProjects
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
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.EditProjectButton = new System.Windows.Forms.Button();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.ViewEmployeesButton = new System.Windows.Forms.Button();
            this.ProjectListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Location = new System.Drawing.Point(381, 143);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(99, 74);
            this.DeleteProjectButton.TabIndex = 0;
            this.DeleteProjectButton.Text = "Delete";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // EditProjectButton
            // 
            this.EditProjectButton.Location = new System.Drawing.Point(381, 235);
            this.EditProjectButton.Name = "EditProjectButton";
            this.EditProjectButton.Size = new System.Drawing.Size(99, 74);
            this.EditProjectButton.TabIndex = 1;
            this.EditProjectButton.Text = "Edit";
            this.EditProjectButton.UseVisualStyleBackColor = true;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(381, 47);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(99, 74);
            this.AddProjectButton.TabIndex = 2;
            this.AddProjectButton.Text = "Add";
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // ViewEmployeesButton
            // 
            this.ViewEmployeesButton.Location = new System.Drawing.Point(381, 329);
            this.ViewEmployeesButton.Name = "ViewEmployeesButton";
            this.ViewEmployeesButton.Size = new System.Drawing.Size(99, 74);
            this.ViewEmployeesButton.TabIndex = 3;
            this.ViewEmployeesButton.Text = "View ";
            this.ViewEmployeesButton.UseVisualStyleBackColor = true;
            this.ViewEmployeesButton.Click += new System.EventHandler(this.ViewEmployeesButton_Click);
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(30, 12);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(301, 412);
            this.ProjectListBox.TabIndex = 4;
            // 
            // ManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.ProjectListBox);
            this.Controls.Add(this.ViewEmployeesButton);
            this.Controls.Add(this.AddProjectButton);
            this.Controls.Add(this.EditProjectButton);
            this.Controls.Add(this.DeleteProjectButton);
            this.Name = "ManageProjects";
            this.Text = "ManageProjects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteProjectButton;
        private System.Windows.Forms.Button EditProjectButton;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.Button ViewEmployeesButton;
        private System.Windows.Forms.CheckedListBox ProjectListBox;
    }
}