using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_Employees.Data.Models
{
    public class Project
    {
        public Project(string name, DateTime beginning, DateTime ending)
        {
            Name = name;
            Beginning = beginning;
            Ending = ending;
        }

        public string Name { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime Ending { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
