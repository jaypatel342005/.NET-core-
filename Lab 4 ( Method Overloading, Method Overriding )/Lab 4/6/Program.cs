//Create a BankAccount class having constructor accepting initialBalance and
//accountHolderName. Also create Deposite() and withdraw() overloaded
//methods by which user can deposit/withdraw amount using different types
////of parameters(ex.cash, check).
///

using System;

class BankAccount
{
    private string accountHolderName;
    private double balance;

    public BankAccount(string accountHolderName, double initialBalance)
    {
        this.accountHolderName = accountHolderName;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"\n[✅] Cash deposited: ₹{amount}. New Balance: ₹{balance}\n");
    }

    public void Deposit(string checkNumber, double amount)
    {
        balance += amount;
        Console.WriteLine($"\n[✅] Check #{checkNumber} deposited: ₹{amount}. New Balance: ₹{balance}\n");
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine($"\n[❌] Insufficient balance for cash withdrawal.\n");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"\n[✅] Cash withdrawn: ₹{amount}. New Balance: ₹{balance}\n");
        }
    }

    public void Withdraw(string checkNumber, double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine($"\n[❌] Insufficient balance for check withdrawal #{checkNumber}.\n");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"\n[✅] Check #{checkNumber} withdrawal: ₹{amount}. New Balance: ₹{balance}\n");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"\n[ℹ️] Account Holder: {accountHolderName}, Current Balance: ₹{balance}\n");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Account Holder Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Initial Balance: ₹");
        double initial = Convert.ToDouble(Console.ReadLine());

        BankAccount acc = new BankAccount(name, initial);

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=========== BANK MENU ===========");
            Console.WriteLine("1. Deposit Cash");
            Console.WriteLine("2. Deposit by Check");
            Console.WriteLine("3. Withdraw Cash");
            Console.WriteLine("4. Withdraw by Check");
            Console.WriteLine("5. Display Balance");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine("----------------------------------");

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Cash Amount to Deposit: ₹");
                    double cashDep = Convert.ToDouble(Console.ReadLine());
                    acc.Deposit(cashDep);
                    break;

                case "2":
                    Console.Write("Enter Check Number: ");
                    string depCheckNo = Console.ReadLine();
                    Console.Write("Enter Amount: ₹");
                    double checkDepAmt = Convert.ToDouble(Console.ReadLine());
                    acc.Deposit(depCheckNo, checkDepAmt);
                    break;

                case "3":
                    Console.Write("Enter Cash Amount to Withdraw: ₹");
                    double cashWithdraw = Convert.ToDouble(Console.ReadLine());
                    acc.Withdraw(cashWithdraw);
                    break;

                case "4":
                    Console.Write("Enter Check Number: ");
                    string withdrawCheckNo = Console.ReadLine();
                    Console.Write("Enter Amount: ₹");
                    double checkWithdrawAmt = Convert.ToDouble(Console.ReadLine());
                    acc.Withdraw(withdrawCheckNo, checkWithdrawAmt);
                    break;

                case "5":
                    acc.DisplayBalance();
                    break;

                case "0":
                    Console.WriteLine("\n[👋] Thank you for using the Bank System. Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("\n[❗] Invalid option. Please try again.\n");
                    break;
            }
        }
    }
}
