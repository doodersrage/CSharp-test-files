using System;
class DemoWorking
{
   public static void Main()
   {
      Employee bob = new Employee("Bob");
      Dog spot = new Dog("Spot");
      Cat puff = new Cat("Puff");
      Console.WriteLine(bob.Name + " says " + bob.Work());
      Console.WriteLine(spot.Name + " says " + spot.Work());
      Console.WriteLine(puff.Name + " says " + puff.Work());
   }
}
public interface IWork
{
  string Work();
}
class Employee : IWork
{
   private string name;
   public Employee(string name)
   {
       Name = name;
   }
   public string Name
   {
       get
       {
          return name;
       }
       set
       {
          name = value;
       }
    }
    public string Work()
    {
       return "I do my job";
    }
}
abstract class Animal : IWork
{
     protected string name;
     public Animal(string name)
     {
          Name = name;
     }
     public string Name {get; set;}
     public abstract string Work();
}
class Dog : Animal
{
   public Dog(string name) : base(name)
   {
   }
   public override string Work()
   {
      return "I watch the house";
   }
}
class Cat : Animal
{
   public Cat(string name) : base(name)
   {
   }
   public override string Work()
   {
      return "I catch mice";
   }
}
