using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor1
{
    public class Constructor
    {
        public int id;
        public string name;
        public Constructor() //default constructor
        {

        }
        //user defined constructor

        public Constructor(string a) {
            name = a;
            Console.WriteLine(" base class ");
        }
        //constructor overloading
        public Constructor(string b, int a) {
            name = b;
            id = a;
        }
    }

    //creating constructor
    public class Constructor2 : Constructor
    {

        public int x;
        public string y;

        public Constructor2(int c)
        {
            x = c;
        }
        public Constructor2(string a)
        {
            y = a;
        }

        public Constructor2(string a, int b) : this(b)  //x=b
        {
            y = a;
        }

        public Constructor2(string a, int b, string q) : base(q)  //name=q
        {
            y = a;
            x=b;
            Console.WriteLine("derived class");
        }
    }
}

