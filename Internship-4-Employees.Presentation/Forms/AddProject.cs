using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                ChooseEmployeesListBox.Items.Add(employee);
            }

            BeginningDatePicker.MinDate = DateTime.Now.Subtract(new TimeSpan(365 * 20, 0, 0, 0));
            BeginningDatePicker.MaxDate = DateTime.Now.Add(new TimeSpan(365 * 20, 0, 0, 0));
            EndDatePicker.MinDate = DateTime.Now.Subtract(new TimeSpan(365 * 20, 0, 0, 0));
            EndDatePicker.MaxDate = DateTime.Now.Add(new TimeSpan(365 * 20, 0, 0, 0));
        }
        private bool DatesAreValid(DateTime beginning, DateTime end)
        {
            if (end - beginning > new TimeSpan(0, 0, 0, 0))
                return true;
            else
                return false;
        }
        private void ProjectTitleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'A' && e.KeyValue <= 'Z')
            {
                if (!e.Shift)
                    ProjectTitleTextBox.Text += char.ToLower((char)e.KeyValue);
                else
                    ProjectTitleTextBox.Text += (char)e.KeyValue;
            }
            else if (e.KeyCode == Keys.Space)
                ProjectTitleTextBox.Text += ' ';
            else if ((e.KeyCode & Keys.Back) != 0)
                ProjectTitleTextBox.Text = "";
        }
        private void SaveProjectButton_Click(object sender, EventArgs e)
        {
            foreach (var project in MockProjects.AllProjects)
            {
                if (ProjectTitleTextBox.Text == project.Name)
                {
                    var nameError = new ProjectInDatabaseError();
                    nameError.Show();
                    return;
                }

            }

            if (ChooseEmployeesListBox.CheckedItems.Count < 1)
            {
                var employeeError = new EmployeeNotChosenError();
                employeeError.Show();
                return;
            }
            else if (!DatesAreValid(BeginningDatePicker.Value, EndDatePicker.Value))
            {
                var dateError = new DatesNotValidError();
                dateError.Show();
                return;
            }
            else if (ProjectTitleTextBox.Text == "" || HoursTextBox.Text == "" 
                      || HoursTextBox.Text == "0" || HoursTextBox.Text == "00")//???
            {
                var inputError = new InputsNotFilledError();
                inputError.Show();
                return;
            }

            var newProject = new Project(ProjectTitleTextBox.Text, BeginningDatePicker.Value, EndDatePicker.Value);
                MockProjects.AllProjects.Add(newProject);

            var checkedEmployeesOib = new List<string>();
            var oibRegex = new Regex(@"\d{11}");
            foreach (var employee in ChooseEmployeesListBox.CheckedItems)
            {
                checkedEmployeesOib.Add(oibRegex.Match(employee.ToString()).Value);
            }

            foreach (var oib in checkedEmployeesOib)
            {
                var tmpRelation = new RelationProjectEmployee(ProjectTitleTextBox.Text, oib,
                int.Parse(HoursTextBox.Text));
                MockRelations.AllRelations.Add(tmpRelation);
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
