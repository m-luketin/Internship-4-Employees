namespace Internship_4_Employees.Forms
{
    partial class ManageEmployees
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
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ViewEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(415, 345);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(114, 80);
            this.EditEmployeeButton.TabIndex = 7;
            this.EditEmployeeButton.Text = "Edit";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            this.EditEmployeeButton.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(415, 238);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(114, 80);
            this.DeleteEmployeeButton.TabIndex = 6;
            this.DeleteEmployeeButton.Text = "Delete";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(415, 129);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(114, 80);
            this.AddEmployeeButton.TabIndex = 5;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EmployeeCheckedListBox
            // 
            this.EmployeeCheckedListBox.FormattingEnabled = true;
            this.EmployeeCheckedListBox.Location = new System.Drawing.Point(23, 30);
            this.EmployeeCheckedListBox.Name = "EmployeeCheckedListBox";
            this.EmployeeCheckedListBox.Size = new System.Drawing.Size(338, 395);
            this.EmployeeCheckedListBox.TabIndex = 4;
            this.EmployeeCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EmployeeCheckedListBox_ItemCheck);
            // 
            // ViewEmployeeButton
            // 
            this.ViewEmployeeButton.Location = new System.Drawing.Point(415, 30);
            this.ViewEmployeeButton.Name = "ViewEmployeeButton";
            this.ViewEmployeeButton.Size = new System.Drawing.Size(114, 80);
            this.ViewEmployeeButton.TabIndex = 8;
            this.ViewEmployeeButton.Text = "View";
            this.ViewEmployeeButton.UseVisualStyleBackColor = true;
            this.ViewEmployeeButton.Click += new System.EventHandler(this.ViewEmployeeButton_Click);
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 458);
            this.Controls.Add(this.ViewEmployeeButton);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EmployeeCheckedListBox);
            this.Name = "ManageEmployees";
            this.Text = "ManageEmployees";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button ViewEmployeeButton;
        public System.Windows.Forms.Button EditEmployeeButton;
        public System.Windows.Forms.CheckedListBox EmployeeCheckedListBox;
    }
}