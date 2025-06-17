// See https://aka.ms/new-console-template for more information

// Write a program to calculate the size of the area in square-feet based on specified length and width.

Console.Write("Enter the length in feet: ");
double length = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the width in feet: ");
double width = Convert.ToDouble(Console.ReadLine());

double area = length * width;

Console.WriteLine($"The area is {area} square feet.");
