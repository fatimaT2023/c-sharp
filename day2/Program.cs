using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string x = "10";
            //int age = Convert.ToInt32(x);
            //Console.WriteLine(age);

            //int a = 22;
            //string b = Convert.ToString(a);
            //Console.WriteLine(b);

            ////spesail char
            ////\n
            //// \t
            ////\"  \"

            //Console.WriteLine("hello\twrod");
            Console.WriteLine("Enter  your name :");
            string name = Console.ReadLine();
            //Console.WriteLine( $"hello {name}");
            Console.WriteLine("Enter  your age:");
            int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);
            Console.WriteLine("select your gender  :");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter  your Average :");
            float avg = float.Parse(Console.ReadLine());
            //Console.WriteLine(avg);
            Console.WriteLine("Enter  your Grade  :");
            float grade = float.Parse(Console.ReadLine());
            //Console.WriteLine(grade);


            Console.WriteLine("===================== Student Report ==============");

            Console.WriteLine($" welcom {name} !");
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"age is {age}");
            Console.WriteLine($"Avarege : {avg}");
            Console.WriteLine($" Gender {gender}");

        
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());


            Console.WriteLine("your bouns:5 ");
            Console.WriteLine($"your origenal Avarege  : {avg}");
            Console.WriteLine($"new avarege :{avg +5}");

        }
    }
}
