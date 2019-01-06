namespace Internship_4_Employees.Forms
{
    partial class EditEmployee
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
            this.employeesForEdit = new System.Windows.Forms.CheckedListBox();
            this.editEmployeeDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesForEdit
            // 
            this.employeesForEdit.FormattingEnabled = true;
            this.employeesForEdit.Location = new System.Drawing.Point(129, 12);
            this.employeesForEdit.Name = "employeesForEdit";
            this.employeesForEdit.Size = new System.Drawing.Size(280, 395);
            this.employeesForEdit.TabIndex = 0;
            this.employeesForEdit.SelectedIndexChanged += new System.EventHandler(this.employeesForEdit_SelectedIndexChanged);
            // 
            // editEmployeeDetails
            // 
            this.editEmployeeDetails.Location = new System.Drawing.Point(562, 338);
            this.editEmployeeDetails.Name = "editEmployeeDetails";
            this.editEmployeeDetails.Size = new System.Drawing.Size(120, 69);
            this.editEmployeeDetails.TabIndex = 1;
            this.editEmployeeDetails.Text = "Edit";
            this.editEmployeeDetails.UseVisualStyleBackColor = true;
            this.editEmployeeDetails.Click += new System.EventHandler(this.editEmployeeDetails_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editEmployeeDetails);
            this.Controls.Add(this.employeesForEdit);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox employeesForEdit;
        private System.Windows.Forms.Button editEmployeeDetails;
    }
}