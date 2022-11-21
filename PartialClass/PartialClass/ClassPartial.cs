using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    
    partial class ClassPartial
    {
        public int c;
        public void Addition(int a, int b)
        {
            c = a + b;
            //return c;
            Console.WriteLine($"c is {c}", c);
        }
    }

    partial class ClassPartial
    {
        public int d;
        public void Subtraction(int a, int b)
        {
            d = a - b;
            //return d;
            Console.WriteLine($"d is {d}", d);
        }
    }
}
