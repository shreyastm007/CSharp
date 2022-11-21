using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    public class My_Family
    {

        public void member()//may be virtual or not
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }

    // Derived Class
    public class My_Member : My_Family
    {
        // Re implement the method of the base class
        // Using new keyword
        // It hides the method of the base class
        public new void member()
        {
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                   "Age: 39 \nName: Rohan, Age: 20 ");
        }
    }
}
