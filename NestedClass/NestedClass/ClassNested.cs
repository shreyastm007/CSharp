using System;
using System.Collections.Generic;
using System.Text;

namespace NestedClass
{
    // outer class
    public class Car
    {

        public void DisplayCar()
        {
            Console.WriteLine("Car: Bugatti");
        }

        // inner class
        public class Engine
        {
            public void DisplayEngine()
            {
                Console.WriteLine("Engine: Petrol Engine");
            }
        }
    }
}
