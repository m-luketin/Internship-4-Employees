namespace Internship_4_Employees.Forms
{
    partial class StartForm
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
            this.viewEmployeesButton = new System.Windows.Forms.Button();
            this.editEmployeesButton = new System.Windows.Forms.Button();
            this.addEmployeesButton = new System.Windows.Forms.Button();
            this.deleteEmployeesButton = new System.Windows.Forms.Button();
            this.viewProjectsButton = new System.Windows.Forms.Button();
            this.editProjectsButton = new System.Windows.Forms.Button();
            this.addProjectsButton = new System.Windows.Forms.Button();
            this.deleteProjectsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewEmployeesButton
            // 
            this.viewEmployeesButton.Location = new System.Drawing.Point(113, 77);
            this.viewEmployeesButton.Name = "viewEmployeesButton";
            this.viewEmployeesButton.Size = new System.Drawing.Size(102, 63);
            this.viewEmployeesButton.TabIndex = 0;
            this.viewEmployeesButton.Text = "View Employees";
            this.viewEmployeesButton.UseVisualStyleBackColor = true;
            this.viewEmployeesButton.Click += new System.EventHandler(this.viewEmployeesButton_Click);
            // 
            // editEmployeesButton
            // 
            this.editEmployeesButton.Location = new System.Drawing.Point(113, 175);
            this.editEmployeesButton.Name = "editEmployeesButton";
            this.editEmployeesButton.Size = new System.Drawing.Size(102, 55);
            this.editEmployeesButton.TabIndex = 1;
            this.editEmployeesButton.Text = "Edit employees";
            this.editEmployeesButton.UseVisualStyleBackColor = true;
            this.editEmployeesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addEmployeesButton
            // 
            this.addEmployeesButton.Location = new System.Drawing.Point(113, 267);
            this.addEmployeesButton.Name = "addEmployeesButton";
            this.addEmployeesButton.Size = new System.Drawing.Size(102, 54);
            this.addEmployeesButton.TabIndex = 2;
            this.addEmployeesButton.Text = "Add employees";
            this.addEmployeesButton.UseVisualStyleBackColor = true;
            this.addEmployeesButton.Click += new System.EventHandler(this.addEmployeesButton_Click);
            // 
            // deleteEmployeesButton
            // 
            this.deleteEmployeesButton.Location = new System.Drawing.Point(113, 353);
            this.deleteEmployeesButton.Name = "deleteEmployeesButton";
            this.deleteEmployeesButton.Size = new System.Drawing.Size(102, 55);
            this.deleteEmployeesButton.TabIndex = 3;
            this.deleteEmployeesButton.Text = "Delete employees";
            this.deleteEmployeesButton.UseVisualStyleBackColor = true;
            this.deleteEmployeesButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // viewProjectsButton
            // 
            this.viewProjectsButton.Location = new System.Drawing.Point(560, 77);
            this.viewProjectsButton.Name = "viewProjectsButton";
            this.viewProjectsButton.Size = new System.Drawing.Size(108, 63);
            this.viewProjectsButton.TabIndex = 4;
            this.viewProjectsButton.Text = "View projects";
            this.viewProjectsButton.UseVisualStyleBackColor = true;
            this.viewProjectsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // editProjectsButton
            // 
            this.editProjectsButton.Location = new System.Drawing.Point(560, 175);
            this.editProjectsButton.Name = "editProjectsButton";
            this.editProjectsButton.Size = new System.Drawing.Size(108, 55);
            this.editProjectsButton.TabIndex = 5;
            this.editProjectsButton.Text = "Edit projects";
            this.editProjectsButton.UseVisualStyleBackColor = true;
            this.editProjectsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // addProjectsButton
            // 
            this.addProjectsButton.Location = new System.Drawing.Point(560, 267);
            this.addProjectsButton.Name = "addProjectsButton";
            this.addProjectsButton.Size = new System.Drawing.Size(108, 54);
            this.addProjectsButton.TabIndex = 6;
            this.addProjectsButton.Text = "Add projects";
            this.addProjectsButton.UseVisualStyleBackColor = true;
            this.addProjectsButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteProjectsButton
            // 
            this.deleteProjectsButton.Location = new System.Drawing.Point(560, 353);
            this.deleteProjectsButton.Name = "deleteProjectsButton";
            this.deleteProjectsButton.Size = new System.Drawing.Size(108, 55);
            this.deleteProjectsButton.TabIndex = 7;
            this.deleteProjectsButton.Text = "Delete projects";
            this.deleteProjectsButton.UseVisualStyleBackColor = true;
            this.deleteProjectsButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(249, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Project management 1.0";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteProjectsButton);
            this.Controls.Add(this.addProjectsButton);
            this.Controls.Add(this.editProjectsButton);
            this.Controls.Add(this.viewProjectsButton);
            this.Controls.Add(this.deleteEmployeesButton);
            this.Controls.Add(this.addEmployeesButton);
            this.Controls.Add(this.editEmployeesButton);
            this.Controls.Add(this.viewEmployeesButton);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewEmployeesButton;
        private System.Windows.Forms.Button editEmployeesButton;
        private System.Windows.Forms.Button addEmployeesButton;
        private System.Windows.Forms.Button deleteEmployeesButton;
        private System.Windows.Forms.Button viewProjectsButton;
        private System.Windows.Forms.Button editProjectsButton;
        private System.Windows.Forms.Button addProjectsButton;
        private System.Windows.Forms.Button deleteProjectsButton;
        private System.Windows.Forms.Label label1;
    }
}