using System;
using System.Collections.Generic;
using Internship_4_Employees.Data.Models;

namespace Internship_4_Employees.Domain.Repositories
{
    public static class MockRelations
    {
        public static List<RelationProjectEmployee> AllRelations= new List<RelationProjectEmployee> {
            new RelationProjectEmployee("Split page", "88917811528", 20),
            new RelationProjectEmployee("Split page", "58765811548", 20),
            new RelationProjectEmployee("ARK", "67123811521", 10),
            new RelationProjectEmployee("eLearning", "67123811521", 10),
            new RelationProjectEmployee("Military", "58765811548", 50),
            new RelationProjectEmployee("eLearning", "84617852734", 20),
            new RelationProjectEmployee("ARK", "84617852734", 20)
        };
        public static bool IsEmployeeDeleted(string oib)
        {
            foreach (var relation in AllRelations)
            {
                if (relation.EmployeeOib == oib)
                    return false;
            }
            return true;
        }
        public static bool IsProjectDeleted(string projectName)
        {
            foreach (var relation in AllRelations)
            {
                if (relation.ProjectName == projectName)
                    return false;
            }
            return true;
        }
        public static bool SoloOnProject(string oib)
        {
            var flag = 0;
            var employeeProjects = new List<string>();
            foreach (var relation in AllRelations)
            {
                if (oib == relation.EmployeeOib)
                    employeeProjects.Add(relation.ProjectName);
            }
            foreach (var project in employeeProjects)
            {
                foreach (var relation in AllRelations)
                {
                    if (project == relation.ProjectName && oib != relation.EmployeeOib)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                    return true;
                else
                    flag = 0;
            }
            return false;
        }
        public static List<RelationProjectEmployee> GetAllRelations()
        {
            return AllRelations;
        }
        public static string GetEmployeeHours(string employeeOib)
        {
            var hoursTotal = 0;
            foreach (var relation in AllRelations)
            {
                if (relation.EmployeeOib == employeeOib && IsProjectCurrentlyActive(relation.ProjectName))
                    hoursTotal += relation.HoursAWeek;
            }
            return hoursTotal.ToString();
        }
        public static bool IsProjectCurrentlyActive(string projectName)
        {
            foreach (var project in MockProjects.AllProjects)
            {
                if (project.Name == projectName)
                    return(DateTime.Compare(project.Ending, DateTime.Now) > 0 &&
                        DateTime.Compare(project.Beginning, DateTime.Now) < 0);
            }
            return false;
        }
        public static bool IsProjectOver(string projectName)
        {
            foreach (var project in MockProjects.AllProjects)
            {
                if (project.Name == projectName)
                    return (DateTime.Compare(project.Ending, DateTime.Now) < 0 &&
                            DateTime.Compare(project.Beginning, DateTime.Now) < 0);
            }
            return false;
        }
        public static bool IsProjectPlanned(string projectName)
        {
            foreach (var project in MockProjects.AllProjects)
            {
                if (project.Name == projectName)
                    return (DateTime.Compare(project.Ending, DateTime.Now) > 0 &&
                            DateTime.Compare(project.Beginning, DateTime.Now) > 0);
            }
            return false;
        }
        public static int NumberOfActiveProjects(string employeeOib)
        {
            var count = 0;
            foreach (var relation in AllRelations)
            {
                if (employeeOib == relation.EmployeeOib && IsProjectCurrentlyActive(relation.ProjectName))
                    count++;
            }
            return count;
        }
        public static int NumberOfFinishedProjects(string employeeOib)
        {
            var count = 0;
            foreach (var relation in AllRelations)
            {
                if (employeeOib == relation.EmployeeOib && IsProjectOver(relation.ProjectName))
                    count++;
            }
            return count;
        }
        public static int NumberOfPlannedProjects(string employeeOib)
        {
            var count = 0;
            foreach (var relation in AllRelations)
            {
                if (employeeOib == relation.EmployeeOib && IsProjectPlanned(relation.ProjectName))
                    count++;
            }
            return count;
        }
    }
}