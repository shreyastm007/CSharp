using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface Idrawable
    {
        void draw();
    }
    public class Rectangle : Idrawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Idrawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
}
