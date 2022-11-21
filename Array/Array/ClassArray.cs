using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    internal class ClassArray
    {
        public int[] evenNumbers = new int[4];

        public void initialize()
        {
            evenNumbers[0] = 10;
            evenNumbers[1] = 14;
            evenNumbers[2] = 12;
            evenNumbers[3] = 16;
            //evenNumbers[4] = 18;
       Console.WriteLine($"even numbers: { evenNumbers[1] }", evenNumbers[1]);
       //Console.WriteLine($"even numbers: { evenNumbers[4] }", evenNumbers[4]);
        }
    }
}
