namespace Internship_4_Employees.Forms
{
    partial class AddProject
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
            this.ChooseEmployeesListBox = new System.Windows.Forms.CheckedListBox();
            this.BeginningDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectTitleTextBox = new System.Windows.Forms.TextBox();
            this.SaveProjectButton = new System.Windows.Forms.Button();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseEmployeesListBox
            // 
            this.ChooseEmployeesListBox.FormattingEnabled = true;
            this.ChooseEmployeesListBox.Location = new System.Drawing.Point(422, 46);
            this.ChooseEmployeesListBox.Name = "ChooseEmployeesListBox";
            this.ChooseEmployeesListBox.Size = new System.Drawing.Size(290, 310);
            this.ChooseEmployeesListBox.TabIndex = 0;
            // 
            // BeginningDatePicker
            // 
            this.BeginningDatePicker.Location = new System.Drawing.Point(108, 115);
            this.BeginningDatePicker.Name = "BeginningDatePicker";
            this.BeginningDatePicker.Size = new System.Drawing.Size(245, 22);
            this.BeginningDatePicker.TabIndex = 1;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(108, 176);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(245, 22);
            this.EndDatePicker.TabIndex = 2;
            // 
            // ProjectTitleTextBox
            // 
            this.ProjectTitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProjectTitleTextBox.Location = new System.Drawing.Point(108, 46);
            this.ProjectTitleTextBox.Name = "ProjectTitleTextBox";
            this.ProjectTitleTextBox.ReadOnly = true;
            this.ProjectTitleTextBox.Size = new System.Drawing.Size(245, 22);
            this.ProjectTitleTextBox.TabIndex = 3;
            this.ProjectTitleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProjectTitleTextBox_KeyDown);
            // 
            // SaveProjectButton
            // 
            this.SaveProjectButton.Location = new System.Drawing.Point(175, 295);
            this.SaveProjectButton.Name = "SaveProjectButton";
            this.SaveProjectButton.Size = new System.Drawing.Size(86, 61);
            this.SaveProjectButton.TabIndex = 4;
            this.SaveProjectButton.Text = "Save";
            this.SaveProjectButton.UseVisualStyleBackColor = true;
            this.SaveProjectButton.Click += new System.EventHandler(this.SaveProjectButton_Click);
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HoursTextBox.Location = new System.Drawing.Point(175, 227);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.ReadOnly = true;
            this.HoursTextBox.Size = new System.Drawing.Size(86, 22);
            this.HoursTextBox.TabIndex = 5;
            this.HoursTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HoursTextBox_KeyDown);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 410);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.SaveProjectButton);
            this.Controls.Add(this.ProjectTitleTextBox);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.BeginningDatePicker);
            this.Controls.Add(this.ChooseEmployeesListBox);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChooseEmployeesListBox;
        private System.Windows.Forms.DateTimePicker BeginningDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.TextBox ProjectTitleTextBox;
        private System.Windows.Forms.Button SaveProjectButton;
        private System.Windows.Forms.TextBox HoursTextBox;
    }
}