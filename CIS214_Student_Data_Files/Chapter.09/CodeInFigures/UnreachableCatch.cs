using System;
public class UnreachableCatch
{
   public static void Main()
   {
      int num = 13, denom = 0, result;
      try
      {
         result = num / denom;
      }
      catch(Exception error)
      {
         Console.WriteLine(error.Message);
      }
      catch(DivideByZeroException error)
      {
         Console.WriteLine(error.Message);
      }
   }
}
