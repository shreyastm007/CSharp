using System;
using System.Collections.Generic;
using System.Text;

namespace SumArray
{
    public class ClassSum
    {
        public void Sum()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 8, 9 };
            int sum = 0;

            //Loop through the array to calculate sum of elements  
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of all the elements of an array: " + sum);
        }
    }
}
