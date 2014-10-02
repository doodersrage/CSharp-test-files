using System;
public class CreateEmployeeWithAutoImplementedProperty2
{
   public static void Main()
   {
      Employee aWorker = new Employee();
      //aWorker.IdNumber = 3872;
      aWorker.Salary = 22.11;
      Console.WriteLine("Employe #{0} makes {1}", aWorker.IdNumber,
         aWorker.Salary.ToString("C"));
   }
}
public class Employee
{
   public int IdNumber{get; private set;}
   public double Salary{get; set;}
}
