//Write a program to Replace lower case characters to upper case and Vice-versa.

using System;

Console.Write("Enter a string: ");
string input = Console.ReadLine()!;
char[] result = new char[input.Length];

for (int i = 0; i < input.Length; i++)
{
    char c = input[i];
    if (char.IsLower(c))
        result[i] = char.ToUpper(c);
    else if (char.IsUpper(c))
        result[i] = char.ToLower(c);
    else
        result[i] = c;
}

string output = new string(result);
Console.WriteLine("Converted string: " + output);
