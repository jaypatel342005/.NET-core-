// See https://aka.ms/new-console-template for more information

//Write a program with following specifications:
//Class Name: Student
//Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
//Get Students Details using constructor and DisplayStudentDetails() using
//member function


using _4;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Enrollment No: ");
        int enrollmentNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Semester: ");
        int semester = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter CPI: ");
        double cpi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter SPI: ");
        double spi = Convert.ToDouble(Console.ReadLine());

        Student student = new Student(enrollmentNo, studentName, semester, cpi, spi);
        student.DisplayStudentDetails();
    }
}
