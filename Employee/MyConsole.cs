using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal static class MyConsole
    {
        public static void StartConsole()
        {
            ListOfEmployee list = new ListOfEmployee();
            int input;
            do {
                Console.WriteLine("1. Registrera anställd");
                Console.WriteLine("2. Skriv ut registret");
                Console.WriteLine("3. Avsluta");
                Console.WriteLine("***** Vad vill du göra?*****");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Registrera anställd:");
                        Console.WriteLine("Namn:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Lön :");
                        string salary = Console.ReadLine();
                        list.AddEmployee(name, int.Parse(salary));
                        Console.WriteLine("*****Anställd har sparats********");
                        break;
                    case 2:
                        Console.WriteLine("*****Skriver ut anställda *******");
                        list.PrintEmployees();                        
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }

            } while (input != 3) ;
        }


        public static void DisplayEmployee()
        {
            Console.WriteLine("Name " + new EmployeeInfo().GetName() + "salary " + new EmployeeInfo().GetSalary());
        }
    }



}
