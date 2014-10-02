// Program takes a hot dog order
// And determines price
using System;
public class DebugThree1
{
   public static void Main()
   {
       const double BASIC_DOG_PRICE = 2.00;
       const double CHILI_PRICE = 0.69;
       const double CHEESE_PRICE = 0.49;
       String wantChili, wantCheese;
       double price;
       Console.WriteLine("Do you want chili on your dog? ");
       wantChili = Console.ReadLine();
       Console.WriteLine("Do you want cheese on your dog? ");
       wantCheese = Console.ReadLine();
       if (wantChili.ToUpper().Equals("Y"))
           if (wantCheese.ToUpper().Equals("Y"))
               price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
           else
               price = BASIC_DOG_PRICE + CHILI_PRICE;
       else
           price = BASIC_DOG_PRICE + CHEESE_PRICE;

       Console.WriteLine("Your total is {0}", price.ToString("C"));
   }
}
