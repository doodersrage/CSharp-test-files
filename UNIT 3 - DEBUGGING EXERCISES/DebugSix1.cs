// GetData() method accepts order number and quantity
// that are used in the Main() method
// Price is #3.99 each
using System;
public class DebugSix1
{
   public static void Main()
   {
      int orderNum, quantity;
      double total;
      const double PRICE_EACH = 3.99;
      GetData(out orderNum, out quantity);
      total = quantity * PRICE_EACH;
      Console.WriteLine("Order #{0}. Quantity ordered = {1}", orderNum, quantity);
      Console.WriteLine("Total is {0}", total.ToString("C"));

      Console.ReadLine();
   }
   public static void GetData(out int order, out int amount)
   {
       String s1, s2;
       Console.Write("Enter order number ");
       s1 = Console.ReadLine();
       Console.Write("Enter quantity ");
       s2 = Console.ReadLine();
       order = Convert.ToInt32(s1);
       amount = Convert.ToInt32(s2);
   }
}

