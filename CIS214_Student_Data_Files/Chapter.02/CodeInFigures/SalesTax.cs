using System;
public class SalesTax
{
   public static void Main()
   {
      const double TAX_RATE = .06;
      double itemPrice = 3.99;
      double tax;
      tax = itemPrice * TAX_RATE;
      Console.WriteLine("With {0} tax, a {1} item costs {2} more",
         TAX_RATE, itemPrice.ToString("C"), tax.ToString("C"));
      itemPrice = 145.65;
      tax = itemPrice * TAX_RATE;
      Console.WriteLine("With {0} tax, a {1} item costs {2} more",
         TAX_RATE, itemPrice.ToString("C"), tax.ToString("C"));
   }
}
