using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamdaStatement
{
    public class EvenNumbers //class
    {
        public void Even() { //method
            int[] integers = new int[6];
            Console.WriteLine(" Enter 6 numbers");
            for (int i = 0; i < 6; i++) {
                integers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even numbers are");
            foreach (int j in integers.Where(x => {
                if (x % 2 == 0)
                    return true;  //return only even numbers
                return false; //drops all other values
            }
             ))
                Console.WriteLine(j); //prints even numbers
        }
    }
}
