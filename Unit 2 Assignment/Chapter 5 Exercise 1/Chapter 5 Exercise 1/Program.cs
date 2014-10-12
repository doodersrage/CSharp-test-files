using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inpInts;
            inpInts = new int[5] {1,2,3,4,5};

            // sort
            Array.Sort(inpInts);
            // ask user to input five integers
            foreach (int i in inpInts) Console.Write(i + " ");

            // cleat line
            Console.WriteLine();

            // rsort
            Array.Reverse(inpInts);
            // ask user to input five integers
            foreach (int i in inpInts) Console.Write(i + " ");

        }
    }
}
