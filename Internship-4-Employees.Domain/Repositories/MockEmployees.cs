﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Data.Models;
using Internship_4_Employees.Infrastructure.Enums;

namespace Internship_4_Employees.Domain.Repositories
{
    public static class MockEmployees
    {
        public static List<Employee> AllEmployees = new List<Employee>()
        {
            new Employee("Marko", "Markic", "88917811528", new DateTime(1997, 12, 7), Job.Designer),
            new Employee("Ivo", "Ivic", "83411231231", new DateTime(1986, 5, 31), Job.HR),
            new Employee("Matija", "Luketin", "67123811521", new DateTime(1951, 4, 22), Job.Programmer),
            new Employee("Ante", "Vuletic", "28917811548", new DateTime(1999, 12, 17), Job.SysAdmin),
            new Employee("Alex", "Amanzi", "84617852734", new DateTime(1987, 4, 19), Job.Slicer),
            new Employee("Pero", "Peric", "58765811548", new DateTime(1957, 6, 2), Job.Accountant)
        };

        public static void AddEmployee(Employee newEmployee)
        {
            AllEmployees.Add(newEmployee);
        }

        public static void RemoveEmployee(string oibForRemoval)
        {
            foreach (var employee in AllEmployees)
            {
                if (employee.Oib == oibForRemoval)
                    AllEmployees.Remove(employee);
            }
        }

        

    }
}