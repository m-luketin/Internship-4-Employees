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
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class DeleteEmployees : Form
    {
        public DeleteEmployees()
        {
            InitializeComponent();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                deleteEmployeeListBox.Items.Add(employee);
            }
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
        
        }

        private void deleteEmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
