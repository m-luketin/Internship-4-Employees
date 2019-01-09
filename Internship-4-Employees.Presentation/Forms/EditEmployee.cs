using System;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Infrastructure.Enums;

namespace Internship_4_Employees.Forms
{
    public partial class EditEmployee : Form
    {
        public EditEmployee(string checkedOib)
        {
            InitializeComponent();
            OibTextBox.Text = checkedOib;
            FirstNameTextBox.Text = MockEmployees.GetFirstName(checkedOib);
            LastNameTextBox.Text = MockEmployees.GetLastName(checkedOib);
            BirthDatePicker.Value = MockEmployees.GetBirthDate(checkedOib);
            foreach (var job in Enum.GetValues(typeof(Job)))
            {
                JobComboBox.Items.Add(job);
            }
            JobComboBox.Text = MockEmployees.GetJob(checkedOib);

            foreach (var relation in MockRelations.AllRelations)
            {
                if(relation.EmployeeOib == checkedOib)
                    ProjectListBox.Items.Add(relation.ProjectName);
            }
        }

        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {
            var index = FirstNameTextBox.Text.IndexOf(" ");//???
            var firstAndMiddleName = "";
            var lastName = "";
            for (var i = 0; i < FirstNameTextBox.TextLength; i++)
            {
                if (i == 0)
                    firstAndMiddleName += char.ToUpper(FirstNameTextBox.Text[0]);
                else if (i == index + 1)
                    firstAndMiddleName += char.ToUpper(FirstNameTextBox.Text[index + 1]);
                else
                {
                    firstAndMiddleName += FirstNameTextBox.Text[i];
                }
            }

            for (var i = 0; i < LastNameTextBox.TextLength; i++)
            {
                if (i == 0)
                    lastName += char.ToUpper(LastNameTextBox.Text[0]);
                else
                {
                    lastName += LastNameTextBox.Text[i];
                }
            }
            foreach (var employee in MockEmployees.AllEmployees)
            {
                if (employee.Oib == OibTextBox.Text)
                {
                    employee.FirstName = firstAndMiddleName;
                    employee.LastName = lastName;
                    employee.BirthDate = BirthDatePicker.Value;
                    employee.CompanyJob = (Job)Enum.Parse(typeof(Job), JobComboBox.Text);
                }
            }
            Close();
        }

        private void FirstNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'A' && e.KeyValue <= 'Z' && FirstNameTextBox.TextLength < 15)
            {
                if (!e.Shift)
                    FirstNameTextBox.Text += char.ToLower((char)e.KeyValue);
                else
                    FirstNameTextBox.Text += (char)e.KeyValue;
            }
            else if (e.KeyCode == Keys.Space)
                FirstNameTextBox.Text += ' ';
            else if ((e.KeyCode & Keys.Back) != 0)
                FirstNameTextBox.Text = "";
        }

        private void LastNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'A' && e.KeyValue <= 'Z' && LastNameTextBox.TextLength < 10)
            {
                if (!e.Shift)
                    LastNameTextBox.Text += char.ToLower((char)e.KeyValue);
                else
                    LastNameTextBox.Text += (char)e.KeyValue;
            }
            else if (e.KeyCode == Keys.Space)
                LastNameTextBox.Text += ' ';
            else if ((e.KeyCode & Keys.Back) != 0)
                LastNameTextBox.Text = "";
        }
    }
}
