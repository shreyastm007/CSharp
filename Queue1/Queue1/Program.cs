using System;
using System.Collections.Generic;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");
            Console.WriteLine("Total elements: {0}", strQ.Count);
            if (strQ.Count > 0)
            {
                Console.WriteLine(strQ.Peek()); 
               
            }

            
        }
    }
}
