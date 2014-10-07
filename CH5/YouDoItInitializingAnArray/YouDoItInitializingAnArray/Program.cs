using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouDoItInitializingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] payRate = {6.00, 7.35, 8.12, 12.45};

            Console.WriteLine("Pay rate {0} is {1}", 0, payRate[0].ToString("C"));
            Console.WriteLine("Pay rate {0} is {1}", 1, payRate[1].ToString("C"));
            Console.WriteLine("Pay rate {0} is {1}", 2, payRate[2].ToString("C"));
            Console.WriteLine("Pay rate {0} is {1}", 3, payRate[3].ToString("C"));
        }
    }
}
