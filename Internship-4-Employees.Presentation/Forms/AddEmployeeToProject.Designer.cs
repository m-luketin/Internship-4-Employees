namespace Internship_4_Employees.Forms
{
    partial class AddEmployeeToProject
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
            this.EmployeeListBox = new System.Windows.Forms.CheckedListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(12, 36);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(219, 242);
            this.EmployeeListBox.TabIndex = 0;
            this.EmployeeListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EmployeeListBox_ItemCheck);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(68, 344);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 53);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.Location = new System.Drawing.Point(12, 8);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.ReadOnly = true;
            this.ProjectTextBox.Size = new System.Drawing.Size(219, 22);
            this.ProjectTextBox.TabIndex = 2;
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HoursTextBox.Location = new System.Drawing.Point(68, 298);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.ReadOnly = true;
            this.HoursTextBox.Size = new System.Drawing.Size(163, 22);
            this.HoursTextBox.TabIndex = 3;
            this.HoursTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HoursTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hours:";
            // 
            // AddEmployeeToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.ProjectTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EmployeeListBox);
            this.Name = "AddEmployeeToProject";
            this.Text = "AddEmployeeToProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox EmployeeListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ProjectTextBox;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label label1;
    }
}