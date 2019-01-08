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
    public partial class ManageProjects : Form
    {
        public ManageProjects()
        {
            InitializeComponent();
            foreach (var project in MockProjects.AllProjects)
            {
                ProjectListBox.Items.Add(project);
            }
        }
        private void RefreshForm()
        {
            ProjectListBox.Items.Clear();
            foreach (var project in MockProjects.AllProjects)
            {
                ProjectListBox.Items.Add(project);
            }
        }
        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            var addProject = new AddProject();
            addProject.ShowDialog();
            RefreshForm();
        }
        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            var checkedProjectNames = new List<string>();
            foreach (var checkedProject in ProjectListBox.CheckedItems)
            {
                checkedProjectNames.Add(checkedProject.ToString());
            }

            foreach (var projectName in checkedProjectNames)
            {
                foreach (var project in MockProjects.GetAllProjects())
                {
                    if (projectName == project.Name)
                    {
                        MockProjects.AllProjects.Remove(project);
                        break;
                    }
                }

                foreach (var relation in MockRelations.GetAllRelations())
                {
                    if (projectName == relation.ProjectName)
                    {
                        MockRelations.AllRelations.Remove(relation);
                        break;
                    }
                }
                RefreshForm();
            }
        }

        private void ViewEmployeesButton_Click(object sender, EventArgs e)
        {
            var projectsAndEmployees = new ProjectsAndEmployees();
            projectsAndEmployees.Show();
        }
    }
}
