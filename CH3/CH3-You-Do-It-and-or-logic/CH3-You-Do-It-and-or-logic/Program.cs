using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH3_You_Do_It_and_or_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ZONE1 = 1, ZONE2 = 2;
            const int LOWQUALITY = 10;
            string inputString;
            int quantity;
            int deliveryZone;

            Console.WriteLine("Delivery is free for zone {0} or {1}", ZONE1, ZONE2);
            Console.WriteLine("when the number of boxes is less than {0}", LOWQUALITY);
            Console.WriteLine("Enter delivery zone ");
            inputString = Console.ReadLine();
            deliveryZone = Convert.ToInt32(inputString);
            Console.WriteLine("Enter the number of boxes in the shipment");
            inputString = Console.ReadLine();
            quantity = Convert.ToInt32(inputString);

            if (deliveryZone == ZONE1 || deliveryZone == ZONE2 && quantity < LOWQUALITY)
                Console.WriteLine("Delivery is free");
            else
                Console.WriteLine("A delivery charge applies");

        }
    }
}
