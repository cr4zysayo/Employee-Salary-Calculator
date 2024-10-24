using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary_Calculator
{
    public class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }

        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            JobTitle = jobTitle;
        }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            BasicSalary = hoursWorked * ratePerHour;
        }

        public double GetSalary()
        {
            return BasicSalary;
        }
    }
}
//James Vladimir Z. Gacis
