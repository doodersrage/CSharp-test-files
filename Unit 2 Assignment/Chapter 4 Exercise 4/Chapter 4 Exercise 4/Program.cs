using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Exercise_4
{
    class Program
    {

        static void Main(string[] args)
        {
            double salesA = 0, salesB = 0, salesE = 0;
            double salesACommission = 0, salesBCommission = 0, salesECommission = 0;

            char inpInitial = 'A';
            
            while (inpInitial != 'Z')
            {
                // print initial initial request
                inpInitial = getInitial();

                switch (inpInitial)
                {
                    case 'A':
                        salesA += calcSales();
                        salesACommission += calcComm(salesA);
                    break;
                    case 'B':
                        salesB += calcSales();
                        salesBCommission += calcComm(salesB);
                    break;
                    case 'E':
                        salesE += calcSales();
                        salesECommission += calcComm(salesE);
                    break;
                    case 'Z':
                        // do nothing
                    break;
                    default:
                        // invalid entry detected
                        Console.WriteLine("Invalid entry detected! Please enter only A,B, or E! ");
                    break;
                }
            }

            Console.WriteLine("Andrea:");
            Console.WriteLine("Sales: {0}", salesA);
            Console.WriteLine("Commissions: {0}", salesACommission);
            Console.WriteLine();

            Console.WriteLine("Brittany:");
            Console.WriteLine("Sales: {0}", salesB);
            Console.WriteLine("Commissions: {0}", salesBCommission);
            Console.WriteLine();

            Console.WriteLine("Eric:");
            Console.WriteLine("Sales: {0}", salesE);
            Console.WriteLine("Commissions: {0}", salesECommission);
            Console.WriteLine();

            Console.ReadLine();

        }

        static char getInitial()
        {
            string inputStr;
            char inpInitial;

            Console.WriteLine("Please enter a salesperson's initial ('A' for Andrea, 'B' for Brittany and 'E' for Eric and 'Z') to display each saleperson's total commmission earned");
            inputStr = Console.ReadLine();
            inpInitial = Convert.ToChar(inputStr.ToUpper());

            return inpInitial;
        }

        static double calcComm(double sales)
        {
            double commissions = sales * 0.1;

            return commissions;
        }

        static double calcSales()
        {
            double sales;
            string inpStr;

            Console.WriteLine("Please Enter Your Initial sales:");
            inpStr = Console.ReadLine();
            sales = Convert.ToDouble(inpStr);

            return sales;
        }
    
    }

}
