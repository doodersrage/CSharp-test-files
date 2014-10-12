using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales = 0, comRate = 0, commissions = 0;
            string inpStr;

            // gather sales information
            Console.WriteLine("Please enter your automobile sales:");
            inpStr = Console.ReadLine();
            sales = Convert.ToDouble(inpStr);

            // set commissions rate
            if(sales > 24000){
                comRate = 0.1;
            }else if(sales > 15000){
                comRate = 0.07;
            }else if(sales <= 15000){
                comRate = 0.05;
            }

            // calculate comissions
            commissions = sales * comRate;

            // print sales rate
            Console.WriteLine("Your commissions is: {0}", commissions);

        }
    }
}
