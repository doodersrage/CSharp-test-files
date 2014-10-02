using System;
using System.Windows.Forms;
public class MessageBoxExperiment
{
   public static void Main()
   {
      const string MESSAGE = "Hello";
      const string CAPTION = "Message box experiment";
      MessageBox.Show(MESSAGE);
      MessageBox.Show(MESSAGE, CAPTION);
      MessageBox.Show(MESSAGE, CAPTION,
         MessageBoxButtons.OKCancel);
   }
}