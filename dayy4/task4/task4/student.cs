using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task4
{
    internal class student
    {

        public string name;
        public int age;
        public int grade;

        //public void DisplayInfo()
        //{
        //    Console.WriteLine(name);
        //    Console.WriteLine(age);
        //    Console.WriteLine(grade);
        //}



        public student(string name, int age, double grade)
        {
            name = name;
            age = age;
            grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
        }
    }
}
