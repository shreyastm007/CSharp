using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    public  class ClassEnum
    {
        public enum planets
        {
            pluto=0,neptune=1,saturn=7
        }
         public enum gender
        {
           male, female, others
        }

        public void rule1()
        {
            Console.WriteLine("Planets");
            Console.WriteLine($"Pluto:{0}",planets.pluto);
        }
        public void rule2()
        {
            Console.WriteLine("Gender");
        }

    }
}
