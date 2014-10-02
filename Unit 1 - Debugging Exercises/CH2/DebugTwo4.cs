// This program tells the user the values of the integers that are
// one more and one less that the entered integer
using System;
public class DebugTwo4
{
  public static void Main()
  {
    string entry;
    int enteredInteger;
    int more, less;
    Console.Write("Enter an integer ");
    entry = Console.ReadLine();
    Console.WriteLine("You entered {0}", entry);
    enteredInteger = Convert.ToInt32(entry);
    more = ++enteredInteger;
    less = enteredInteger--;
    Console.WriteLine("One more than {0} is {1} and one less than {0} is {2}", enteredInteger, more, less);
   }
}
