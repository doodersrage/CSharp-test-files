using System;
public class HandlingAFormatException
{
   public static void Main()
   {
      int playerNumber = 0;
      string strNumber;
      bool isGoodNumber = false;
      while(!isGoodNumber)
      {
         try
         {
            Console.Write("Enter player’s number ");
            strNumber = Console.ReadLine();
            playerNumber = Convert.ToInt32(strNumber);
            isGoodNumber = true;
         }
         catch(FormatException fe)
         {
            Console.WriteLine(fe.Message +
               " Player's number should be an integer.");
         }
      }
      Console.WriteLine("Player's number is " + playerNumber);
   }
}
