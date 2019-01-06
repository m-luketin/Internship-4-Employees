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
    }
}