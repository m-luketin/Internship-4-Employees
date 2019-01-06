namespace Internship_4_Employees.Forms
{
    partial class ViewEmployees
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
            this.viewEmployeesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // viewEmployeesListBox
            // 
            this.viewEmployeesListBox.FormattingEnabled = true;
            this.viewEmployeesListBox.ItemHeight = 16;
            this.viewEmployeesListBox.Location = new System.Drawing.Point(252, 1);
            this.viewEmployeesListBox.Name = "viewEmployeesListBox";
            this.viewEmployeesListBox.Size = new System.Drawing.Size(277, 452);
            this.viewEmployeesListBox.TabIndex = 0;
            this.viewEmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewEmployeesListBox);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox viewEmployeesListBox;
    }
}