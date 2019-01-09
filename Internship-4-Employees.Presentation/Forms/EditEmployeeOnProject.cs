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
            foreach (var relation in MockRelations.AllRelations)
            {
                if (relation.ProjectName == ProjectTextBox.Text && relation.EmployeeOib == OibTextBox.Text)
                    relation.HoursAWeek = int.Parse(HoursTextBox.Text);
            }
            Close();
        }
    }
}
