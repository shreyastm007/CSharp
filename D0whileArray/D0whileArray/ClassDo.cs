using System;
using System.Collections.Generic;
using System.Text;

namespace D0whileArray
{
    public class ClassDo
    {
        public void looping()
        {
            string[] arr = { "apple", "banana", "cherry" };
            int index = 0;

            do
            {
                Console.WriteLine(arr[index]);
                index++;
            } while (index < arr.Length);
        }

    }
}
