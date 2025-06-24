//Write a program using method overloading by changing number of
//arguments to calculate area of square and rectangle.

using System;

class Program
{
   
    static int Area(int side)
    {
        return side * side;
    }

  
    static int Area(int length, int breadth)
    {
        return length * breadth;
    }

    static void Main()
    {
        int squareArea = Area(5);
        int rectangleArea = Area(5, 10);

        Console.WriteLine("Area of square: " + squareArea);
        Console.WriteLine("Area of rectangle: " + rectangleArea);
    }
}
