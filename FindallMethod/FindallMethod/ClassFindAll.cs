using System;
using System.Collections.Generic;
using System.Text;


//The Array.FindAll() method in C# is used to retrieve all the elements that 
// match the conditions defined by the specified predicate Syntax

//Following is the syntax −
//public static T[] FindAll<T>(T[] array, Predicate<T> match);



namespace FindallMethod
{
    public class Demo
    {
        public  void Finding()
        {
            Console.WriteLine("Array elements...");
            string[] arr = { "car", "bike", "truck", "bus" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

            String[] res = Array.FindAll(arr, ele => ele.StartsWith("b",StringComparison.Ordinal));

            
           for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("{0}", res[i]);
            }
            Console.WriteLine();
        }
    }
}
