using System;
using System.Linq;
public class LinqDemo2
{
  public static void Main()
  {
    Student[] stus = {  new Student(1,  "Jones",    3.1),
                        new Student(2,  "Kimball",  2.9),
                        new Student(5,  "Oliver",   2.6),
                        new Student(6,  "Mitchell", 3.0),
                        new Student(8,  "Lee",      4.0),
                        new Student(10, "Cooper",   3.5) };
    const double CUTOFF = 3.0;
    var goodStudents =
        from s in stus
        where s.GradePointAverage > CUTOFF
        select s;

    Console.WriteLine("Students with GPA > " + CUTOFF);
    foreach (var s in goodStudents)
    {
        Console.WriteLine("{0,3} {1,-8} {2,5}", s.IdNumber,
           s.Name, s.GradePointAverage.ToString("F1"));
    }
  }
}

public class Student
{
   private int idNumber;
   private string name;
   private double gradePointAverage;
   public Student(int num, string name, double avg)
   {
      IdNumber = num;
      Name = name;
      GradePointAverage = avg;
   }   
   public int IdNumber {get; set;}
   public string Name {get; set;}
   public double GradePointAverage {get; set;}
}
