//7.Write a program to create interface named Shape.In this interface, we
//have three methods Circle(), Triangle() and Square() which calculates area
//of Circle, Triangle and Square respectively. Implement Shape interface.

using _7;
using System;

var calculator = new AreaCalculator();

Console.WriteLine("Choose shape to calculate area:");
Console.WriteLine("1. Circle");
Console.WriteLine("2. Triangle");
Console.WriteLine("3. Square");
Console.Write("Enter your choice (1-3): ");
string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Area of Circle: " + calculator.Circle(radius));
        break;
    case "2":
        Console.Write("Enter base: ");
        double baseValue = double.Parse(Console.ReadLine()!);
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Area of Triangle: " + calculator.Triangle(baseValue, height));
        break;
    case "3":
        Console.Write("Enter side: ");
        double side = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Area of Square: " + calculator.Square(side));
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}