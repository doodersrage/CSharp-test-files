using System;
using System.Windows.Forms;
public class MessageBoxExperiment2
{
   public static void Main()
   {
      const string MESSAGE = "How are you?";
      const string CAPTION = "Message box experiment 2";
      MessageBox.Show(MESSAGE);
      MessageBox.Show(MESSAGE, CAPTION);
      MessageBox.Show(MESSAGE, CAPTION,
         MessageBoxButtons.YesNoCancel,
         MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button3);

   }
}