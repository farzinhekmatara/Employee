using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeInfo
    {
        private string firstName;
        private int salary;

        public EmployeeInfo()
        {

        }

        public EmployeeInfo(string firstname, int salary)
        {
            this.firstName = firstname;
            this.salary = salary;
        }

        public string GetName()
        {
            return this.firstName;
        }

        public int GetSalary()
        {
            return this.salary;
        }

        
    }
}
