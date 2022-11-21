using System;
using System.Collections.Generic;
using System.Text;

namespace ParseTryParse
{
    class ClassConversion
    {
        public void testing1()
        {
            int b;
            bool res;
            //string a = Console.ReadLine();
            string a = "55H";

            if (res = int.TryParse(a, out b))
            {
                Console.WriteLine($"b: {b}", b);
                Console.WriteLine("String is a numeric representation: " + res);
            }
            else
            {
                Console.WriteLine("Cannot be done");
                Console.WriteLine("String is a numeric representation: " + res);
            }
        }

        public void testing2()
        {
            double b = 66.66;
            int c = (int)b;
            Console.WriteLine($"c is {c}", c);
        }
        public void testing3()
        {
           int res;
            string myStr = "200";
            res = int.Parse(myStr);
            Console.WriteLine("String in numeric representation: " + res);
        }
    
    }
}
