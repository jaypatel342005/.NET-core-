//Write a program to change the case of entered character.

Console.Write("Enter a character: ");
char c = Console.ReadKey().KeyChar;
Console.WriteLine();

if (char.IsLower(c))
    Console.WriteLine("Changed case: " + char.ToUpper(c));
else if (char.IsUpper(c))
    Console.WriteLine("Changed case: " + char.ToLower(c));
else
    Console.WriteLine("Not an alphabetic character.");