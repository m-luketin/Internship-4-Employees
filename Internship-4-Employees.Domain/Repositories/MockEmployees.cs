using System;
using System.Collections.Generic;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Infrastructure.Enums;

namespace Internship_4_Employees.Domain.Repositories
{
    public static class MockEmployees
    {
        public static List<Employee> AllEmployees = new List<Employee>()
        {
            new Employee("Marko", "Markic", "88917811528", new DateTime(1997, 12, 7), Job.Programmer),
            new Employee("Ivo", "Ivic", "83411231231", new DateTime(1986, 5, 31), Job.HR),
            new Employee("Matija", "Luketin", "67123811521", new DateTime(1951, 4, 22), Job.Programmer),
            new Employee("Ante", "Vuletic", "28917811548", new DateTime(1999, 12, 17), Job.SysAdmin),
            new Employee("Alex", "Amanzi", "84617852734", new DateTime(1987, 4, 19), Job.Programmer),
            new Employee("Ivan", "Ivanovic", "51761231548", new DateTime(1957, 6, 2), Job.Accountant),
            new Employee("Marija", "Maric", "18765811548", new DateTime(1957, 6, 2), Job.Designer),
            new Employee("Petar", "Peric", "38765822548", new DateTime(1957, 6, 2), Job.Programmer),
            new Employee("Anton", "Antic", "42765832148", new DateTime(1957, 6, 2), Job.Accountant)
        };
        public static bool AlreadyInList(string oib)
        {
            foreach (var employee in AllEmployees)
            {
                if (oib == employee.Oib)
                    return true;
            }
            return false;
        }
        public static List<Employee> GetAllEmployees()
        {
            return AllEmployees;
        }
        public static string GetFirstName(string oib)
        {
            foreach (var employee in AllEmployees)
            {
                if (employee.Oib == oib)
                    return employee.FirstName;
            }
            return null;
        }
        public static string GetLastName(string oib)
        {
            foreach (var employee in AllEmployees)
            {
                if (employee.Oib == oib)
                    return employee.LastName;
            }
            return null;
        }

        public static DateTime GetBirthDate(string oib)
        {
            foreach (var employee in AllEmployees)
            {
                if (employee.Oib == oib)
                    return employee.BirthDate;
            }
            return new DateTime(0, 0, 0);
        }

        public static string GetJob(string oib)
        {
            foreach (var employee in AllEmployees)
            {
                if (employee.Oib == oib)
                    return employee.CompanyJob.ToString();
            }
            return null;
        }
    }
}
