// Program asks user to enter password
// If password is not "home", "lady" or "mouse"
// the user must re-enter the password
using System;
public class DebugFour1
{
  public static void Main()
  {
      const string PASS1 = "home";
      const string PASS2 = "lady";
      const string PASS3 = "mouse";
      bool valid = false;
      string password;

      Console.Write("Please enter your password ");
      password = Console.ReadLine();
      while (valid == false)
      {
          Console.WriteLine("Invalid password. Please enter again. ");
          password = Console.ReadLine();
          if (String.Equals(PASS1, password) || String.Equals(PASS2, password) || String.Equals(PASS3, password))
              valid = true;
      }
      Console.WriteLine("Valid password");

   }
}
