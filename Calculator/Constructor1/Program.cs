using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCalculator classCalculator = new ClassCalculator();
            classCalculator.Calculator(1,2);
            classCalculator.Calculator(new System.Collections.Generic.List<int>() { 10, 20 });
        }
    }
}
