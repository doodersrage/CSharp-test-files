using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int QUIT = 999;
            int[] numbers = new int[20];
            int x;
            int num = 0;
            double average;
            double total = 0;
            string inString;
            x = 0;
            do
            {
                Console.Write("Please enter a number or " + QUIT + " to quit...");
                inString = Console.ReadLine();
                num = Convert.ToInt32(inString);
                if (num == QUIT) break;
                numbers[x] = num;
                total += numbers[x];
                ++x;

            } while (x < numbers.Length);
            Console.WriteLine("The numbers are:");
            for (int y = 0; y < x; ++y)
                Console.Write("{0,6}", numbers[y]);
            average = total / x;
            Console.WriteLine();
            Console.WriteLine("The average is {0}", average);  

            Console.ReadLine();
         }
    }
}
