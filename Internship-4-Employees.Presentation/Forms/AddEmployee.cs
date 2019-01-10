using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Infrastructure.Enums;

namespace Internship_4_Employees.Forms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            foreach (var job in Enum.GetValues(typeof(Job)))
            {
                JobComboBox.Items.Add(job);
            }

            foreach (var project in MockProjects.AllProjects)
            {
                ProjectListBox.Items.Add(project);
            }

            BirthDatePicker.MaxDate = DateTime.Now.Subtract(new TimeSpan(365 * 18, 0, 0, 0));
            BirthDatePicker.MinDate = DateTime.Now.Subtract(new TimeSpan(365 * 100, 0, 0, 0));

        }

        private bool InputConditions(string oib, string firstName, string lastName)
        {
            var oibRegex = new Regex(@"\d{11}");
            var nameRegex = new Regex(@"[a-zA-Z]{1,20}\s?[a-zA-Z]{1,20}?");

            if (oibRegex.IsMatch(oib) && nameRegex.IsMatch(firstName) && nameRegex.IsMatch(lastName) && nameRegex.IsMatch(JobComboBox.Text))
                return true;
            else
                return false;
        }
        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (MockEmployees.AlreadyInList(OibTextBox.Text))
            {
                var errorMessage = new OibAlreadyInError();
                errorMessage.Show();
                return;
            }
            if (!InputConditions(OibTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text) || (ProjectListBox.CheckedItems.Count > 0 && (HoursTextBox.Text == "" || HoursTextBox.Text == "0" || HoursTextBox.Text == "00")))
            {
                var errorMessage = new InputError();
                errorMessage.Show();
                return;
            }
            
            var index = FirstNameTextBox.Text.IndexOf(" ");// culture-specific? srsly?
            var firstAndMiddleName = "";
            var lastName = "";
            for (var i = 0; i < FirstNameTextBox.TextLength; i++)
            {
                if (i == 0)
                    firstAndMiddleName += char.ToUpper(FirstNameTextBox.Text[0]);
                else if(i == index + 1)
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
            MockEmployees.AllEmployees.Add(new Employee(firstAndMiddleName, lastName,
                        OibTextBox.Text, BirthDatePicker.Value, (Job) Enum.Parse(typeof(Job), JobComboBox.Text)));

            var projectNamesList = new List<string>();
            foreach (var checkedItem in ProjectListBox.CheckedItems)
            {
                projectNamesList.Add(checkedItem.ToString());
            }

            foreach (var name in projectNamesList)
            {
                MockRelations.AllRelations.Add(new RelationProjectEmployee(name, OibTextBox.Text, int.Parse(HoursTextBox.Text)));
            }

            Close(); 
        }

        private void OibTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= '0' && e.KeyValue <= '9' && OibTextBox.TextLength < 11)
            {
                OibTextBox.Text += e.KeyValue - 48;
            }
            else if ((e.KeyCode & Keys.Back) != 0)
                OibTextBox.Text = "";
        }

        private void FirstNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'A' && e.KeyValue <= 'Z' && FirstNameTextBox.TextLength < 15)
            {
                if(!e.Shift)
                    FirstNameTextBox.Text += char.ToLower((char)e.KeyValue);
                else
                    FirstNameTextBox.Text += (char)e.KeyValue;
            }
            else if(e.KeyCode == Keys.Space)
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
