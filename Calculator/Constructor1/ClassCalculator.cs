using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example
{
    public class ClassCalculator
    {
        public int Calculator(int a, int b)
        {

            Console.WriteLine("sum is {0}", a + b);
            return a + b;
        }

        public int Calculator(List<int> numbers)
        {
            int sum = numbers.Sum();
            //foreach(int n in numbers)
            //{
            //    sum = sum + n;
            //}
            Console.WriteLine(sum);
            return sum;
        }
    }
}
