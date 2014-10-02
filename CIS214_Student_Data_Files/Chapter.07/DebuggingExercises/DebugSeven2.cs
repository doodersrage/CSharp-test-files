// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using System;
public class DebugSeven2
{
   Breakfast special = new Breakfast("French toast", 4.99);
   //Display the info about breakfast
   Console.WriteLine(Breakfast.info);
   // then display today's special
   Console.WriteLine("Today we are having {0} for {1}",
      special.Name, special.Price.ToString("C2"));
}
class Breakfast
{
   // info is  class field
   public static string info = 
      "Breakfast is the most important meal of the day.";
   private string name;
   private double price;
   // Breakfast constructor requires a
   // name, e.g "French toast", and a price
   private Breakfast(string name, double price)
   {
       Name = Name;
       price = price;
   }
   public string Name (get; set;)
   public double Price (get; set;)
}