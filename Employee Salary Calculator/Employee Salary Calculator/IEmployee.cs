using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary_Calculator
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }

        void ComputeSalary(int hoursWorked, double ratePerHour);
    }
}

