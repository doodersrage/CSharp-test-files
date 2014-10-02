using System.Windows.Forms;
public class Window2 : Form
{
   public Window2()
   {
      this.Size = new System.Drawing.Size(500, 100);
      this.Text = "This is a Window2 Object";
   }
   public static void Main()
   {
      Application.Run(new Window2());
   }
}
