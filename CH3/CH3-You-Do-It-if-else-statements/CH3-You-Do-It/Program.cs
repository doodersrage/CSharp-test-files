using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH3_You_Do_It
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString;
            int num1, num2, num3;

            Console.Write("Enter an integer ");
            numberString = Console.ReadLine();
            num1 = Convert.ToInt32(numberString);
            Console.Write("Enter an integer ");
            numberString = Console.ReadLine();
            num2 = Convert.ToInt32(numberString);
            Console.Write("Enter an integer ");
            numberString = Console.ReadLine();
            num3 = Convert.ToInt32(numberString);

            if (num1 == num2)
                if (num1 == num3)
                    Console.WriteLine("All three numbers are equal");
                else
                    Console.WriteLine("First two are equal");
            else
                if (num1 == num3)
                    Console.WriteLine("First and last are equal");
                else
                    if (num2 == num3)
                        Console.WriteLine("Last two are equal");
                    else
                        Console.WriteLine("No two number are equal");
        }
    }
}
