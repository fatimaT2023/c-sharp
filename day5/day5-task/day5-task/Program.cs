using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ahmad", 16, "Al-Noor School", 10, "S001");

            Student student2 = new Student("Fatima", 22, "Al-Noor School", 10, "S001");

            Teacher teacher = new Teacher("omar", 35, "Al-noor", "Math");

            SchoolReport report = new SchoolReport(
                "School Report");
            student1.DisplayInfo();
            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();


            teacher.DisplayTeacherInfo();
            report.DisplayReportTitle();




            
            
           
            // Console.WriteLine(student1.SchoolName);

          
            // Console.WriteLine(student1._internalCode);

            //Console.ReadLine();
        }
        }
    }




    
    

