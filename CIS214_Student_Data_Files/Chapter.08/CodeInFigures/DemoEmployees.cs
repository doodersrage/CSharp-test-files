using System;
public class DemoEmployees
{
   public static void Main()
   {
      Employee clerk = new Employee();
      CommissionEmployee salesperson = new CommissionEmployee();
      clerk.EmpNum = 123;
      clerk.EmpSal = 30000.00;
      salesperson.EmpNum = 234;
      salesperson.EmpSal = 20000;
      salesperson.CommissionRate = 0.07;
      Console.WriteLine("\n" + clerk.GetGreeting());
      Console.WriteLine("Clerk #{0} makes {1} per year",
         clerk.EmpNum,
         clerk.EmpSal.ToString("C"));
      Console.WriteLine("\n" + salesperson.GetGreeting());
      Console.WriteLine("Salesperson #{0} makes {1} per year",
         salesperson.EmpNum,
         salesperson.EmpSal.ToString("C"));
      Console.WriteLine("...plus {0} commission on all sales",
         salesperson.CommissionRate.ToString("P"));
   }
}
public class Employee
{
   private int empNum;
   private double empSal;
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
   public double CommissionRate {get; set;}
}
