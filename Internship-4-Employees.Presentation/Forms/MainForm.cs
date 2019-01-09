using System;
using System.Windows.Forms;

namespace Internship_4_Employees.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ManageEmployeesButton_Click(object sender, EventArgs e)
        {
            var manageEmployees = new ManageEmployees();
            manageEmployees.Show();
        }
        private void ManageProjectsButton_Click(object sender, EventArgs e)
        {
            var manageProjects = new ManageProjects();
            manageProjects.Show();
        }
    }
}
