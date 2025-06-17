// See https://aka.ms/new-console-template for more information
// Program to find out Simple Interest using a function (I = PRN/100)
static double CalculateSimpleInterest(double principal, double rate, double time)
{
    return (principal * rate * time) / 100;
}

Console.Write("Enter Principal amount: ");
double principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Rate of interest: ");
double rate = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Time (in years): ");
double time = Convert.ToDouble(Console.ReadLine());

double interest = CalculateSimpleInterest(principal, rate, time);

Console.WriteLine($"Simple Interest calculated with Principal: {principal}, Rate: {rate}, Time: {time} , is : {interest}");
