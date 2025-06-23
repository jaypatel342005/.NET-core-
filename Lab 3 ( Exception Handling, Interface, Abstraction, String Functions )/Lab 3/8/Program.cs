

// Write a program to accept a number from the user and throw an exception if the number is not an even number

using System;

Console.Write("Enter a number: ");
if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Invalid input.");
    return;
}

try
{
    if (number % 2 != 0)
        throw new Exception("The number is not even.");
    Console.WriteLine("The number is even.");
}
catch (Exception ex)
{
    Console.WriteLine("Exception: " + ex.Message);
}

