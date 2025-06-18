// See https://aka.ms/new-console-template for more information



//Write a program for implementing single inheritance which creates one
//class Account_Details for getting account information and another class
//Interest for calculating and displaying total interest from the data inserted
//from account details.

using _6;

class Program
{
    static void Main(string[] args)
    {
        Interest acc = new Interest();
        acc.GetAccountInfo();
        acc.DisplayInterest();
    }
}