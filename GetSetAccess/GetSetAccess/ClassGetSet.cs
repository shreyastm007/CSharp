using System;
using System.Collections.Generic;
using System.Text;

namespace GetSetAccess
{
    public class Access
    {

        private int id;
        private int age { set; get; }

        private string name;

        public void setage(int age)
        {
            object p = (age < 0 || age > 100) ? //ternary operator
      throw new Exception("age should be greater than 0 and less than 100")
         : this.age = age;

        }
        public string getage()  
        { 
            string p = (age < 18) ? "underAge" : "age accepted";

            return p;
        }


        public int getid()
        {
            return id = 6;
        }

        public void method1()
        {
            //Console.WriteLine(id);
            Console.WriteLine("age is {0}",age);
            //Console.WriteLine(name);

        }
    }
}
