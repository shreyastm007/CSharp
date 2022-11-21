using System;

namespace ExceptionHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            //d.division(25, 0);
            d.division(25, 5);
            Console.ReadKey();
        }
    }
}
