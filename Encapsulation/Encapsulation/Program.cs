using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //set
            employee.Id = "10";
            employee.Name = "Vishal Gupta";
            employee.City = "Delhi";
            //get
            Console.WriteLine("Employee Id: " + employee.Id);
            Console.WriteLine("Employee Name: " + employee.Name);
            Console.WriteLine("Employee City: " + employee.City);
        }
    }
}
