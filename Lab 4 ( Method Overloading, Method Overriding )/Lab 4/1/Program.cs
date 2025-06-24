//Write a program using method overloading by changing datatype of
//arguments to perform addition of two integer numbers and two float
//numbers.  

using System;

class Program
{
   
    static int Add(int a, int b)
    {
        return a + b;
    }

   
    static float Add(float a, float b)
    {
        return a + b;
    }

    static void Main()
    {
        int intResult = Add(5, 10);
        float floatResult = Add(5.5f, 10.2f);

        Console.WriteLine("Sum of two integers: " + intResult);
        Console.WriteLine("Sum of two floats: " + floatResult);
    }
}