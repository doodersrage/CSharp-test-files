using System;
public class PriceListApplication1
{
   public static void Main()
   {
      int item;
      try
      {
         Console.Write("Enter an item number from 0 through 3 ");
         item = Convert.ToInt32(Console.ReadLine());
         PriceList.DisplayPrice(item);
      }
      catch(IndexOutOfRangeException e)
      {
         Console.WriteLine(e.Message + " The price is $0");
      }
   }
}
public class PriceList
{
   private static double[] price = {15.99, 27.88, 34.56, 45.89};
   public static void DisplayPrice(int item)
   {
      Console.WriteLine("The price is " +
         price[item].ToString("C"));
   }
}
