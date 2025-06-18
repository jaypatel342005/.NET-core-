using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Account_Details
    {
        public int Account_No;
        public string Account_Holder;
        public decimal Balance;
        public double Rate;
        public int Years;

        public void GetAccountInfo()
        {
            Console.Write("Enter Account Number: ");
            Account_No = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Holder Name: ");
            Account_Holder = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Balance: ");
            Balance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Interest Rate (% per annum): ");
            Rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number of Years: ");
            Years = Convert.ToInt32(Console.ReadLine());
        }

    }

    class Interest : Account_Details
    {
        public decimal CalculateInterest()
        {
            // Simple Interest = (Principal * Rate * Time) / 100
            return Balance * (decimal)Rate * Years / 100;
        }

        public void DisplayInterest()
        {
            decimal interest = CalculateInterest();
            Console.WriteLine();
            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account Number: {Account_No}");
            Console.WriteLine($"Account Holder: {Account_Holder}");
            Console.WriteLine($"Balance: {Balance:N2}");
            Console.WriteLine($"Interest Rate: {Rate}%");
            Console.WriteLine($"Years: {Years}");
            Console.WriteLine($"Total Interest: {interest:N2}");
        }
    }



}
