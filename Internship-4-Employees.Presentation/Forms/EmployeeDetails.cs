using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Data.Models;

namespace Internship_4_Employees.Forms
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails(Employee exampleEmployee)
        {
            InitializeComponent();
            firstNameTextBox.Text = exampleEmployee.FirstName;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
