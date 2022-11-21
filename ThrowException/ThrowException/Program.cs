using System;

namespace ThrowException
{
    class Program
    {
        public static void Main(string[] args)
        {
            Exception exception = new Exception();
            exception.checkAge(2);
        }
    }
}
