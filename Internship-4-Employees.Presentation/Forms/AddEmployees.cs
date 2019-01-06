﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Infrastructure.Enums;

namespace Internship_4_Employees.Forms
{
    public partial class AddEmployees : Form
    {
        public AddEmployees()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveEmployeeButton_Click(object sender, EventArgs e)
        {
            var job = (Job)System.Enum.Parse(typeof(Job), jobTextBox.Text);
            var newEmployee = new Employee(firstNameTextBox.Text, lastNameTextBox.Text, oibTextBox.Text, birthDatePicker.Value, job);
            MockEmployees.AllEmployees.Add(newEmployee);
        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}