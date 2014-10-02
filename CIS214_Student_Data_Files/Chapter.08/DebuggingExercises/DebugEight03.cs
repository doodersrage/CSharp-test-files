// Interface IReversing defines behavior Reverse()
// Reverse is implemented differently for a Soldier and a PhoneCall
// Main program demonstrates an object of each type
using System;
class DebugEight03
{
   public static void Main()
   {
      Soldier giJoe = Soldier(266143);
      PhoneCall aCall = new PhoneCall("212", "344-4188");
      Console.WriteLine(giJoe.ToString());
      giJoe.Reverse;
      Console.WriteLine(giJoe.ToString());
      giJoe.Reverse;
      Console.WriteLine(giJoe.ToString());
      Console.WriteLine(aCall.ToString());
      aCall.Reverse;
      Console.WriteLine(aCall.ToString());
   }
}
public interface IReversing
{
   void Reverse;
}
public class Soldier : IReversing
{
   private int idNum;
   private string facing;
   public Soldier(int id)
   {
      idNum = id;
      facing = "front";
   }
// When a Soldier reverses if the Soldier was facing front, change to back
// If the Soldier was facing back, change to front
   public void Reverse()
   {
      if(facing == "front")
         faing = "back";
      else
         facin = "front"
   }
   public override string ToString()
   {
      string temp = "Soldier #" + idNum + " is facing " + facing;
      return soldier;
   }
}
public class PhoneCall : IReversing
{
   private string areaCode;
   private string number;
   private double charge;
   private string mode;

   public PhoneCall(string area, string num)
   {
      areaCode = area;
      number = num;
      charge = 0.25;
      mode = "regular";
   }
// When a phone call reverses, mode becomes collect and charge becomes 0
   public void Reverse()
   {
      mode = "collect";
      charge = 0;
   }
   public string ToString()
   {
      string temp = "( areaCode + ") " + number " Charge " + charge.ToString("C") +
         " Call is " + mode;
      return temp;
   }
}

