// Method gives bonus points
// whether grade is a number or letter
using System;
public class DebugSix4
{
   public static void Main()
   {
      int numericScore = 82;
      string letterScore = "B";
      Console.Write("Score was {0}. ", numericScore);
      GiveBonus(ref numericScore);
      Console.WriteLine("Now it is {0}.", numericScore);
      Console.Write("Grade was {0}. ", letterScore);
      GiveBonus(ref letterScore);
      Console.WriteLine("Now it is {0}.", letterScore);
      Console.ReadLine();
   }
   public static void GiveBonus(ref int testScore)
   {
	const int BONUS = 5;
        testScore += BONUS;
   }
   public static void GiveBonus(ref string letterScore)
   {
        const string BONUS = "+";
        letterScore += BONUS;
   }
}

