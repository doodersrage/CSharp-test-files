using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int entVal = 0, sumVal = 0;
            string inputVal;

            while (entVal != 999)
            {
                Console.WriteLine("Please enter an integer value (enter 999 to exit): ");
                inputVal = Console.ReadLine();
                entVal = Convert.ToInt32(inputVal);
                if(entVal != 999) sumVal += entVal;
            }

            Console.WriteLine("Sum of entered integer values: {0}", sumVal);

        }
    }
}
