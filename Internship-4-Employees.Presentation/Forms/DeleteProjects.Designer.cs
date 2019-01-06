namespace Internship_4_Employees.Forms
{
    partial class DeleteProjects
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
            this.deleteProjectsListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteProjectsListBox
            // 
            this.deleteProjectsListBox.FormattingEnabled = true;
            this.deleteProjectsListBox.Location = new System.Drawing.Point(124, 12);
            this.deleteProjectsListBox.Name = "deleteProjectsListBox";
            this.deleteProjectsListBox.Size = new System.Drawing.Size(286, 412);
            this.deleteProjectsListBox.TabIndex = 0;
            this.deleteProjectsListBox.SelectedIndexChanged += new System.EventHandler(this.deleteProjectsListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeleteProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteProjectsListBox);
            this.Name = "DeleteProjects";
            this.Text = "DeleteProjects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox deleteProjectsListBox;
        private System.Windows.Forms.Button button1;
    }
}