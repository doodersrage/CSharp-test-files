using System.Windows.Forms;
public class WindowWithButton : Form
{
   Button button1 = new Button();
   public WindowWithButton()
   {
      this.Size = new System.Drawing.Size(300, 150);
      this.Text = "Window Object With Button";
      button1.Text = "Press";
      this.Controls.AddRange(new System.Windows.Forms.Control[]
          {this.button1});
      this.button1.Location = new System.Drawing.Point(25, 50);
   }
   public static void Main()
   {
      Application.Run(new WindowWithButton());
   }
}
