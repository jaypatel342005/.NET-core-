using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Furniture
    {
        public string material;
        public decimal price;

        public void SetFurnitureDetails()
        {
            Console.Write("Enter material: ");
            material = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter price: ");
            price = Convert.ToDecimal(Console.ReadLine());
        }

        public void DisplayFurnitureDetails()
        {
            Console.WriteLine($"Material: {material}");
            Console.WriteLine($"Price: {price:N2}");
        }
    }
}
