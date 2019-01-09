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
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 219);
            this.Controls.Add(this.ViewEmployeeTextBox);
            this.Name = "ViewEmployee";
            this.Text = "ViewEmployee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ViewEmployeeTextBox;
    }
}