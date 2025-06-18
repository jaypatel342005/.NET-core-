using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Student
    {
        public int Enrollment_No;
        public string Student_Name;
        public int Semester;
        public double CPI;
        public double SPI;

        public Student(int enrollmentNo, string studentName, int semester, double cpi, double spi)
        {
            Enrollment_No = enrollmentNo;
            Student_Name = studentName;
            Semester = semester;
            CPI = cpi;
            SPI = spi;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Enrollment No: {Enrollment_No}");
            Console.WriteLine($"Student Name: {Student_Name}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"CPI: {CPI:F2}");
            Console.WriteLine($"SPI: {SPI:F2}");
        }
    }
}
