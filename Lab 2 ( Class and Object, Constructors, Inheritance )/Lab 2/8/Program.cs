
//Write a program to Define a class Distance have data members dist1, dist2,
//dist3. Initialize the two data members using constructor and store their
//addition in third data member using function and display addition.


using _8;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first distance: ");
        double d1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second distance: ");
        double d2 = Convert.ToDouble(Console.ReadLine());

        Distance distance = new Distance(d1, d2);
        distance.AddDistances();
        distance.DisplayAddition();
    }
}
