using System;

namespace Exceptions1
{
    class Program
    {
        static void Main(string[] args)
        {
            //custom exception
            Student student = new Student();
            student.setAge(-5);
            //student.setAge(-5);
        }
    }
}
