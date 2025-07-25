﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Array_List

{
    internal class Program

    {
        public static void Main(string[] args)
        {
            ArrayList StudentName = new ArrayList();
            int choice = 0;
            while (choice != -1)
            {
                Console.WriteLine("Enter 1 to add a student : ");
                Console.WriteLine("Enter 2 to remove a student : ");
                Console.WriteLine("Enter 3 to remove range from student : ");
                Console.WriteLine("Enter 4 to clear the StudentName : ");
                Console.WriteLine("Enter 5 to See the StudentList : ");
                Console.WriteLine("Enter -1 to exit : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name you want to add : ");
                        StudentName.Add(Console.ReadLine());
                        foreach (Object o in StudentName)
                        {
                            Console.WriteLine(o.ToString());
                        }

                        break;
                    case 2:
                        Console.Write("Enter name you want to remove : ");
                        StudentName.Remove(Console.ReadLine());
                        foreach (Object o in StudentName)
                        {
                            Console.WriteLine(o.ToString());
                        }
                        break;
                    case 3:
                        Console.Write("Enter index from which you want to remove : ");
                        int index = int.Parse(Console.ReadLine());
                        Console.Write("Enter no. of elements you want to remove : ");
                        int num = int.Parse(Console.ReadLine());
                        StudentName.RemoveRange(index, num);
                        foreach (Object o in StudentName)
                        {
                            Console.WriteLine(o.ToString());
                        }
                        break;
                    case 4:
                        StudentName.Clear();
                        break;
                    case 5:
                        foreach (Object o in StudentName)
                        {
                            Console.WriteLine(o.ToString());
                        }
                        break;

                    case -1:
                        Console.WriteLine("Exiting the loop...");
                        return;
                }
            }
        }
    }
}
