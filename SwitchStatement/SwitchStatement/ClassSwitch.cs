using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatement
{
    public class ClassSwitch
    {
        public int a = int.Parse(Console.ReadLine());
        
        public void testing1()
        {


            switch (a)
            {
                case 1:
                    Console.WriteLine("number is 1");
                    break;
                case 2:
                    Console.WriteLine("number is 2");
                    break;
                default:
                    Console.WriteLine("bye... bye...");
                    break;
            }


            
            }
        }
    }


