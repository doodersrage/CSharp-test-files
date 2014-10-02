// FixedDebugFive02
// Program averages four numbers
using System;
public class FixedDebugFive02
{
   public static void Main()
   {
      int[] numbers = {12, 15, 22, 88};
      int x;
      double average;
      double total = 0;
      Console.Write("\nThe numbers are...");
      for(x = 0; x < numbers.Length; ++x)
         Console.Write("{0, 6}", numbers[x]);
      Console.WriteLine();      
      for(x = 0; x < numbers.Length; ++x)
      {
         total += numbers[x];
      }   
      average = total / numbers.Length;
      Console.Write("The average is {0}", average);
   }
}