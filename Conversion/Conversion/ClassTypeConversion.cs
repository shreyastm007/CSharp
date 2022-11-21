using System;
using System.Collections.Generic;
using System.Text;

namespace Conversion
{
    public class ClassTypeConversion
    {
        public void Example1()
        {
            //int to float
            int a = 50;
            float b = a;
            Console.WriteLine("yes");
            Console.WriteLine($"{b}", b);
        }

        public void Example2()
        {
            //double to float--> Explicit conversion
            double a = 50.052648;
            float b = (float)a;
            Console.WriteLine("ok");
            Console.WriteLine($"{b}", b);
        }

        public void Example3()
        {
            //char to string
            char a = 'v';
            string b = a.ToString();
            Console.WriteLine("fine");
            Console.WriteLine($"{b}", b);
        }

        public void Example4()
        {
            //int to string
            int a = 65;
            string b = a.ToString();
            Console.WriteLine("hello");
            Console.WriteLine($"{b}", b);
        }

        public void Example5()
        {
            //string to int
            string a = "65";
            int b = int.Parse(a);
            Console.WriteLine("explicit");
            Console.WriteLine($"{b}", b);
        }

        public void testing()
        {
            int b;
            bool res;
            //string a = Console.ReadLine();
            var a= Console.ReadLine();

            if (res = int.TryParse(a, out b))
            {
                Console.WriteLine($"b: {b}", b);
                Console.WriteLine(" numeric representation: " + res);
            }
            else
            {
                Console.WriteLine("Cannot be done");
                Console.WriteLine("numeric representation: " + res);
            }
        }

    }
}



