using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Salary : Employee, Gross
    {
        public decimal HRA;
        public decimal TA;
        public decimal DA;

        public void Disp_sal()
        {
            Console.Write("Enter HRA: ");
            HRA = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter TA: ");
            TA = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter DA: ");
            DA = Convert.ToDecimal(Console.ReadLine());
        }

        public decimal Gross_sal()
        {
            return Basic + HRA + TA + DA;
        }

        public void DisplayAll()
        {
            Console.WriteLine();
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Basic Salary: {Basic:N2}");
            Console.WriteLine($"HRA: {HRA:N2}");
            Console.WriteLine($"TA: {TA:N2}");
            Console.WriteLine($"DA: {DA:N2}");
            Console.WriteLine($"Gross Salary: {Gross_sal():N2}");
        }
    }
}
