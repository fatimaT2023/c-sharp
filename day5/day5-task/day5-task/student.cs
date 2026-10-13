using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day5_task
{
    sealed class Student :Person
    {
        public int Grade { get; set; }

        public string StudentId { get; set; }
        public Student(string name, int age, string schoolName,
                           int grade, string studentId)
                : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }
        public void DisplayStudentInfo()
        {
            

            Console.WriteLine($"Grade: {Grade}");
            Console.WriteLine($"Student ID: {StudentId}");

           
            Console.WriteLine($"School: {SchoolName}");
        }
       
       

       


    }
    }

     
    

