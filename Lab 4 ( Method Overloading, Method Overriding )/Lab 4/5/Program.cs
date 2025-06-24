//Write a programs to Find Area of Square, Rectangle and Circle using
//Method Overloading.

using System;

class AreaCalculator
{
    
    public double Area(double side)
    {
        return side * side;
    }

    
    public double Area(double length, double width)
    {
        return length * width;
    }

    
    public double Area(float radius)
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main()
    {
        AreaCalculator calc = new AreaCalculator();

        double squareArea = calc.Area(5.0);
        double rectangleArea = calc.Area(5.0, 10.0);
        double circleArea = calc.Area(7.0f);

        Console.WriteLine($"Area of Square: {squareArea}");
        Console.WriteLine($"Area of Rectangle: {rectangleArea}");
        Console.WriteLine($"Area of Circle: {circleArea:F2}");
    }
}