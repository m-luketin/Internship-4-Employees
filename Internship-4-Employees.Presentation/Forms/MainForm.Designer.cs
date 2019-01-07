namespace Internship_4_Employees.Forms
{
    partial class MainForm
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
            this.ProjectListBox = new System.Windows.Forms.ListBox();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageProjectsButton = new System.Windows.Forms.Button();
            this.ManageEmployeesButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.ItemHeight = 16;
            this.ProjectListBox.Location = new System.Drawing.Point(496, 199);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(241, 228);
            this.ProjectListBox.TabIndex = 15;
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 16;
            this.EmployeeListBox.Location = new System.Drawing.Point(64, 199);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(241, 228);
            this.EmployeeListBox.TabIndex = 14;
            this.EmployeeListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(253, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Project management 1.0";
            // 
            // ManageProjectsButton
            // 
            this.ManageProjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ManageProjectsButton.Location = new System.Drawing.Point(496, 85);
            this.ManageProjectsButton.Name = "ManageProjectsButton";
            this.ManageProjectsButton.Size = new System.Drawing.Size(241, 74);
            this.ManageProjectsButton.TabIndex = 12;
            this.ManageProjectsButton.Text = "Projects";
            this.ManageProjectsButton.UseVisualStyleBackColor = true;
            this.ManageProjectsButton.Click += new System.EventHandler(this.ManageProjectsButton_Click);
            // 
            // ManageEmployeesButton
            // 
            this.ManageEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ManageEmployeesButton.Location = new System.Drawing.Point(64, 85);
            this.ManageEmployeesButton.Name = "ManageEmployeesButton";
            this.ManageEmployeesButton.Size = new System.Drawing.Size(241, 74);
            this.ManageEmployeesButton.TabIndex = 11;
            this.ManageEmployeesButton.Text = "Employees";
            this.ManageEmployeesButton.UseVisualStyleBackColor = true;
            this.ManageEmployeesButton.Click += new System.EventHandler(this.ManageEmployeesButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(357, 399);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ProjectListBox);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageProjectsButton);
            this.Controls.Add(this.ManageEmployeesButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProjectListBox;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageProjectsButton;
        private System.Windows.Forms.Button ManageEmployeesButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}