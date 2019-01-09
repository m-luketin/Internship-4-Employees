using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class ProjectsAndEmployees : Form
    {
        public ProjectsAndEmployees()
        {
            InitializeComponent();
            foreach (var item in MockProjects.ProjectsAndEmployeesView())
            {
                ProjectsAndEmployeesListbox.Items.Add(item);
            }
            
        }
    }
}
