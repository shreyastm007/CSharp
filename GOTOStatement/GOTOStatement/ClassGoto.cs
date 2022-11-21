using System;
using System.Collections.Generic;
using System.Text;

namespace GOTOStatement
{
    public class ClassGoto
    {
        public void testing()
        {
        // label
        repeat:
            Console.WriteLine("Enter a number less than 10");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num >= 10)
            {
                // transfers control to repeat
                goto repeat;
            }

            Console.WriteLine(num + " is less than 10");
            

        }

    }
}
