using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    internal class ClassException
    {
        string[] names = new string[] { "shreyas", "prajwal" };
        

        public void ThrowException()
        {
            Console.WriteLine(names[1]);

            //exception handling
            try
            {
               Console.WriteLine(names[2]);
               
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine(" out of range exception occured");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("null exception occured");
            }
         }
    }
}
