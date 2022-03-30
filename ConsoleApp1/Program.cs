using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var testtest = new Mail(1000, 10000);
            for(int i=0;i<20;++i)
            {
                testtest.IncreaseTransmissionCosts(i);
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
