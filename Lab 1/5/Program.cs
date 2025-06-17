// See https://aka.ms/new-console-template for more information
//5.Write a program to calculate area of Square, Rectangle and Circle

// Simple program to calculate area of Square, Rectangle, and Circle without using if statements

Console.WriteLine("1. Square");
Console.WriteLine("2. Rectangle");
Console.WriteLine("3. Circle");
Console.Write("Choose shape (1-3): ");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.Write("Side: ");
        double side = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Area: {side * side}");
        break;
    case "2":
        Console.Write("Length: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Area: {length * width}");
        break;
    case "3":
        Console.Write("Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Area: {Math.PI * radius * radius}");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
