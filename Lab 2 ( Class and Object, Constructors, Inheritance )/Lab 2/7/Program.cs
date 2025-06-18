// See https://aka.ms/new-console-template for more information

//Write a program to Define a class Salary which will contain member
//variable Basic, TA, DA, HRA. Write a program using Constructor with default
//values for DA and HRA and calculate the salary of employee.


using _7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Basic Salary: ");
        decimal basic = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter TA: ");
        decimal ta = Convert.ToDecimal(Console.ReadLine());

        Salary empSalary = new Salary(basic, ta);
        empSalary.DisplaySalary();
    }
}
