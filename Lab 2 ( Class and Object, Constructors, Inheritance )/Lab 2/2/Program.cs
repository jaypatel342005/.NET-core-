// See https://aka.ms/new-console-template for more information

//Write a program to create a class Staff having data members as Name,
//Department, Designation, Experience & Salary. Accept this data for 5
//different staffs and display only names & salary of those staff who are
//HOD.



using _2;

class Program
{
    static void Main(string[] args)
    {
        const int staffCount = 5;
        Staff[] staffArray = new Staff[staffCount];

        Console.WriteLine("Enter details for 5 staff members:\n");
        for (int i = 0; i < staffCount; i++)
        {
            Console.WriteLine($"Staff #{i + 1}:");
            staffArray[i] = new Staff();
            staffArray[i].GetStaffDetails();
            Console.WriteLine();
        }

        Console.WriteLine("Names and Salary of staff who are HOD:");
        foreach (var staff in staffArray)
        {
            if (staff.Designation.Equals("HOD", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Name: {staff.Name}, Salary: {staff.Salary:C}");
            }
        }
    }
}
