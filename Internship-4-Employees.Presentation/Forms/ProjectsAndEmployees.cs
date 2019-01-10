using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;
using Internship_4_Employees.Infrastructure.Enums;

namespace Internship_4_Employees.Forms
{
    public partial class ProjectsAndEmployees : Form
    {
        public ProjectsAndEmployees()
        {
            InitializeComponent();
            var projectJobsList = new List<List<Job>>();

            foreach (var project in MockProjects.AllProjects)
            {
                var jobsList = new List<Job>();
                foreach (var relation in MockRelations.AllRelations)
                {
                    if (project.Name == relation.ProjectName)
                    {
                        if (!jobsList.Contains((Job) Enum.Parse(typeof(Job), MockEmployees.GetJob(relation.EmployeeOib))))
                            jobsList.Add((Job) Enum.Parse(typeof(Job), MockEmployees.GetJob(relation.EmployeeOib)));

                    }
                }
                projectJobsList.Add(jobsList);
            }

            var i = 0;
            foreach (var jobList in projectJobsList)
            {
                ProjectsAndEmployeesListbox.Items.Add("\n");
                ProjectsAndEmployeesListbox.Items.Add("____________________" + MockProjects.AllProjects[i] + "______________________");

                foreach (var job in jobList)
                {
                    ProjectsAndEmployeesListbox.Items.Add(job + "s");
                    foreach (var employee in MockEmployees.AllEmployees)
                    {
                        if (MockRelations.IsEmployeeOnProject(employee.Oib, MockProjects.AllProjects[i].Name) &&
                            employee.CompanyJob == job)
                            ProjectsAndEmployeesListbox.Items.Add("\t" + employee.FirstName + " " + employee.LastName);
                    }
                }
                i++;
            }

            ProjectsAndEmployeesListbox.Items.Add("________________________________________________");
        }
    }
}
