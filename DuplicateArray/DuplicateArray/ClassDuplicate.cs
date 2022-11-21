using System;
using System.Collections.Generic;
using System.Text;

namespace DuplicateArray
{
    public class ClassDuplicate
    {
        public void Duplicate()
        {
            int[] arr = new int[] { 1, 2, 3, 4,5,11, 2, 8, 8, 3, 1 };

            Console.WriteLine("Duplicate elements in given array: ");
            //Searches for duplicate element  
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }
        }
    }
}
