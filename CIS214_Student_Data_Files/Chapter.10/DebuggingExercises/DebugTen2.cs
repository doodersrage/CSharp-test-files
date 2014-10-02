// Debug 10-2
// Creates a Form with a MaximizeBox and 
// and MinimizeBox
using System;
using System.Windows.Forms;
using System.Drawing;
public class FixedDebugTen2
{
   public static void Main()
   {
      Form aForm = Form();
      aForm.Text = "This is a Form";
      Form.MaximizeBox = false;
      aFormMinimizeBox = true;
      aForm.ShowDialog();
}
