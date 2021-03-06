﻿namespace Internship_4_Employees.Forms
{
    partial class DeleteEmployeePrompt
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmDeleteButton = new System.Windows.Forms.Button();
            this.DenyDeleteButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to delete this employee?";
            // 
            // ConfirmDeleteButton
            // 
            this.ConfirmDeleteButton.Location = new System.Drawing.Point(94, 66);
            this.ConfirmDeleteButton.Name = "ConfirmDeleteButton";
            this.ConfirmDeleteButton.Size = new System.Drawing.Size(103, 86);
            this.ConfirmDeleteButton.TabIndex = 1;
            this.ConfirmDeleteButton.Text = "Yes";
            this.ConfirmDeleteButton.UseVisualStyleBackColor = true;
            this.ConfirmDeleteButton.Click += new System.EventHandler(this.ConfirmDeleteButton_Click);
            // 
            // DenyDeleteButton
            // 
            this.DenyDeleteButton.Location = new System.Drawing.Point(340, 66);
            this.DenyDeleteButton.Name = "DenyDeleteButton";
            this.DenyDeleteButton.Size = new System.Drawing.Size(103, 86);
            this.DenyDeleteButton.TabIndex = 2;
            this.DenyDeleteButton.Text = "No";
            this.DenyDeleteButton.UseVisualStyleBackColor = true;
            this.DenyDeleteButton.Click += new System.EventHandler(this.DenyDeleteButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DeleteEmployeePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 191);
            this.Controls.Add(this.DenyDeleteButton);
            this.Controls.Add(this.ConfirmDeleteButton);
            this.Controls.Add(this.label1);
            this.Name = "DeleteEmployeePrompt";
            this.Text = "DeleteEmployeePrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmDeleteButton;
        private System.Windows.Forms.Button DenyDeleteButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}