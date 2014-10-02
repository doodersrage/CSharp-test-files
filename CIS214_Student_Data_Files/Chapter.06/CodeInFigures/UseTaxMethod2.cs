using System;
public class UseTaxMethod2
{
   public static void Main()
   {
      double myPurchase = 239.11;
      double myRate = 0.10;
      DisplaySalesTax(myPurchase, myRate);
      DisplaySalesTax(16.55, 0.02);
   }
   public static void DisplaySalesTax(double saleAmount,
      double taxRate)
   {
      double tax;
      tax = saleAmount * taxRate;
      Console.WriteLine("The tax on {0} at {1} is {2}",
         saleAmount.ToString("C"),
         taxRate.ToString("P"), tax.ToString("C"));
   }
}
