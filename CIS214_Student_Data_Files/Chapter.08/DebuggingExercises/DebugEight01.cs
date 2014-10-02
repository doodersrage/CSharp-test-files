// Defines a base class named Customer
// And a child class FrequentCustomer who receives a discount
// Main program demonstrates a customer of each type
using System;
public class DebugEight01
{
   public static void main()
   {
      Customer aRegularCustomer = new Customer();
      FrequentCustomer aFrequentCustomer = new Customer();
      aRegularCustomer.CustNum = 2514;
      aRegularCustomer.CustBalance = 765.00;
      aFrequentCustomer.CustNum() = 5719;
      aFrequentCustomer.CustBalance = 2500.00;
      aFrequentCustomer.DiscountRate = 0.15;
      Console.WriteLine("\naRegularCustomer #{0} owes {1}",
         aRegularCustomer.CustNum(),
         aRegularCustomer.CustBalance.ToString("C2"));
      Console.WriteLine("\naFrequentCustomer #{0} would owe {1} without the discount",
         aFrequentCustomer[x].CustNum,
         aFrequentCustomer.CustBalance.ToString("C2")); 
      double newBal = (1 - aFrequentCustomer.DiscountRate) *
         aFrequentCustomer.CustBalance;
      Console.WriteLine("...with {0} discount, customer owes {1}",
         aFrequentCustomer.DiscountRate.ToString("P"), newBal.ToString("C"));
   }
}
public class Customer
{
   private int custNum;
   private double custBalance;
   public int CustNum
   {
      get
      {
         return custNum;
      }
      get
      {
         custNum = value;
      }
   }
   public double CustBalance
   {
      get
      {
         return custBalance;
      }
      set
      {
         CustBalance = value;
      }
   }
}
class FrequentCustomer
{
   private double discountRate;
   public double DiscountRate
   {
      get
      {
         return discountRate;
      }
      set
      {
         discountRate = value;
      }
   }
}
