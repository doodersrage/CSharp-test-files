using System;
public class ParameterDemo2
{
   public static void Main()
   {
      int var = 4;
      Console.WriteLine("In Main var is {0}", var);
      MethodWithRefParam(ref var);  // notice use of ref
      Console.WriteLine("In Main var is {0}", var);
   }
   public static void MethodWithRefParam(ref int myParam)  
      // notice use of ref
   {
      myParam = 888;
      Console.WriteLine("In MethodWithRefParam, myParam is {0}",
         myParam);
   }
}
