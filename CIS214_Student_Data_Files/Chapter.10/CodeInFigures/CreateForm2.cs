using System.Windows.Forms;
public class CreateForm2
{
   public static void Main()
   {
      Form form2 = new Form();
      form2.Text = "This is a Form2 Form";
      form2.HelpButton = true;
      form2.MaximizeBox = false;
      form2.MinimizeBox = false;
      form2.ShowDialog();
   }
}
