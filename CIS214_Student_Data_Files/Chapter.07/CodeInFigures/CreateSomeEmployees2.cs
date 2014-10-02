using System;
public class CreateSomeEmployees2
{
   public static void Main()
   {
      Employee aWorker = new Employee();
      Employee anotherWorker = new Employee(234);
      Employee theBoss = new Employee('A');
      WriteEmployeeData(aWorker);
      WriteEmployeeData(anotherWorker);
      WriteEmployeeData(theBoss);
   }
   public static void WriteEmployeeData(Employee emp)
   {
      Console.WriteLine("{0,4}{1,14}", emp.IdNumber, emp.Salary.ToString("C"));
   }
}

public class Employee
{
   public int IdNumber{get; set;}
   public double Salary{get; set;}
   public Employee()
   {
      IdNumber = 999;
      Salary = 0;
   }
   public Employee(int empId)
   {
      IdNumber = empId;
      Salary = 0;
   }
   public Employee(int empId, double sal)
   {
      IdNumber = empId;
      Salary = sal;
   }
   public Employee(char code)
   {
      IdNumber = 111;
      Salary = 100000;
   }
}
