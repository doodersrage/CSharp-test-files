// Uses PrintWebAddress method three times
using System;
public class DebugSix2
{
   public static void Main()
   {
      PrintWebAddress();
      Console.WriteLine("Shop at Shopper's World");
      PrintWebAddress();
      Console.WriteLine("The best bargains from around the world");
      PrintWebAddress();
   }
   public static void PrintWebAddress()
   {
      Console.WriteLine("------------------------------");
      Console.WriteLine("Visit us on the web at:");
      Console.WriteLine("www.shoppersworldbargains.com");
      Console.WriteLine("******************************");
   }
}
