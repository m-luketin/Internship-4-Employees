namespace Internship_4_Employees.Forms
{
    partial class DeleteEmployees
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
            this.deleteEmployeeListBox = new System.Windows.Forms.CheckedListBox();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteEmployeeListBox
            // 
            this.deleteEmployeeListBox.FormattingEnabled = true;
            this.deleteEmployeeListBox.Location = new System.Drawing.Point(0, 0);
            this.deleteEmployeeListBox.Name = "deleteEmployeeListBox";
            this.deleteEmployeeListBox.Size = new System.Drawing.Size(342, 446);
            this.deleteEmployeeListBox.TabIndex = 0;
            this.deleteEmployeeListBox.SelectedIndexChanged += new System.EventHandler(this.deleteEmployeeListBox_SelectedIndexChanged);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(571, 235);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(101, 61);
            this.deleteEmployeeButton.TabIndex = 1;
            this.deleteEmployeeButton.Text = "Delete";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // DeleteEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.deleteEmployeeListBox);
            this.Name = "DeleteEmployees";
            this.Text = "DeleteEmployees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox deleteEmployeeListBox;
        private System.Windows.Forms.Button deleteEmployeeButton;
    }
}