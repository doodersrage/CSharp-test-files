using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // set int vals
            int val1 = 11;
            int val2 = 6;
            int sum, diff, prod;

            // get sum
            sum = Sum(val1, val2);

            // get difference
            diff = Difference(val1, val2);

            // get product
            prod = Product(val1, val2);

            // print results
            Console.WriteLine("The product: {0}\nThe Difference: {1}\nThe Product: {2}", sum, diff, prod);

            Console.ReadLine();
        }

        // calc sum
        static int Sum(int val1, int val2)
        {
            int sum = val1 + val2;
            return sum;
        }

        // calc difference
        static int Difference(int val1, int val2)
        {
            int difference = val1 - val2;
            return difference;
        }

        // calc product
        static int Product(int val1, int val2)
        {
            int product = val1 * val2;
            return product;
        }
    }
}
