using System;

//Write a program to calculate area of a Rectangle using constructor
class Rectangle
{
    public double Length;
    public double Width;
    public double Area;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
        Area = Length * Width;
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Area of Rectangle: {Area:N2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Rectangle rect = new Rectangle(length, width);
        rect.DisplayArea();
    }
}
