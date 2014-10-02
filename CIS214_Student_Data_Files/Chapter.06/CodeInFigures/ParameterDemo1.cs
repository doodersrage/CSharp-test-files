using System;
public class ParameterDemo1
{
   public static void Main()
   {
      int var = 4;
      Console.WriteLine("In Main var is {0}", var);
      MethodWithValueParam(var);
      Console.WriteLine("In Main var is {0}", var);
   }
   public static void MethodWithValueParam(int var)
   {
      var = 777;
      Console.WriteLine("In MethodWithValueParam, param is {0}", var);
   }
}
