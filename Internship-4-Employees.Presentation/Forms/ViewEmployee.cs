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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee(string employeeOib)
        {
            InitializeComponent();
            ViewEmployeeTextBox.Text += MockEmployees.GetFirstName(employeeOib) + " " + MockEmployees.GetLastName(employeeOib) 
                                        + " " + employeeOib + "\n" + MockRelations.GetEmployeeHours(employeeOib) + " hours this week\n"
                                        + MockRelations.NumberOfActiveProjects(employeeOib) + " active projects\n"
                                        + MockRelations.NumberOfFinishedProjects(employeeOib) + " finished projects\n"
                                        + MockRelations.NumberOfPlannedProjects(employeeOib) + " future projects\n";
            if(int.Parse(MockRelations.GetEmployeeHours(employeeOib)) < 30)
                ViewEmployeeTextBox.BackColor = Color.Yellow;
            else if (int.Parse(MockRelations.GetEmployeeHours(employeeOib)) >= 30 &&
                     int.Parse(MockRelations.GetEmployeeHours(employeeOib)) < 41)
                ViewEmployeeTextBox.BackColor = Color.Green;
            else
            {
                ViewEmployeeTextBox.BackColor = Color.Red;
            }

        }       
    }
}
