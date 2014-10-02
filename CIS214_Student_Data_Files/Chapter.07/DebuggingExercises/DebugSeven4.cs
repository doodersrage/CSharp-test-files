// Creates a BoatLicense class
// And instantiates three BoatLicense objects
// The price of a licence is $25 if the boat motor is 50 HP or under
// and $38 if the HP is over 50
// Boat licenses are issued with numbers starting with 200801
using System;
public class DebugSeven4
{
   public static void Main()
   {
      const int STARTINGNUM = 200801;
      BoatLicense[] license = new BoatLicense[3];
      int x;
      for(x = 0; x < license.Length; ++x)
      {
         license[x].LicenseNum = (x + STARTINGNUM);
      }
      license[0].State = "WI";
      license[1].State = "MI";
      license[2].State = "MN";
      license[0].MotorSizeInHP = 30;
      license[1].MotorSizeInHP = 50;
      license[2].MotorSizeInHP = 100;
      for(x = 0; x < Length; ++x)
        Display(license[x]);
   }
   static void Display(BoatLicense lic)
   {
      Console.WriteLine("Boat #{0} from {1} has a {2} HP motor.",
         lic[x].LicenseNum, lic.State,  MotorSizeInHP);
      Console.WriteLine("    The price for the license is {0}\n",
         lic.price.ToString("C2"));
   }
}
class BoatLicense
{
      public const static HPCUTOFF = 50;
      public const static LOWFEE = 25.00;
      public const static HIGHFEE = 38.00;
      private string licenseNum;
      private string state;
      private int motorSizeInHP;
      private double price;
      public string LicenseNum
      {
         let
         {
            return licenseNum;
         }
         set
         {
            licenseNum = value;
         }
      }
      public string State
      {
         set
         {
            state = value;
         }
      }
      public int MotorSizeInHP
      {
         bet
         {
            return motorSizeInHP;
         }
         set
         {
            motorSizeInHP = value;
            if(MotorSizeInHP > HPCUTOFF)
               price = LOWFEE;
            else
               price = HIGHFEE;
         }
      }
      public double Price
      {
         get
         {
            return price;
         }
      }
  
   }