using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number = 2.33;
            //float num2 = 2.888f;
            ////string char bool int 
            //Console.WriteLine("eee");
            //Console.WriteLine("eee");
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"hello {name}");
            int age = 22;
            Console.WriteLine($"your age is: {age}");
            int grade = 99;
            Console.WriteLine($"your grade is :{grade}");
            float avg = 7.99f;
            Console.WriteLine($"your avg is:{avg}");
            string gender = "female";
            Console.WriteLine($"you are  a {gender}");
            bool active = true;
            Console.WriteLine($"are you active ? {active}");


            string[] names = { "Ali", "Sara", "Omar" };

            //Console.WriteLine(names);
            Console.WriteLine($"student 1 :{names[0]} ");
            Console.WriteLine("student 2: " + names[1]);
            Console.WriteLine("student 3:" + names[2]);
            Console.WriteLine("number of students" + names.Length);
            names[0] = "ola";
            Console.WriteLine($"student 1 :{names[0]} ");
            //Console.WriteLine(names);
            Console.WriteLine("student 2: " + names[1]);
            Console.WriteLine("student 3:" + names[2]);
            Console.WriteLine("number of students" + names.Length);



        }
    }
}
