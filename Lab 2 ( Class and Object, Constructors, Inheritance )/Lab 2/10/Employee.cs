using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Employee
    {
        public string Name;
        public decimal Basic;

        public void basic_sal()
        {
            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Basic Salary: ");
            Basic = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
