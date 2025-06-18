// See https://aka.ms/new-console-template for more information

//Write a pogram to Create a class Bank_Account with Account_No, Email,
//User_Name, Account_Type and Account_Balance as data members. Also
//create a Member function GetAccountDetails() & DisplayAccountDetails().

using _3;

class Program
{
    static void Main(string[] args)
    {
        Bank_Account account = new Bank_Account();
        account.GetAccountDetails();
        account.DisplayAccountDetails();
    }
}
