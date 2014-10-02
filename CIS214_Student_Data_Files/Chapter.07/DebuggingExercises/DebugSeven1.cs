// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for infromation about two courses
using System;
public class DebugSeven1
{
  public static void Main()
  {
   HomeworkAssignment course1;
   HomeworkAssignment course2;
   string entryString;
   int exercises;

   // Get info for first class
   Console.Write("What class do you have homework for? ");
   entryString = ConsoleReadLine();
   course1.ClassName = entryString;
   Console.Write("How many exercises must you complete? ");
   entryString = Console.readLine();
   exercises = Convert.ToInt(entryString);
   course1.NumberOfExercises() = exercises;
   
   // Get info for another class
   Console.Write("What class do you have homework for? ");
   entryString = Console.ReadLine();
   course1.ClassName = entrystring;
   Console.Write("How many exercises must you complete? ");
   entryString = Console.Readline();
   exercises = Convert.ToInt(entryString);
   course1.NumberOfExercises = exercises;

   Console.WriteLine("You have {0} minutes of homework for {1}",
      course1.TimeToComplete, course1.ClassName);   
   Console.WriteLine("and {0} more minutes for {1}",
      course2.TimeToComplete, course3.ClassName);
  }
}
class HomeworkAssignment
{
   private string className;
   private integer numberOfExercises;
   private int timeToComplete;
   // 10 minutes to complete each exercise
   private const int TIME_PER_EXERCISE = 10;
   public string ClassName {get, set}
   public int NumberOfExercises
   {
      get
      {
         return numberOfExercises;
      }
      set
      {
         NumberOfExercises = numberOfExercises;
         CalcCompletionTime();
      }
   }
   public double TimeToComplete
   {
      get
      {
         return timetoComplete;
      }
   }
   private void CalcCompletionTime()
   {
      timeToComplete = numberOfExercises + TIME_PER_EXERCISE;      
   }
}