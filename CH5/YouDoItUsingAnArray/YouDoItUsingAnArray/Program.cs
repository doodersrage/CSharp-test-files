using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouDoItUsingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] payRate;
            payRate = new double[4];

            payRate[0] = 6.00;
            payRate[1] = 7.35;
            payRate[2] = 8.12;
            payRate[3] = 12.45;

            Console.WriteLine("Pay rate {0} is {1}", 0, payRate[0].ToString("C"));
            Console.WriteLine("Pay rate {0} is {1}", 1, payRate[1].ToString("C"));
            Console.WriteLine("Pay rate {0} is {1}", 2, payRate[2].ToString("C"));
            Console.WriteLine("Pay rate {0} is {1}", 3, payRate[3].ToString("C"));
        }
    }
}
