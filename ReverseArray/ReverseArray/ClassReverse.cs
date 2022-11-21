using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseArray
{
    public class ClassReverse
    {
        public void Reverse()
        {


            int[] arr = { 15, 16, 17, 18 };
            
           
            // Original Array
            Console.WriteLine("Original Array");
            foreach (int i in arr)
            {
                
                Console.WriteLine(i);
            }
            Console.WriteLine("*****");


            // Reverse Array
            Console.WriteLine("Reversed Array");
            Array.Reverse(arr);
           
            foreach (int j in arr)
            {
                
                Console.WriteLine( j);
            }

        }
    }
}
