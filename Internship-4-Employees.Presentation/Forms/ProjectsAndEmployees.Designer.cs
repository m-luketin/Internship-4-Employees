namespace Internship_4_Employees.Forms
{
    partial class ProjectsAndEmployees
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
            this.ProjectsAndEmployeesListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ProjectsAndEmployeesListbox
            // 
            this.ProjectsAndEmployeesListbox.FormattingEnabled = true;
            this.ProjectsAndEmployeesListbox.ItemHeight = 16;
            this.ProjectsAndEmployeesListbox.Location = new System.Drawing.Point(-1, 3);
            this.ProjectsAndEmployeesListbox.Name = "ProjectsAndEmployeesListbox";
            this.ProjectsAndEmployeesListbox.Size = new System.Drawing.Size(385, 580);
            this.ProjectsAndEmployeesListbox.TabIndex = 0;
            // 
            // ProjectsAndEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 583);
            this.Controls.Add(this.ProjectsAndEmployeesListbox);
            this.Name = "ProjectsAndEmployees";
            this.Text = "ProjectsAndEmployeescs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProjectsAndEmployeesListbox;
    }
}