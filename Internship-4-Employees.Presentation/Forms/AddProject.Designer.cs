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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Beginning:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "End:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hours per week:";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}