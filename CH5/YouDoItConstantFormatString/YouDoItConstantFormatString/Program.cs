using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouDoItConstantFormatString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[8];
            int x;
            string inputString;
            const string FORMAT = "{0, 9}";

            for (x = 0; x < scores.Length; ++x)
            {
                Console.Write("Enter your score on test {0} ", x + 1);
                inputString = Console.ReadLine();
                scores[x] = Convert.ToInt32(inputString);
            }

            Console.WriteLine("\n---------------------");
            Console.WriteLine("Scores in original order:");
            for (x = 0; x < scores.Length; ++x)
                Console.Write(FORMAT, scores[x]);

            Console.WriteLine("\n---------------------");
            Array.Sort(scores);
            Console.WriteLine("Scores in sorted order:");
            for (x = 0; x < scores.Length; ++x)
                Console.Write(FORMAT, scores[x]);

            Console.WriteLine("\n---------------------");
            Array.Reverse(scores);
            Console.WriteLine("Scores in reverse order:");
            for (x = 0; x < scores.Length; ++x)
                Console.Write(FORMAT, scores[x]);
        }
    }
}
