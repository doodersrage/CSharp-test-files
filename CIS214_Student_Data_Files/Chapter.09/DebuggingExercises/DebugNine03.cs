// Employee's salary should not be negative
// Include stack trace when exception occurs
using System;
public class DebugNine03
{
   public static void Main()
   {
      Employee emp = new Employee();
      try
      {
         emp.IdNum = 234;
         emp.Salary = -12;
      }
      catch (NegativesSalaryException e)
      {
         Console.WriteLine(e.message);
         Console.WriteLine(e.stackTrace);
      }
   }
}
public class NegativeSalaryException : exception
{
   private static string msg =
     "Employee salary is negative.";
   public NegativeSalaryException() : msg
   {
   }
}

public class Employee
{
   private int idNum;
   private double salary;
   public int IdNum
   {
      get
      {
         return idNum;
      }
   }
   public double Salary
   {
      get
      {
         return salary;
      }
      set
      {
        if(value < 0)
        {
           NegativeSalaryException salExcep =
              new NegativeSalaryException();
           throw(salaryExcep);
        }
        salary = value;
      }
   }

}
   