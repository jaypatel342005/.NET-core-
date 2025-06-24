//Create a class Hospital with HospitalDetails() method.Create another
//classes Apollo, Wockhardt, Gokul_Superspeciality which overrides
//HospitalDetails() method.

using System;

class Hospital
{
    public virtual void HospitalDetails()
    {
        Console.WriteLine("General Hospital: Provides basic healthcare services.");
    }
}

class Apollo : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Apollo Hospital: Specializes in multi-specialty treatments and advanced healthcare.");
    }
}

class Wockhardt : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Wockhardt Hospital: Known for cardiac care and emergency services.");
    }
}

class Gokul_Superspeciality : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Gokul Superspeciality Hospital: Focuses on super-specialty treatments and patient care.");
    }
}

class Program
{
    static void Main()
    {
        Hospital[] hospitals = {
            new Hospital(),
            new Apollo(),
            new Wockhardt(),
            new Gokul_Superspeciality()
        };

        foreach (var hospital in hospitals)
        {
            hospital.HospitalDetails();
        }
    }
}