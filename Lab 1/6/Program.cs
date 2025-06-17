// See https://aka.ms/new-console-template for more information
// Program to convert Celsius to Fahrenheit and vice-versa using functions

static double CelsiusToFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double FahrenheitToCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

Console.WriteLine("1. Celsius to Fahrenheit");
Console.WriteLine("2. Fahrenheit to Celsius");
Console.Write("Choose conversion (1-2): ");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine($"Fahrenheit: {fahrenheit}");
        break;
    case "2":
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahr = Convert.ToDouble(Console.ReadLine());
        double cels = FahrenheitToCelsius(fahr);
        Console.WriteLine($"Celsius: {cels}");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
