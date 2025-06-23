// Write a program to create an abstract class Sum having abstract methods
//SumOfTwo(int a, int b) and SumOfThree(int a, int b, int c). Create another
//class Calculate which extends the abstract class and implements the
//abstract methods.


using _3;

Console.WriteLine("Hello, World!");

var calc = new Calculate();
Console.WriteLine(calc.SumOfTwo(5, 10));
Console.WriteLine(calc.SumOfThree(1, 2, 3));
