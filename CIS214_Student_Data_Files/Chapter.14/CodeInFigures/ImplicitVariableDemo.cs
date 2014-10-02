using System;
public class ImplicitVariableDemo
{
   public static void Main()
   {
      int[] numbers = { 6, 4, 2, 1, 8, 3, 7, 5, 2, 0 };
      Console.WriteLine("Numbers List");
      foreach (var n in numbers)
         Console.WriteLine(n);
   }
}
