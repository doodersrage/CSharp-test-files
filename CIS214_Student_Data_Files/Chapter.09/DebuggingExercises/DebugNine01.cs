// Handles a Format Exception if user does not enter a number
using System;
public class DebugNine01
{
   public static void Main()
   {
      double salary = 0;
      string salVal;
      bool isValidSalary;
      while (isValidSalary)
      {
         try
         {
            Console.Write("Enter an employee's salary ");
            salVal = Console.ReadLine();
            salary = ToDouble(salVal);
         }
         catch(FormatException fe)
         {
            Console.WriteLine
               ("You must enter a number for the salary");
         }
      }
      Console.WriteLine("The salary {0} is valid, salary.ToString(C2));
   }
}
