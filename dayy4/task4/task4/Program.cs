using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    student student1 = new student();
            //    student student2 = new student();
            //    student student3 = new student();

            //    student student4= new student("Ahmad", 20, 85);

            //    student1.name = "Ahmad";
            //    student1.age = 20;
            //    student1.grade = 85;

            //    student2.name = "Fatima";
            //    student2.age = 22;
            //    student2.grade = 89;

            //    student3.name = "Ahmad";
            //    student3.age = 23;
            //    student3.grade = 90;

            //    student1.DisplayInfo();
            //    Console.WriteLine();
            //    student2.DisplayInfo();
            //    Console.WriteLine();
            //    student3.DisplayInfo();
            //}



            student student1 = new student("Ahmad", 20, 85);
            student student2 = new student("Omar", 21, 90);
            student student3 = new student("Sara", 19, 95);

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
    }
}
