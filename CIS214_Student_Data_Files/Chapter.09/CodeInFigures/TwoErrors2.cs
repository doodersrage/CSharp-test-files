using System;
public class TwoErrors2
{
   public static void Main()
   {
      int num = 13, denom = 0, result;
      int[] array = {22, 33, 44};
      try
      {
         result = num / denom; // First try
         result = array[num]; // Second try
      }
      catch(Exception error)
      {
         Console.WriteLine(error.Message);
      }
   }
}
