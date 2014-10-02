using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {

            double hourlyRate, payRate;
            string inpStr;
            int validInp = 0;

            while (validInp == 0)
            {
                Console.WriteLine("Please enter your hourly rate:");
                inpStr = Console.ReadLine();
                hourlyRate = Convert.ToDouble(inpStr);

                if (hourlyRate < 5.65 || hourlyRate > 49.99)
                {
                    validInp = 0;
                    Console.WriteLine("Your hourly rate appears to be invalid");
                } 
                else
                    validInp = 1;

                payRate = hourlyRate * 40;

                Console.WriteLine("Your hourly rate is {0} and your pay rate is {1}", hourlyRate, payRate);

            }

        }

    }
}
