using System;
public class ReThrow
{
   public static void Main()
   {
      try
      {
         Console.WriteLine("Trying in Main() method");
         MethodA();
      }
      catch(Exception ae)
      {
         Console.Write("Caught in Main() method -- ");
         Console.WriteLine(ae.Message);
      }
      Console.WriteLine("Main() method is done");
   }
   public static void MethodA()
   {
      try
      {
         Console.WriteLine("Trying in method A");
         MethodB();
      }
      catch(Exception)
      {
         Console.WriteLine("Caught in method A");
         throw;
      }
   }
   public static void MethodB()
   {
      try
      {
         Console.WriteLine("Trying in method B");
         MethodC();
      }
      catch(Exception)
      {
         Console.WriteLine("Caught in method B");
         throw;
      }
   }
   public static void MethodC()
   {
      Console.WriteLine("In method C");
      throw(new Exception("This came from method C"));
   }
}
