namespace Internship_4_Employees.Forms
{
    partial class EditProject
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveProjectButton = new System.Windows.Forms.Button();
            this.ProjectTitleTextBox = new System.Windows.Forms.TextBox();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BeginningDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ChooseEmployeesListBox = new System.Windows.Forms.CheckedListBox();
            this.AddToProjectButton = new System.Windows.Forms.Button();
            this.EditEmployeeHours = new System.Windows.Forms.Button();
            this.RemoveEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "End:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Beginning:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // SaveProjectButton
            // 
            this.SaveProjectButton.Location = new System.Drawing.Point(302, 263);
            this.SaveProjectButton.Name = "SaveProjectButton";
            this.SaveProjectButton.Size = new System.Drawing.Size(119, 68);
            this.SaveProjectButton.TabIndex = 14;
            this.SaveProjectButton.Text = "Save";
            this.SaveProjectButton.UseVisualStyleBackColor = true;
            this.SaveProjectButton.Click += new System.EventHandler(this.SaveProjectButton_Click);
            // 
            // ProjectTitleTextBox
            // 
            this.ProjectTitleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ProjectTitleTextBox.Location = new System.Drawing.Point(103, 16);
            this.ProjectTitleTextBox.Name = "ProjectTitleTextBox";
            this.ProjectTitleTextBox.ReadOnly = true;
            this.ProjectTitleTextBox.Size = new System.Drawing.Size(245, 22);
            this.ProjectTitleTextBox.TabIndex = 13;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(103, 223);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(245, 22);
            this.EndDatePicker.TabIndex = 12;
            // 
            // BeginningDatePicker
            // 
            this.BeginningDatePicker.Location = new System.Drawing.Point(103, 116);
            this.BeginningDatePicker.Name = "BeginningDatePicker";
            this.BeginningDatePicker.Size = new System.Drawing.Size(245, 22);
            this.BeginningDatePicker.TabIndex = 11;
            // 
            // ChooseEmployeesListBox
            // 
            this.ChooseEmployeesListBox.FormattingEnabled = true;
            this.ChooseEmployeesListBox.Location = new System.Drawing.Point(395, 105);
            this.ChooseEmployeesListBox.Name = "ChooseEmployeesListBox";
            this.ChooseEmployeesListBox.Size = new System.Drawing.Size(277, 140);
            this.ChooseEmployeesListBox.TabIndex = 10;
            this.ChooseEmployeesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChooseEmployeesListBox_ItemCheck);
            // 
            // AddToProjectButton
            // 
            this.AddToProjectButton.Location = new System.Drawing.Point(395, 16);
            this.AddToProjectButton.Name = "AddToProjectButton";
            this.AddToProjectButton.Size = new System.Drawing.Size(85, 67);
            this.AddToProjectButton.TabIndex = 19;
            this.AddToProjectButton.Text = "Add employee";
            this.AddToProjectButton.UseVisualStyleBackColor = true;
            this.AddToProjectButton.Click += new System.EventHandler(this.AddToProjectButton_Click);
            // 
            // EditEmployeeHours
            // 
            this.EditEmployeeHours.Location = new System.Drawing.Point(599, 16);
            this.EditEmployeeHours.Name = "EditEmployeeHours";
            this.EditEmployeeHours.Size = new System.Drawing.Size(85, 67);
            this.EditEmployeeHours.TabIndex = 20;
            this.EditEmployeeHours.Text = "Edit employee hours";
            this.EditEmployeeHours.UseVisualStyleBackColor = true;
            this.EditEmployeeHours.Click += new System.EventHandler(this.EditEmployeeHours_Click);
            // 
            // RemoveEmployeeButton
            // 
            this.RemoveEmployeeButton.Location = new System.Drawing.Point(499, 16);
            this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            this.RemoveEmployeeButton.Size = new System.Drawing.Size(85, 67);
            this.RemoveEmployeeButton.TabIndex = 21;
            this.RemoveEmployeeButton.Text = "Remove employee";
            this.RemoveEmployeeButton.UseVisualStyleBackColor = true;
            this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 351);
            this.Controls.Add(this.RemoveEmployeeButton);
            this.Controls.Add(this.EditEmployeeHours);
            this.Controls.Add(this.AddToProjectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveProjectButton);
            this.Controls.Add(this.ProjectTitleTextBox);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.BeginningDatePicker);
            this.Controls.Add(this.ChooseEmployeesListBox);
            this.Name = "EditProject";
            this.Text = "EditProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveProjectButton;
        private System.Windows.Forms.TextBox ProjectTitleTextBox;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker BeginningDatePicker;
        private System.Windows.Forms.CheckedListBox ChooseEmployeesListBox;
        private System.Windows.Forms.Button AddToProjectButton;
        private System.Windows.Forms.Button EditEmployeeHours;
        private System.Windows.Forms.Button RemoveEmployeeButton;
    }
}