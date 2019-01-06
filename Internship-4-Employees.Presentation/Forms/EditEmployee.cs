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
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                employeesForEdit.Items.Add(employee);
            }
        }

        private void editEmployeeDetails_Click(object sender, EventArgs e)
        {
            foreach (var VARIABLE in employeesForEdit.CheckedItems)
            {
                var editDetails = new EditEmployeeDetails();
                editDetails.Show();
            }
        }

        private void employeesForEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
