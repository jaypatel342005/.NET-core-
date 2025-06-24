//Create a class named RBI with calculateInterest() method. Create another
//classes HDFC, SBI, ICICI which overrides calculateInterest() method.

using System;

class RBI
{
    protected double rateOfInterest = 4.0;

    public virtual void CalculateInterest(double principal, int time)
    {
        double interest = (principal * rateOfInterest * time) / 100;
        Console.WriteLine($"RBI Interest Amount: ₹{interest} at {rateOfInterest}% per annum");
    }
}

class HDFC : RBI
{
    public HDFC()
    {
        rateOfInterest = 6.5;
    }

    public override void CalculateInterest(double principal, int time)
    {
        double interest = (principal * rateOfInterest * time) / 100;
        Console.WriteLine($"HDFC Interest Amount: ₹{interest} at {rateOfInterest}% per annum");
    }
}

class SBI : RBI
{
    public SBI()
    {
        rateOfInterest = 6.75;
    }

    public override void CalculateInterest(double principal, int time)
    {
        double interest = (principal * rateOfInterest * time) / 100;
        Console.WriteLine($"SBI Interest Amount: ₹{interest} at {rateOfInterest}% per annum");
    }
}

class ICICI : RBI
{
    public ICICI()
    {
        rateOfInterest = 7.0;
    }

    public override void CalculateInterest(double principal, int time)
    {
        double interest = (principal * rateOfInterest * time) / 100;
        Console.WriteLine($"ICICI Interest Amount: ₹{interest} at {rateOfInterest}% per annum");
    }
}

class Program
{
    static void Main()
    {
        double principal = 100000;
        int time = 2;

        RBI bank;

        bank = new HDFC();
        bank.CalculateInterest(principal, time);

        bank = new SBI();
        bank.CalculateInterest(principal, time);

        bank = new ICICI();
        bank.CalculateInterest(principal, time);
    }
}
