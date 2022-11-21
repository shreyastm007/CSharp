using System;
using System.Collections.Generic;
using System.Text;

namespace ElementAdd
{
    public class ClassAdd
    {
        public void addition1()
        {
            int[] array = new int[3];
            array[0] = 100;
            array[1] = 101;
            array[2] = 102;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
        }

        public void addition2()
        {
            int[] array = new int[3];
            array.SetValue(value: 110, index: 0);
            array.SetValue(value: 111, index: 1);
            array.SetValue(value: 122, index: 2);
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
        }

        public void addition3()
        {
            var list = new List<int>();
            
            list.Add(10);
            list.Add(1);
            list.Add(12);
            list.Add(0);
            list.Add(11);
            list.Add(13);

            var array = list.ToArray();

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);


        }
    }
}
