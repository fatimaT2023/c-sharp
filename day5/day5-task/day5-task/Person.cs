using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_task
{
    internal class Person


    {
        public string Name;

        public int Age { get; set; }

        protected string SchoolName { get; set; }
        private string internalCode = "P001";

        //internalCode cannot be accessed outside Person cause its avilabel in just scop of  person class 
        public Person(string name, int age, string schoolName)
        { 
               Name = name;
               Age = age;
               SchoolName = schoolName;
          }

        public void DisplayInfo()
        {
            Console.WriteLine($" your name id {Name} and your age is {Age} and the school name is : {SchoolName}");
        }

        }
    }

