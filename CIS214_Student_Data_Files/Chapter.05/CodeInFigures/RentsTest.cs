using System;
public class RentsTest
{
   public static void Main()
   {
      int[ , , ] rents = { { {400, 500}, {450, 550}, {500, 550}},
                     { {510, 610}, {710, 810}, {910, 1010}},
                     { {525, 625}, {725, 825}, {925, 1025}},
                     { {850, 950}, {1050, 1150}, {1250, 1350}}};

      int floor;
      int bedrooms;
      int bldg;
      string inputString;
      Console.Write("Enter the building number where you want to live ");
      inputString = Console.ReadLine();
      bldg = Convert.ToInt32(inputString);
      Console.Write("Enter the floor on which you want to live ");
      inputString = Console.ReadLine();
      floor = Convert.ToInt32(inputString);
      Console.Write("Enter the number of bedrooms you need ");
      inputString = Console.ReadLine();
      bedrooms = Convert.ToInt32(inputString);
      Console.WriteLine("The rent is {0}",
         rents[bldg, floor, bedrooms]);
   }
}
