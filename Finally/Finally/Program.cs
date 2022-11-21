using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();
            exception.final();
        }
    }
}
