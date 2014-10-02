using System;
public class TestHashCode
{
   public static void Main()
   {
      Employee first = new Employee();
      Employee second = new Employee();
      Console.WriteLine(first.GetHashCode());
      Console.WriteLine(second.GetHashCode());
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
