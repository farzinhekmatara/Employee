/*
 * Tankemässigt vet jag hur jag ska gå till väga. Problemet är mest hur man 
 * kan uttrycka sig i denna miljö. jag saknar main funktionen och var programmet ska starta.
 */



using System;

string name="";
int salary=0;
Console.WriteLine("Enter Name:");
//Här vill jag läsa in från systeminput men vet inte hur man gör i C#.
//name=Console.ReadLine()
try
{
    name = Console.ReadLine();
}
catch (Exception)
{

}
Console.WriteLine("Enter Salary");
//Här vill jag läsa in från systeminput men vet inte hur man gör i C#.
//salary=Console.ReadLine()
try
{
    Console.ReadLine();
}catch (Exception)
{

}
Employee employee = new Employee(name,salary);
Console.WriteLine("Name " + employee.firstName+ "salary " + employee.employeeSalary);

public class Employee
{
    public string firstName;
    public int employeeSalary;

    public Employee(string name, int salary )
    {
        this.firstName = name;
        this.employeeSalary = salary;
    }

}

