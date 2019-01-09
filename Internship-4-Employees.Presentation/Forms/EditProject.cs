using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class EditProject : Form
    {
        public EditProject(string projectName)
        {
            InitializeComponent();
            ProjectTitleTextBox.Text = projectName;
            BeginningDatePicker.Value = MockProjects.GetBeginningDateTime(projectName);
            EndDatePicker.Value = MockProjects.GetEndingDateTime(projectName);
            foreach (var relation in MockRelations.AllRelations)
            {
                if (relation.ProjectName == projectName)
                {
                    ChooseEmployeesListBox.Items.Add(MockEmployees.GetFirstName(relation.EmployeeOib) + " " +
                                                     MockEmployees.GetLastName(relation.EmployeeOib) + " " +
                                                     relation.EmployeeOib);
                }
            }
            BeginningDatePicker.MinDate = DateTime.Now.Subtract(new TimeSpan(365 * 20, 0, 0, 0));
            BeginningDatePicker.MaxDate = DateTime.Now.Add(new TimeSpan(365 * 20, 0, 0, 0));
            EndDatePicker.MinDate = DateTime.Now.Subtract(new TimeSpan(365 * 20, 0, 0, 0));
            EndDatePicker.MaxDate = DateTime.Now.Add(new TimeSpan(365 * 20, 0, 0, 0));
        }
        private void RefreshForm(string projectName)
        {
            ChooseEmployeesListBox.Items.Clear();
            ProjectTitleTextBox.Text = projectName;
            BeginningDatePicker.Value = MockProjects.GetBeginningDateTime(projectName);
            EndDatePicker.Value = MockProjects.GetEndingDateTime(projectName);
            foreach (var relation in MockRelations.AllRelations)
            {
                if (relation.ProjectName == projectName)
                {
                    ChooseEmployeesListBox.Items.Add(MockEmployees.GetFirstName(relation.EmployeeOib) + " " +
                                                     MockEmployees.GetLastName(relation.EmployeeOib) + " " +
                                                     relation.EmployeeOib);
                }
            }
        }
        private void ChooseEmployeesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < ChooseEmployeesListBox.Items.Count; ++ix)
                if (ix != e.Index)
                    ChooseEmployeesListBox.SetItemChecked(ix, false);
        }

        private void SaveProjectButton_Click(object sender, EventArgs e)
        {
            if (EndDatePicker.Value - BeginningDatePicker.Value < new TimeSpan(0, 0, 0, 0))
            {
                var datesNotValid = new DatesNotValidError();
                datesNotValid.Show();
                return;
            }
            foreach (var project in MockProjects.AllProjects)
            {
                if (ProjectTitleTextBox.Text == project.Name)
                {
                    project.Beginning = BeginningDatePicker.Value;
                    project.Ending = EndDatePicker.Value;
                }
            }
            Close();
        }

        private void AddToProjectButton_Click(object sender, EventArgs e)
        {
            var addEmployees = new AddEmployeeToProject(ProjectTitleTextBox.Text);
            addEmployees.ShowDialog();
            RefreshForm(ProjectTitleTextBox.Text);
        }

        private void EditEmployeeHours_Click(object sender, EventArgs e)
        {

            var oibRegex = new Regex(@"\d{11}");
            foreach (var item in ChooseEmployeesListBox.CheckedItems)
            {
                var editEmployeeHours = new EditEmployeeOnProject(
                    oibRegex.Match(item.ToString()).Value, ProjectTitleTextBox.Text);
                editEmployeeHours.Show();
            }

            RefreshForm(ProjectTitleTextBox.Text);
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            var oibRegex = new Regex(@"\d{11}");
            foreach (var item in ChooseEmployeesListBox.CheckedItems)
            {
                foreach (var relation in MockRelations.AllRelations)
                {
                    if (oibRegex.Match(item.ToString()).Value == relation.EmployeeOib && ProjectTitleTextBox.Text ==
                        relation.ProjectName)
                    {
                        MockRelations.AllRelations.Remove(relation);
                        break;
                    }
                        
                }

                break;
            }

            RefreshForm(ProjectTitleTextBox.Text);
        }
    }
}
