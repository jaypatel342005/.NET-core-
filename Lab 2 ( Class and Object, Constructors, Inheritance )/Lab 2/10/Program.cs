
//10.Program to implement the following multiple inheritance using interface
//Interface : Gross
//Method- Gross_sal()
//Class : Salary
//Data Members - HRA, TA, DA
//Methods - Disp_sal()
//Class : Employee
//Data Members - Name
//Methods - basic_sal()


using _10;

class Program
{
    static void Main(string[] args)
    {
        Salary emp = new Salary();
        emp.basic_sal();
        emp.Disp_sal();
        emp.DisplayAll();
    }
}