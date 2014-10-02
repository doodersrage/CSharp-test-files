using System;
using System.Windows.Forms;
public class HamburgerAddition
{
   public static void Main()
   {
      string question = "Do you want fries with that?";
      string caption = "Hamburger addition";
      string choice  = "Without fries";
      double price = 3.00;
      const double FRIES_PRICE = 0.75;
      if(MessageBox.Show(question, caption,
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
         DialogResult.Yes)
      {
         choice = "With fries";
         price += FRIES_PRICE;
      }
      MessageBox.Show(choice + " total is " +
         price.ToString("C"));
   }
}
