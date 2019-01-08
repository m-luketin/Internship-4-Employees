using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                EmployeeListBox.Items.Add(employee);
            }

            foreach (var project in MockProjects.AllProjects)
            {
                ProjectListBox.Items.Add(project);
            }
        }

        public void RefreshForm()
        {
            EmployeeListBox.Items.Clear();
            ProjectListBox.Items.Clear();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                EmployeeListBox.Items.Add(employee);
            }

            foreach (var project in MockProjects.AllProjects)
            {
                ProjectListBox.Items.Add(project);
            }
        }
        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageEmployeesButton_Click(object sender, EventArgs e)
        {
            var manageEmployees = new ManageEmployees();
            manageEmployees.Show();
            RefreshForm();
        }

        private void ManageProjectsButton_Click(object sender, EventArgs e)
        {
            var manageProjects = new ManageProjects();
            manageProjects.Show();
            RefreshForm();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
