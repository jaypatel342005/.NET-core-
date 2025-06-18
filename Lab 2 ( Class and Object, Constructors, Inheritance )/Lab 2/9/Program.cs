
//Create a class Furniture with material, price as data members. Create
//another class Table with Height, surface_area as data members. Write a
//program to implement single inheritance.


using _9;

class Program
{
    static void Main(string[] args)
    {
        Table table = new Table();
        table.SetTableDetails();
        Console.WriteLine("\nTable Details:");
        table.DisplayTableDetails();
    }
}
