using System;

namespace NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object of outer class
            Car sportsCar = new Car();

            // access method of outer class
            sportsCar.DisplayCar();

            // create object of inner class
            Car.Engine petrolEngine = new Car.Engine();

            // access member of inner class
            petrolEngine.DisplayEngine();

            //Console.ReadLine();
        }
    }
}
