using System;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class EditEmployeeOnProject : Form
    {
        public EditEmployeeOnProject(string employeeOib, string projectName)
        {
            InitializeComponent();
            OibTextBox.Text = employeeOib;
            ProjectTextBox.Text = projectName;
            foreach (var relation in MockRelations.AllRelations)
            {
                if (relation.ProjectName == projectName && relation.EmployeeOib == employeeOib)
                    HoursTextBox.Text = relation.HoursAWeek.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (HoursTextBox.Text == "" || HoursTextBox.Text == "0" || HoursTextBox.Text == "00")
            {
                var errorMessage = new InputError();
                errorMessage.Show();
                return;
            }
            foreach (var relation in MockRelations.AllRelations)
            {
                if (relation.ProjectName == ProjectTextBox.Text && relation.EmployeeOib == OibTextBox.Text)
                    relation.HoursAWeek = int.Parse(HoursTextBox.Text);
            }
            Close();
        }

        private void HoursTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= '0' && e.KeyValue <= '9' && HoursTextBox.TextLength < 2)
            {
                HoursTextBox.Text += e.KeyValue - 48;
            }
            else if ((e.KeyCode & Keys.Back) != 0)
                HoursTextBox.Text = "";
        }
    }
}
