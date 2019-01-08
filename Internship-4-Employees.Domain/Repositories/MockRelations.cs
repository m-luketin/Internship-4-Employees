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
            new RelationProjectEmployee("Military", "58765811548", 50),
            new RelationProjectEmployee("eLearning", "84617852734", 20)
        };


        public static bool NotSoloOnProject(string oib)
        {
            var flag = 0;
            foreach (var relation in AllRelations)
            {
                if (oib == relation.EmployeeOib)
                {
                    flag = 1;
                    var tmpProject = relation.ProjectName;
                    foreach (var rel2 in AllRelations)
                    {
                        if (tmpProject == rel2.ProjectName && oib != rel2.EmployeeOib)
                        {
                            return true;
                        }
                    }
                }
                
            }
            if (flag == 1)
                return false;
            else
                return true;
        }

        public static List<RelationProjectEmployee> GetAllRelations()
        {
            return AllRelations;
        }

        public static bool IsEmployeeOnProject(string oib)
        {
            foreach (var relation in AllRelations)
            {
                if (oib == relation.EmployeeOib)
                    return true;
            }

            return false;
        }
    }
}