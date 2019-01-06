namespace Internship_4_Employees.Forms
{
    partial class ViewProjects
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
            this.viewProjectsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // viewProjectsListBox
            // 
            this.viewProjectsListBox.FormattingEnabled = true;
            this.viewProjectsListBox.ItemHeight = 16;
            this.viewProjectsListBox.Location = new System.Drawing.Point(251, 12);
            this.viewProjectsListBox.Name = "viewProjectsListBox";
            this.viewProjectsListBox.Size = new System.Drawing.Size(272, 436);
            this.viewProjectsListBox.TabIndex = 0;
            this.viewProjectsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ViewProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewProjectsListBox);
            this.Name = "ViewProjectsForm";
            this.Text = "viewProjectsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox viewProjectsListBox;
    }
}