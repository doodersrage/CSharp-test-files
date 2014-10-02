using System;
using System.Windows.Forms;
public class MessageBoxDemo
{
   public static void Main()
   {
      string message = "This is message ";
      string caption = "Message box experiment ";
      int count = 1;
      MessageBox.Show(message + count);
      ++count;
      MessageBox.Show(message + count, caption + count);
      ++count;
      MessageBox.Show(message + count, caption + count,
         MessageBoxButtons.OKCancel);
      ++count;
      MessageBox.Show(message + count, caption + count,
         MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
      ++count;
      MessageBox.Show(message + count, caption + count,
         MessageBoxButtons.YesNoCancel,
         MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button3);
   }
}
