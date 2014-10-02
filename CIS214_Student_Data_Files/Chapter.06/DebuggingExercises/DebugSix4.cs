// Method gives bonus points
// whether grade is a number or letter
using System;
public class DebugSix4
{
   public static void Main()
   {
      int numericScore = 82;
      string letterScore = 'B';
      Console.Write("Score was {0}. ", numericScore);
      GiveBonus(numericScore);
      Console.WriteLine("Now it is {0}.", numbericScore);
      Console.Write("Grade was {0}. ", letterScore);
      GiveBonus(letterScore);
      Console.WriteLine("Now it is {0}.", letterScore);
   }
   public static void GiveBonus(int testScore)
   {
	const int BONUS = 5;
        testScore += BINUS;
   }
   public static void GiveBonus(string letterScore)
   {
        const string BONUS = "+";
        letterScore += BONUS;
   }
}

