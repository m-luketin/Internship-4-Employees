using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            if (!MockEmployees.AlreadyInList(OibTextBox.Text))
            {
                if (InputConditions(OibTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text))
                {

                    MockEmployees.AllEmployees.Add(new Employee(FirstNameTextBox.Text, LastNameTextBox.Text,
                        OibTextBox.Text,
                        BirthDatePicker.Value, (Job) Enum.Parse(typeof(Job), JobComboBox.Text)));
                    Close();
                }
                else
                {
                    var errorMessage = new InputError();
                    errorMessage.Show();
                }
            }
            else
            {
                var errorMessage = new OibAlreadyIn();
                errorMessage.Show();
            }
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
            if (e.KeyValue >= 'A' && e.KeyValue <= 'Z')
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
            if (e.KeyValue >= 'A' && e.KeyValue <= 'Z')
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
