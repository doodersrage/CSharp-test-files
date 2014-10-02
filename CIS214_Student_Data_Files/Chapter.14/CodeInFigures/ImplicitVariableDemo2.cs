using System;
using System.Linq;
public class ImplicitVariableDemo2
{
  public static void Main()
  {
    char answer;
    Console.WriteLine("Do you want the integer value? ");
    answer = Convert.ToChar(Console.ReadLine()); 
    var result = (answer == 'y') ? 21 : "Twenty-one";
    Console.WriteLine("The value of var is {0}", result);
  }
}
