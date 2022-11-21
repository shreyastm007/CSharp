using System;
using System.Collections.Generic;
using System.Text;

namespace Loopings
{
    class ClassLooping
    {
        public void Gender()
        {
            var a = Console.ReadLine();

            if (a == "male")
            {
                Console.WriteLine("male");
            }
            else if (a == "female")
            {
                Console.WriteLine("male");
            }
            else
            {
                Console.WriteLine("others");
            }
        }

        public void Symbols()
        {
            var b = Console.ReadLine();
            int c = int.Parse(b); // convert string to int 

            while (c > 0)
            {
                Console.WriteLine("HAI");
                
            }
            Console.WriteLine("BYE");
        }

        public void Area()
        {
            var d = Console.ReadLine();
            int c = int.Parse(d); // convert string to int 

            do
            {
                Console.WriteLine("ok");

            } while (c > 0) ;
                
        }
    }
}
