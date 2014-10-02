using System;
public class TwoErrors
{
   public static void Main()
   {
      int num = 13, denom = 0, result;
      int[] array = {22, 33, 44};
      try
      {
         result = array[num]; // New first try
         result = num / denom; // Old first try
      } 

      catch(DivideByZeroException error)
      {
         Console.WriteLine("In first catch block: ");
         Console.WriteLine(error.Message);
      }
      catch(IndexOutOfRangeException error)
      {
         Console.WriteLine("In second catch block: ");
         Console.WriteLine(error.Message);
      }
   }
}
