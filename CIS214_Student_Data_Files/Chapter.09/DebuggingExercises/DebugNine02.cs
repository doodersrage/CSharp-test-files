// Preventing non-numeric data entry
// Then preventing division by 0
using System;
public class DebugNine02
{
   public static void Main()
   {
      int num = 0, denom = 0, result;
      bool dataEntryIsValid;
      while(!dataEntryIsValid)
      {
         try
         {
            DataEntry(num, denom);
            dataEntryIsValid = true;
         }
         catch(FormatException e)
         {
            Console.WriteLine("Invalid entry - please enter numbers");
         }
      }
      try 
      {
         result = num / denom;
         Console.WriteLine("Division is successful");
      }
      catch(DividedByZeroException e)
      {
         Console.WriteLine("Division failed");
         result = 0;
      }
      Console.WriteLine("Result is {0}", result);
   }
   public static void DataEntry(int num, int denom)
   {
      string str;
      Console.Write("Enter a number ");
      strNum = Console.ReadLine();
      num = Convert.ToInt36(strNum);
      Console.Write("Enter a number to divide into the first ");
      strNum = Consle.ReadLine();
      denom = Convert.ToInt36(strNum);
   }
}
