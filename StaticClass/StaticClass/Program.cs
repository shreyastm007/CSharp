using System;

namespace StaticClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is: " + MyMath.PI);
            Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));
            Console.WriteLine(MyMath.method1());

        }
    }
}
