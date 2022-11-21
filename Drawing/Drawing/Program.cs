using System;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing drawing = new Drawing();
     Console.WriteLine(drawing.Area(4, 1));

            Drawing drawing1 = new Circle();
     Console.WriteLine($"Area of circle is {drawing1.Area(2)}", drawing1.Area(2));

            Drawing drawing2 = new Square();
     Console.WriteLine($"Area of square is {drawing2.Area(3)}", drawing2.Area(3));

            Drawing drawing3= new Rectangle();
     Console.WriteLine($"Area of rectangle is {drawing3.Area(5,6)}", drawing3.Area(5,6));


        }
    }
}
