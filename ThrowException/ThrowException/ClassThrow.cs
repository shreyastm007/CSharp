using System;
using System.Collections.Generic;
using System.Text;

namespace ThrowException
{
    public class Exception
    {
      
        public void checkAge(int age)
        {
            if (age < 18)
            {
 throw new ArithmeticException("Access denied - You must be at least 18 years");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
    }

   
}
