using System;
using System.Collections.Generic;
using System.Text;

namespace Abstarct
{
    public abstract class Shape //parent class
    {
        public abstract void draw(); //virtual method
    }
    public class Rectangle : Shape // derived class
    {
        
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }


}
