using System;
class DiverseObjects
{
   public static void Main()
   {
      Student payingStudent = new Student();
      ScholarshipStudent freeStudent = new ScholarshipStudent();
      Employee clerk = new Employee();
      Console.Write("Using Student: ");
      DisplayObjectMessage(payingStudent);
      Console.Write("Using ScholarshipStudent: ");
      DisplayObjectMessage(freeStudent);
      Console.Write("Using Employee: ");
      DisplayObjectMessage(clerk);
   }
   public static void DisplayObjectMessage(Object o)
   {
      Console.WriteLine("Method successfully called");
   }
}
public class Employee
{
   private int empNum;
   protected double empSal;
   public int EmpNum {get; set;}
   public double EmpSal {get; set;}
   public string GetGreeting()
   {
      string greeting = "Hello. I am employee #" + EmpNum;
      return greeting;
   }
}
public class CommissionEmployee : Employee
{
   private double commissionRate;
   public double CommissionRate
   {
      get
      {
         return commissionRate;
      }
      set
      {
         commissionRate = value;
         empSal = 0;
      }
   }
   new public string GetGreeting()
   {
      string greeting = base.GetGreeting();
      greeting += "\nI work on commission.";
      return greeting;
   }
}
class Student
{
   private const double RATE = 55.75;
   private string name;
   protected int credits;
   protected double tuition;
   public string Name {get; set;}
   public int Credits
   {
      get
      {
         return credits;
      }
      set
      {
          credits = value;
          tuition = credits * RATE;
      }
   }
   public double Tuition
   {
      get
      {
         return tuition;
      }
   }
}

class ScholarshipStudent : Student
{
    new public int Credits
    {
      set
      {
         credits = value;
         tuition = 0;
      }
    }
}
