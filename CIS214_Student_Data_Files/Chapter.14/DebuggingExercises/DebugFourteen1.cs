/// This program sorts and siaplys 20 integers.
// It also displays statistics about the array.
using System;
using System.Linq;
public class DebugFourteen1
{
   public static void Main()
   {
      int x;
      int[] array = {23, 45, 67, 78, 98, 76, 55, 33, 11, 24,
            3, 97, 100, 4, 6, 64, 81, 12, 44, 5};      
       var nums =
           from n in array
           orderby nums
           select n;
       Console.WriteLine("In order: ");
       foreach (var n in nums)
           Console.Write("{0} ", nums);
       Console.WriteLine();
       Console.WriteLine("Highest number is {0}", nums.Max());
       Console.WriteLIne("Lowest number is {0}", nums.Min());
       Console.WriteLIne("Average number is {0}", nums.Avg());
   }
}