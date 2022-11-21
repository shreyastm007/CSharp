using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ClassList
    {
        public void List1()
        {


            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(4);
            Console.WriteLine(primeNumbers.Contains(11));
            foreach (var numbers in primeNumbers)
            {
                Console.Write(numbers);
                Console.WriteLine("\n");
            }
            


        }

        public void List2()
        {
            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Bangalore");
            cities.Add("Mangalore");

            
            foreach (var city in cities)
            {
                Console.Write(city);
                Console.WriteLine("\n");
            }


            cities.Reverse();
            // Displaying the elements of List
            foreach (var k in cities)
            {
                Console.WriteLine(k);
            }




        }
        public void List3()
        {
            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {"Mumbai" , "Chicago" , "Norway", "Toronto"};
           

            bigCities.Remove("Mumbai"); 

            bigCities.RemoveAt(2);


            foreach (var cities in bigCities)
            {
                Console.Write(cities);
                Console.WriteLine("\n");
            }
               
                
   



        }
    }
}
