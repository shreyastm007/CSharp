using System;
using System.Collections.Generic;

namespace Queue2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            Console.WriteLine(callerIds.Contains(2)); 
            Console.WriteLine(callerIds.Contains(10)); 
        }
    }
}
