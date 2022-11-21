using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class PlainClass
    {
        public void m1() //1
        {
        }

    }

    public interface IPlainClass  //2
    {
        public static int a;
        public void m2();
    }

    public abstract class Bank  //3
    {
        public abstract void interest();

        public void transaction()
        {

        }
        public void CashFlow()
        {

        }

        public void Employees()
        {

        }
    }

    public interface IBank    //4
    {
        public void debit();
        public void credit();
    }


    public class ICICI : Bank, IBank
    {
        public override void interest() //override abstract
        {
            Console.WriteLine("2% interest in ICICI bank");
        }

        public void debit() { } //override keyword is not required
                                //interface 
        public void credit() { }

    }

    public class BOB : Bank
    {
        public override void interest()
        {
            Console.WriteLine("3% interest in ICICI bank");
        }

    }
}
