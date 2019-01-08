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
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                EmployeeCheckedListBox.Items.Add(employee);
            }
        }

        private void RefreshForm()
        {
            EmployeeCheckedListBox.Items.Clear();
            foreach (var employee in MockEmployees.AllEmployees)
            {
                EmployeeCheckedListBox.Items.Add(employee);
            }
        }
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            RefreshForm();
        }
        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            var checkedEmployeeOibList = new List<string>();
            var oibRegex = new Regex(@"\d{11}");

            foreach (var checkedEmployee in EmployeeCheckedListBox.CheckedItems)
            {
                checkedEmployeeOibList.Add(oibRegex.Match(checkedEmployee.ToString()).Value);
            }

            foreach (var oib in checkedEmployeeOibList)
            {
                if (MockRelations.NotSoloOnProject(oib))
                {
                    foreach (var relation in MockRelations.GetAllRelations())
                    {
                        if (oib == relation.EmployeeOib)
                        {
                            MockRelations.AllRelations.Remove(relation);
                            break;
                        }
                    }
                
                    foreach (var employee in MockEmployees.GetAllEmployees())
                    {
                        if (oib == employee.Oib)
                        {
                            MockEmployees.AllEmployees.Remove(employee);
                        }
                    }
                }
                else
                {
                    var soloWarning = new EmployeeIsSolo();
                    soloWarning.Show();
                }
            }
            
            RefreshForm();
        }
    }
}
