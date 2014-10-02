using System;
public class DemoSalesperson3
{
   public static void Main()
   {
      Employee clerk = new Employee();
      CommissionEmployee salesperson = new CommissionEmployee();
      clerk.EmpNum = 234;
      salesperson.EmpNum = 345;
      DisplayGreeting(clerk);
      DisplayGreeting(salesperson);
   }
   public static void DisplayGreeting(Employee emp)
   {
      Console.WriteLine("Hi there from #" + emp.EmpNum);
      Console.WriteLine(emp.GetGreeting());
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
