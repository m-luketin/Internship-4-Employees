using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship_4_Employees.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void viewEmployeesButton_Click(object sender, EventArgs e)
        {
            var viewEmployeesForm = new ViewEmployees();
            viewEmployeesForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var editEmployeeForm = new EditEmployee();
            editEmployeeForm.Show();
        }

        private void addEmployeesButton_Click(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddEmployees();
            addEmployeeForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var deleteEmployeesForm = new DeleteEmployees();
            deleteEmployeesForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var viewProjectsForm = new ViewProjects();
            viewProjectsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var editProjects = new EditProjects();
            editProjects.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var deleteProjects = new DeleteProjects();
            deleteProjects.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addProjects = new AddProjects();
            addProjects.Show();
        }
    }
}
