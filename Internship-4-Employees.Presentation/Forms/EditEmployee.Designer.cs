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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveEmployeeButton = new System.Windows.Forms.Button();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.OibTextBox = new System.Windows.Forms.TextBox();
            this.ProjectListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Job:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Birth date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "First/middle name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "OIB:";
            // 
            // SaveEmployeeButton
            // 
            this.SaveEmployeeButton.Location = new System.Drawing.Point(160, 361);
            this.SaveEmployeeButton.Name = "SaveEmployeeButton";
            this.SaveEmployeeButton.Size = new System.Drawing.Size(148, 65);
            this.SaveEmployeeButton.TabIndex = 19;
            this.SaveEmployeeButton.Text = "Save";
            this.SaveEmployeeButton.UseVisualStyleBackColor = true;
            this.SaveEmployeeButton.Click += new System.EventHandler(this.SaveEmployeeButton_Click);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(208, 152);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(244, 22);
            this.BirthDatePicker.TabIndex = 18;
            // 
            // JobComboBox
            // 
            this.JobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.JobComboBox.Location = new System.Drawing.Point(208, 206);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(244, 24);
            this.JobComboBox.TabIndex = 17;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LastNameTextBox.Location = new System.Drawing.Point(208, 106);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(244, 22);
            this.LastNameTextBox.TabIndex = 16;
            this.LastNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LastNameTextBox_KeyDown);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FirstNameTextBox.Location = new System.Drawing.Point(208, 63);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(244, 22);
            this.FirstNameTextBox.TabIndex = 15;
            this.FirstNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstNameTextBox_KeyDown);
            // 
            // OibTextBox
            // 
            this.OibTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.OibTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OibTextBox.Location = new System.Drawing.Point(208, 18);
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.ReadOnly = true;
            this.OibTextBox.Size = new System.Drawing.Size(244, 22);
            this.OibTextBox.TabIndex = 14;
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.ItemHeight = 16;
            this.ProjectListBox.Location = new System.Drawing.Point(208, 256);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(244, 84);
            this.ProjectListBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Participating projects:";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProjectListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveEmployeeButton);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.OibTextBox);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveEmployeeButton;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.ComboBox JobComboBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox OibTextBox;
        private System.Windows.Forms.ListBox ProjectListBox;
        private System.Windows.Forms.Label label6;
    }
}