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
    public partial class AddProjects : Form
    {
        public AddProjects()
        {
            InitializeComponent();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                employeesOnProjectListBox.Items.Add(employee);
            }
        }

        private void employeesOnProjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
