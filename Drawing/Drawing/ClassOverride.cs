using System;
using System.Collections.Generic;
using System.Text;

namespace Drawing
{
    public class Drawing
    {
        public virtual double Area(int a)
        {
            return a;
        }
        public virtual double Area(int a, int b)
        {
            return 0;
        }
    }

    public class Circle : Drawing
    {
        public override double Area(int a)
        {
            return (3.14) * a * a;
        }
       
    }

    public class Square : Circle
    {
        public override double Area(int a)
        {
            return a * a;
        }
    }

    public class Rectangle : Drawing
    {
        public override double Area(int a, int b)
        {
            return b * a;
        }
    }
}
