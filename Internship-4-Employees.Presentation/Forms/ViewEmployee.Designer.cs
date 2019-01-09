namespace Internship_4_Employees.Forms
{
    partial class ViewEmployee
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
            this.ViewEmployeeTextBox = new System.Windows.Forms.RichTextBox();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.OibTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ViewEmployeeTextBox
            // 
            this.ViewEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ViewEmployeeTextBox.Location = new System.Drawing.Point(0, 0);
            this.ViewEmployeeTextBox.Name = "ViewEmployeeTextBox";
            this.ViewEmployeeTextBox.Size = new System.Drawing.Size(255, 217);
            this.ViewEmployeeTextBox.TabIndex = 0;
            this.ViewEmployeeTextBox.Text = "";
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(91, 229);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.EditEmployeeButton.TabIndex = 1;
            this.EditEmployeeButton.Text = "Edit";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            this.EditEmployeeButton.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // OibTextBox
            // 
            this.OibTextBox.Location = new System.Drawing.Point(0, 229);
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.Size = new System.Drawing.Size(100, 22);
            this.OibTextBox.TabIndex = 2;
            this.OibTextBox.Visible = false;
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 264);
            this.Controls.Add(this.OibTextBox);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.ViewEmployeeTextBox);
            this.Name = "ViewEmployee";
            this.Text = "ViewEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ViewEmployeeTextBox;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.TextBox OibTextBox;
    }
}