using System;
using static MultiDelegate.rectangle;

namespace MultiDelegate
{
    class Program
    {
        static void Main(string[] args)
        {

				// creating object of class
				rectangle rect = new rectangle();
				// rect.area(6, 4);
				// rect.perimeter(6, 4);

				// creating delegate object, name as "rectdele"
				// and pass the method as parameter by
				// class object "rect"
				rectDelegate rectdele = new rectDelegate(rect.area);

				// also can be written as
				// rectDelegate rectdele = rect.area;

				// call 2nd method "perimeter"
				// Multicasting
				rectdele += rect.perimeter; //add
			    //rectdele -= rect.perimeter;   //delete

			// pass the values in  methods
			// by using "Invoke" method
			rectdele.Invoke(6, 4);
				Console.WriteLine();

				// call the methods with
				// different values
				//rectdele.Invoke(3, 5);
			}
		}
	}
    
