namespace Internship_4_Employees.Data.Models
{
    public class RelationProjectEmployee
    {
        public RelationProjectEmployee(string projectName, string employeeOib, int hoursAWeek)
        {
            ProjectName = projectName;
            EmployeeOib = employeeOib;
            HoursAWeek = hoursAWeek;
        }

        public string ProjectName { get; set; }
        public string EmployeeOib { get; set; }
        public int HoursAWeek { get; set; }
    }
}