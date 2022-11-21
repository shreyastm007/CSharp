using System;

namespace GetSetAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Access access = new Access();
            //access.id = -3;
            access.setage(4);
            //access.name = "avi";

            access.method1();

            Console.WriteLine(access.getid());
           Console.WriteLine(access.getage());

        }
    }
}
