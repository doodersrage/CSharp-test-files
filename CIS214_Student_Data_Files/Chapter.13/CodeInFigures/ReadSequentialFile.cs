using System;
using System.IO;
public class ReadSequentialFile
{
   public static void Main()
   {
      const char DELIM = ',';
      const string FILENAME = "EmployeeData.txt";
      Employee emp = new Employee();
      FileStream inFile = new FileStream(FILENAME,
         FileMode.Open, FileAccess.Read);
      StreamReader reader = new StreamReader(inFile);
      string recordIn;
      string[] fields;
      Console.WriteLine("\n{0,-5}{1,-12}{2,8}\n",
         "Num", "Name", "Salary");
      recordIn = reader.ReadLine();
      while(recordIn != null)
      {
         fields = recordIn.Split(DELIM);
         emp.EmpNum = Convert.ToInt32(fields[0]);
         emp.Name = fields[1];
         emp.Salary = Convert.ToDouble(fields[2]);
         Console.WriteLine("{0,-5}{1,-12}{2,8}",
            emp.EmpNum, emp.Name, emp.Salary.ToString("C"));
         recordIn = reader.ReadLine();
      }
      reader.Close();
      inFile.Close();
   }
}
public class Employee
{
   private int empNum;
   private string name;
   private double salary;
   public int EmpNum {get; set;}
   public string Name {get; set;}
   public double Salary{ get; set;}
}