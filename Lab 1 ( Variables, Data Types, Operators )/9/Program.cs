// See https://aka.ms/new-console-template for more information
// Program to swap two numbers without using a third variable

Console.Write("Enter first number (a): ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number (b): ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Before swapping: a = {a}, b = {b}");

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"After swapping: a = {a}, b = {b}");
