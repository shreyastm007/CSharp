using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Idrawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();
        }
    }
}
