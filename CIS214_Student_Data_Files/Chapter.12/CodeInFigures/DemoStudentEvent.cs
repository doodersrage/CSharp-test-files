using System;
class DemoStudentEvent
{
   public static void Main()
   {
      Student oneStu = new Student();
      EventListener listener = new EventListener(oneStu);
      oneStu.IdNum = 2345;
      oneStu.IdNum = 4567;
      oneStu.Gpa = 3.2;
   }
}

public delegate void ChangedEventHandler
   (object sender, EventArgs e);

public class Student
{
   private int idNum;
   private double gpa;
   public event ChangedEventHandler Changed;
   public int IdNum
   {
      get
      {
         return idNum;
      }
      set
      {
         idNum = value;
         OnChanged(EventArgs.Empty);
      }
   }
   public double Gpa
   {
      get
      {
         return gpa;
      }
      set
      {
         gpa = value;
         OnChanged(EventArgs.Empty);
      }
   }
   public void OnChanged(EventArgs e)
   {
      Changed(this, e);
   }
}

class EventListener
{
   private Student stu;
   public EventListener(Student student)
   {
      stu = student;
      stu.Changed += new ChangedEventHandler
        (StudentChanged);
   }
   private void StudentChanged(object sender, EventArgs e)
   {
      Console.WriteLine("The student has changed.");
      Console.WriteLine("   ID# {0}  GPA {1}",
        stu.IdNum, stu.Gpa);
   }
}
