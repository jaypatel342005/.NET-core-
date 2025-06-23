using System;

//Write a program to find the longest word in a string.

Console.Write("Enter a string: ");
string input = Console.ReadLine()!;

string[] words = input.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

string longestWord = "";
foreach (var word in words)
{
    if (word.Length > longestWord.Length)
        longestWord = word;
}

Console.WriteLine("Longest word: " + longestWord);