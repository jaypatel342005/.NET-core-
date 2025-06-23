//Write a program that reads 5 numbers from user. Demonstrate concept of
//IndexOutOfRange Exception.

using System;

int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine()!);
}

try
{
    Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("IndexOutOfRangeException caught: Tried to access an index outside the array bounds.");
}

