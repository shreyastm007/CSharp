using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI iCICI = new ICICI();
            iCICI.interest();
            BOB bOB = new BOB();
            bOB.interest();

        }
    }
}
