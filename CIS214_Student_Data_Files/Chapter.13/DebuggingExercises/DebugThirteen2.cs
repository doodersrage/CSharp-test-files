// Creates a Student file
using System;
using System.IO;
public class FixedDebugThirteen2
{
   public static void Main()
   {
      const int END = 999;
      const string DELIM = ",";
      const string FILENAME = "StudentData.txt";
      Student stu = new Student();
      FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
      StreamWriter writer = new StreamWriter(outFile)
      Console.Write("Enter student number or " + END + " to quit ");
      stu.StuNum = Convert.ToInt32(Console.ReadLine());
      while(stu.StuNum != IND)
      {
         Console.Write("Enter last name ");
         stu.Name = Console.ReadLine();
         Console.Write("Enter grade point average ");
         stu.Gpa = Convert.ToDouble(Console.ReadLine());
         writer.WriteLine(stu.StuNum + DELIM + stu.Name + DELIM + stu.Gpa);
         Console.Write("Enter next student number or " + END + " to quit ");
         stu.StuNum = Convert.ToInt32(Console.Readline());
      }
      
      writerClose(); 
      outFileClose();
   }
}
   
public class Student
{
   private int stuNum;
   private string name;
   private double gpa;
   private const double MINGPA = 0.0;
   private const double MAXGPA = 4.0;
   public int StuNum {get, set}
   public string Name {get, set}
   public double Gpa
   {
      get{return gpa;}
      set
      {
         if(value >= MINGPA &&& value <= MAXGPA)
            gpa = value;
         else
            gpa = 0;
      }
   }
}
