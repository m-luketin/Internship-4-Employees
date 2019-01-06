using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_4_Employees.Data.Models;

namespace Internship_4_Employees.Domain.Repositories
{
    public static class MockProjects
    {
        public static List<Project> AllProjects = new List<Project>()
        {

            new Project("Split page", new DateTime(2018,12,10),new DateTime(2019, 1, 11)),
            new Project("ARK", new DateTime(2008,12,10),new DateTime(2010, 10, 8)),
            new Project("Military", new DateTime(2018,1,10),new DateTime(2018, 10, 18)),
            new Project("eLearning", new DateTime(2017,12,10),new DateTime(2018, 1, 12))
        };
    }
}
