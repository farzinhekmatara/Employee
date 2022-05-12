using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class ListOfEmployee
    {
        private List<EmployeeInfo> employeeList;
        public ListOfEmployee()
        {
            employeeList = new List<EmployeeInfo>();
            InitEmployeeList();
        }     

        public void InitEmployeeList()
        {
            employeeList.Add(new EmployeeInfo("Farzin",45000));
            employeeList.Add(new EmployeeInfo("Lukas", 60000));
            employeeList.Add(new EmployeeInfo("Kalle", 28000));
            employeeList.Add(new EmployeeInfo("Filp", 20000));

        }

        public void AddEmployee(String name,int salary)
        {
            employeeList.Add(new EmployeeInfo(name, salary));
        }

        public void PrintEmployees()
        {
            foreach (var EmployeeInfo in employeeList)
            {
                Console.WriteLine(EmployeeInfo.GetName()+ " " + EmployeeInfo.GetSalary());
            }

        }
    }


}
