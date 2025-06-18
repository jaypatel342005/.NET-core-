using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Table : Furniture
    {
        public double Height;
        public double surface_area;

        public void SetTableDetails()
        {
            SetFurnitureDetails();

            Console.Write("Enter height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter surface area: ");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayTableDetails()
        {
            DisplayFurnitureDetails();
            Console.WriteLine($"Height: {Height:N2}");
            Console.WriteLine($"Surface Area: {surface_area:N2}");
        }
    }
}
