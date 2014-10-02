using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_2_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width;
            double price, cost;

            length = 10;
            width = 29;
            price = 20.50;

            cost = price * (length * width);

            Console.WriteLine("The cost in total square feet for carpeting the room is {0}", cost.ToString("C"));

        }
    }
}
