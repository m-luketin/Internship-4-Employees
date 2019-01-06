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
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                viewEmployeesListBox.Items.Add(employee);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var editEmployee = new EditEmployee();
            editEmployee.Show();
        }
    }
}
