using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Infrastructure.Enums;

namespace Internship_4_Employees.Data.Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName, string oib, DateTime birthDate, Job companyJob)
        {
            FirstName = firstName;
            LastName = lastName;
            Oib = oib;
            BirthDate = birthDate;
            CompanyJob = companyJob;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Oib { get; set; }
        public DateTime BirthDate { get; set; }
        public Job CompanyJob { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}  {Oib}";
        }
    }
}
