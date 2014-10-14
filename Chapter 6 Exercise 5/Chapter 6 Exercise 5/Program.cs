using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // set variables
            int val1 = 22;

            // display assigned integer
            Console.WriteLine("Your value is: {0}", val1);

            // generate square
            SquareRef(ref val1);

            // display squared value
            Console.WriteLine("Your value sqaured is: {0}", val1);

        }

        // generate and print square
        static void SquareRef(ref int refVal1)
        {
            refVal1 *= refVal1;
        }
    }
}
