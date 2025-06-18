using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Staff
    {
        
        public string Name;
        public string Department;
        public string Designation;
        public int Experience;
        public decimal Salary;

        
        public void GetStaffDetails()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine() ;

            Console.Write("Department: ");
            Department = Console.ReadLine() ;

            Console.Write("Designation: ");
            Designation = Console.ReadLine();

            Console.Write("Experience (years): ");
            int.TryParse(Console.ReadLine(), out Experience);

            Console.Write("Salary: ");
            decimal.TryParse(Console.ReadLine(), out Salary);
        }

    }
}
