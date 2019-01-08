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
            this.label1 = new System.Windows.Forms.Label();
            this.ManageProjectsButton = new System.Windows.Forms.Button();
            this.ManageEmployeesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(290, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Project management 1.0";
            // 
            // ManageProjectsButton
            // 
            this.ManageProjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ManageProjectsButton.Location = new System.Drawing.Point(497, 85);
            this.ManageProjectsButton.Name = "ManageProjectsButton";
            this.ManageProjectsButton.Size = new System.Drawing.Size(325, 122);
            this.ManageProjectsButton.TabIndex = 12;
            this.ManageProjectsButton.Text = "Projects";
            this.ManageProjectsButton.UseVisualStyleBackColor = true;
            this.ManageProjectsButton.Click += new System.EventHandler(this.ManageProjectsButton_Click);
            // 
            // ManageEmployeesButton
            // 
            this.ManageEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ManageEmployeesButton.Location = new System.Drawing.Point(34, 85);
            this.ManageEmployeesButton.Name = "ManageEmployeesButton";
            this.ManageEmployeesButton.Size = new System.Drawing.Size(325, 122);
            this.ManageEmployeesButton.TabIndex = 11;
            this.ManageEmployeesButton.Text = "Employees";
            this.ManageEmployeesButton.UseVisualStyleBackColor = true;
            this.ManageEmployeesButton.Click += new System.EventHandler(this.ManageEmployeesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageProjectsButton);
            this.Controls.Add(this.ManageEmployeesButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageProjectsButton;
        private System.Windows.Forms.Button ManageEmployeesButton;
    }
}