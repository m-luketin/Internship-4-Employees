namespace Internship_4_Employees.Forms
{
    partial class EditEmployeeOnProject
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
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.OibTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hours:";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HoursTextBox.Location = new System.Drawing.Point(68, 78);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.ReadOnly = true;
            this.HoursTextBox.Size = new System.Drawing.Size(163, 22);
            this.HoursTextBox.TabIndex = 8;
            this.HoursTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HoursTextBox_KeyDown);
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.Location = new System.Drawing.Point(12, 7);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.ReadOnly = true;
            this.ProjectTextBox.Size = new System.Drawing.Size(219, 22);
            this.ProjectTextBox.TabIndex = 7;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(68, 121);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(103, 53);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // OibTextBox
            // 
            this.OibTextBox.Location = new System.Drawing.Point(12, 35);
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.ReadOnly = true;
            this.OibTextBox.Size = new System.Drawing.Size(219, 22);
            this.OibTextBox.TabIndex = 10;
            // 
            // EditEmployeeOnProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 202);
            this.Controls.Add(this.OibTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.ProjectTextBox);
            this.Controls.Add(this.EditButton);
            this.Name = "EditEmployeeOnProject";
            this.Text = "EditEmployeeOnProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.TextBox ProjectTextBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox OibTextBox;
    }
}