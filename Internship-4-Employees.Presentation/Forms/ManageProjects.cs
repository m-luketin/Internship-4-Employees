﻿using System;
using System.Collections.Generic;
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
            if (ProjectListBox.CheckedItems.Count > 0)
            {
                var deletePrompt = new DeleteProjectPrompt().ShowDialog();

                if (deletePrompt == DialogResult.No)
                    return;
            }
                

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

                while (!MockRelations.IsProjectDeleted(projectName))
                {
                    foreach (var relation in MockRelations.GetAllRelations())
                    {
                        if (projectName == relation.ProjectName)
                        {
                            MockRelations.AllRelations.Remove(relation);
                            break;
                        }
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

        private void EditProjectButton_Click(object sender, EventArgs e)
        {
            foreach (var project in ProjectListBox.CheckedItems)
            {
                var editProject = new EditProject(project.ToString());
                editProject.ShowDialog();
            } 
        }

        private void ProjectListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < ProjectListBox.Items.Count; ++ix)
                if (ix != e.Index)
                    ProjectListBox.SetItemChecked(ix, false);
        }
    }
}
