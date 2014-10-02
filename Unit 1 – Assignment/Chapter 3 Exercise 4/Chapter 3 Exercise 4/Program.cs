using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string woodChoice = "", selWood = "";
            int validEnt = 0;
            double cost = 0;

            while (validEnt == 0)
            {
                Console.WriteLine("Pick your wood, choose P for pine, O for oak, or M for mahogany");
                woodChoice = Console.ReadLine();

                validEnt = 1;

                switch (woodChoice.ToUpper())
                {
                    case "P":
                        cost = 100;
                        selWood = "Pine";
                    break;
                    case "O":
                        cost = 225;
                        selWood = "Oak";
                    break;
                    case "M":
                        selWood = "Mahogany";
                        cost = 310;
                    break;
                    default:
                        validEnt = 0;
                    break;
                }
            }

            Console.WriteLine("The cost for {0} is {1}", selWood, cost);

            Console.ReadLine();

        }
    }
}
