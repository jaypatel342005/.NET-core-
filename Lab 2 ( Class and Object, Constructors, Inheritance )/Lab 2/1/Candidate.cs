using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Candidate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; } // in kilograms
        public double Height { get; set; } // in centimeters

        
        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Candidate Details:");

            Console.Write("ID: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Weight (kg): ");
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height (cm): ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

     
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("\nCandidate Details:");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight:F1} kg");
            Console.WriteLine($"Height: {Height:F1} cm");
        }
    }
}
