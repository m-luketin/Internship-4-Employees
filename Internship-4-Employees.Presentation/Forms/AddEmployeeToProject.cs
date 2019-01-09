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
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class AddEmployeeToProject : Form
    {
        public AddEmployeeToProject(string projectName)
        {
            InitializeComponent();
            ProjectTextBox.Text = projectName;
            foreach (var employee in MockEmployees.AllEmployees)
            {
                EmployeeListBox.Items.Add(employee);
            }
        }
        private void EmployeeListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < EmployeeListBox.Items.Count; ++ix)
                if (ix != e.Index)
                    EmployeeListBox.SetItemChecked(ix, false);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var oibRegex = new Regex(@"\d{11}");

            foreach (var item in EmployeeListBox.CheckedItems)
            {
                foreach (var relation in MockRelations.GetAllRelations())
                {
                
                    if (HoursTextBox.Text == "")
                    {
                        var errorMessage = new InputError();
                        errorMessage.Show();
                        break;
                    }

                    if (oibRegex.Match(item.ToString()).Value == relation.EmployeeOib &&
                        ProjectTextBox.Text == relation.ProjectName)
                    {
                        var errorMessage = new AlreadyOnProjectError();
                        errorMessage.Show();
                        break;
                    }

                    MockRelations.AllRelations.Add(new RelationProjectEmployee(ProjectTextBox.Text,
                        oibRegex.Match(item.ToString()).Value, int.Parse(HoursTextBox.Text)));
                    break;
                }
            }
            Close();
        }

        private void HoursTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= '0' && e.KeyValue <= '9' && HoursTextBox.TextLength < 2)
            {
                HoursTextBox.Text += e.KeyValue - 48;
            }
            else if ((e.KeyCode & Keys.Back) != 0)
                HoursTextBox.Text = "";
        }
    }
}
