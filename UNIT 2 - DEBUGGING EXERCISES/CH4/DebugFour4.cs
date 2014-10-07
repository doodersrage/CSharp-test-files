// How much money will you have
// after 30 days if you get a penny on the
// first day and it doubles every day?

using System;
public class DebugFour4
{
   public static void Main()
   {
       const double LIMIT = 1000000.00;
       const double START = 0.01;
       string inputString;
       double total;
       int howMany;
       double count;
       Console.Write("How many days do you think ");
       Console.WriteLine("it will take you to reach");
       Console.Write("{0} starting with {1}",
         LIMIT.ToString("C"), START.ToString("C"));
       Console.WriteLine("and doubling it every day?");
       inputString = Console.ReadLine();
       howMany = Convert.ToInt32(inputString);
       count = LIMIT;
       total = START;
       while (total < LIMIT)
           total = total * 2;
       count = count + 1;
       if (howMany == count)
           Console.WriteLine("Your guess was correct.");
       else
           if (howMany > count)
               Console.WriteLine("Your guess was too high.");
           else
               Console.WriteLine("Your guess was too low.");
       Console.WriteLine("It takes {0} days to reach {1}",
          count, LIMIT.ToString("C"));
       Console.WriteLine("when you double {0} every day",
          START.ToString("C"));
   }
}

