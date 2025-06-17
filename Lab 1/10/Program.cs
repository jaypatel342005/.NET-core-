// See https://aka.ms/new-console-template for more information
// Program to find the maximum of three numbers using the ternary operator

Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

Console.WriteLine($"Maximum number is: {max}");
