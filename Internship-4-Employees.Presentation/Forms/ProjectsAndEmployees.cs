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
    public partial class ProjectsAndEmployees : Form
    {
        public ProjectsAndEmployees()
        {
            InitializeComponent();
            foreach (var item in MockProjects.ProjectsAndEmployeesView(MockEmployees.AllEmployees, MockRelations.AllRelations))
            {
                ProjectsAndEmployeesListbox.Items.Add(item);
            }
            
        }
    }
}
