using System;
using System.Collections.Generic;
using System.Text;

namespace Destructor
{
    public class Line
    {
       public  double length; // Length of a line

        public Line()
        { // constructor
            Console.WriteLine("Object is being created");
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        ~Line()
        { //destructor
            Console.WriteLine("Object is being deleted");
        }


    }
}
