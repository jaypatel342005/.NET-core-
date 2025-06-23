//Write a program to Create a divide by zero exception and handle it.

try
{
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
