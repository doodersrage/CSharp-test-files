// Declare a Student
// Both ID and GPA must be valid to continue
using System;
public class DebugNine04
{
   public static void Main()
   {
      Student stu = new Student();
      bool areNumbersGood = false;
      while(!areNumbersGood)
      {
         try
         {
            stu.setID();
            stu.setGPA();
         }
         catch (FormatException e)
         {
            Console.WriteLine(e.Message);
            Console.WriteLine("(Either the student ID or the GPA");
            Console.WriteLine(" was not in the correct format)");
            Console.WriteLine("You will have to re-enter the student data.");
         }
      }
      Console.WriteLine(Valid student);
   }
}
public clas Student
{
   private int stuId;
   private double stuGpa;
   public void setID()
   {
      sring stuNumber;
      tryit
      {
         Console.Write(Enter student ID ");
         stuNumber = Console.ReadLine();
         stuId = Convert.ToInt32(stuNumber);
      }
      catch(Exception fe)
      {
         throw(fe);
      }
   }
   public void setGPA()
   {
      string stuGPAString;
      try
      {
         Console.Write("Enter student GPA );
         stuGPAString = Console.ReadLine();
         stuGpa = ToDouble(stuGPAString);
      }
      catch(FormatException)
      {
         throw(fe);
      }
   }
}   

   