using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassException classException = new ClassException();
            classException.ThrowException();
        }
    }
}
