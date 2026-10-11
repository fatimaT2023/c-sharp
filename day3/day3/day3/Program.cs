using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int number = 65;
            //int guess = 0;
            //int attempts = 0;
            //while (guess!=number)
            //{
            //    Console.WriteLine("guess a number between 50 and 75");
            //    guess=int.Parse(Console.ReadLine());
            //    attempts++;

            //    if( guess < number)
            //    {
            //        Console.WriteLine("Try a higher number");
            //    }
            //    else if (guess > number)
            //    {
            //        Console.WriteLine("try a higher number");
            //    }
            //}
            //Console.WriteLine("Congratulations");
            //Console.WriteLine("Attempts:" + attempts);

            //if (attempts == 1)
            //{
            //    Console.WriteLine("Points: 10");
            //}
            //else if (attempts == 2)
            //{
            //    Console.WriteLine("Points: 7");
            //}
            //else if (attempts == 3)
            //{
            //    Console.WriteLine("Points: 5");
            //}
            //else
            //{
            //    Console.WriteLine("Points: 0");
            //}



            //school system
            string[] students = { "Ahmad", "Omar", "Ola", "Fatima", "Laila" };
            int[] grades = { 85, 92, 68, 75, 90 };

            int choice;

            do
            {
                Console.WriteLine("===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Students:");

                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }

                        Console.WriteLine("Grades:");

                        foreach (int grade in grades)
                        {
                            Console.WriteLine(grade);
                        }

                        break;


                    case 2:

                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        int x = 0;

                        while (x < students.Length)
                        {
                            if (students[x] == name)
                            {
                                Console.WriteLine("Student Found!");
                                break;
                            }

                            x++;
                        }

                        if (x == students.Length)
                        {
                            Console.WriteLine("Student Not Found.");
                        }

                        break;


                    case 3:

                        Console.Write("Enter grade: ");
                        int gradeResult = int.Parse(Console.ReadLine());

                        if (gradeResult >= 90)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (gradeResult >= 80)
                        {
                            Console.WriteLine("Very Good");
                        }
                        else if (gradeResult >= 70)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (gradeResult >= 60)
                        {
                            Console.WriteLine("Pass");
                        }
                        else
                        {
                            Console.WriteLine("Fail");
                        }

                        break;


                    case 4:

                        Console.WriteLine("Exit");
                        break;
                }

            } while (choice != 4);
        }
    }
}
            //    string[] students = { "Ahmad", "Omar", "Ola", "Fatima", "Laila" };
            //    int[] grades = { 85, 92, 68, 75, 90 };
            //    int choice ;

            //    for (int i = 0; i <= students.Length; i++)
            //    {
            //        Console.WriteLine(students[i]);
            //    }

            //    foreach (int num in grades)
            //    {
            //        Console.WriteLine(num);
            //    }

            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());
            //    string[] students = { "Ahmad", "Omar", "Ola", "Fatima", "Laila" };
            //    int[] grades = { 85, 92, 68, 75, 90 };


            //    for (int i = 0; i < students.Length; i++)
            //    {
            //        Console.WriteLine(students[i]);
            //    }

            //    foreach (int num in grades)
            //    {
            //        Console.WriteLine(num);
            //    }

            //    Console.Write("Enter student name: ");
            //    string name = Console.ReadLine();

            //    int x = 0;
            //    bool found = false;

            //    while (x < students.Length)
            //    {
            //        if (students[x] == name)
            //        {
            //            Console.WriteLine("Student Found!");
            //            found = true;
            //            break;
            //        }

            //        x++;
            //    }

            //    if (found == false)
            //    {
            //        Console.WriteLine("Student Not Found.");
            //    }

            //    Console.Write("Enter student grade: ");
            //    int grade = int.Parse(Console.ReadLine());

            //    if (grade >= 90)
            //    {
            //        Console.WriteLine("Excellent");
            //    }
            //    else if (grade >= 80)
            //    {
            //        Console.WriteLine("Very Good");
            //    }
            //    else if (grade >= 70)
            //    {
            //        Console.WriteLine("Good");
            //    }
            //    else if (grade >= 60)
            //    {
            //        Console.WriteLine("Pass");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Fail");
            //    }
            //}
        
 
