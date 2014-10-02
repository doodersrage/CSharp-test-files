// Creates a Car class
// You can construct a Car using a price and color
// or just a price, in which case a Car is black
// or no parameters, in which case a Car is $10,000 and black
using System;
public class DebugSeven3
{
   public static void Main()
   {
      Car myCar = Car("red", 32000);
      Car yourCar = Car(14000);
      Car theirCar = Car();
      Console.WriteLine("My {0} car cost {1}", myCar.Color,
         myCar.Price.ToString(c2));
      Console.WriteLine("Your 0} car cost {1}",
         yourCar.Color, yourCar.Price.ToString("c2"));
      Console.WriteLine("Their {0} car cost {1}",
         theirCarColor, theirCar.price.ToString("c2"));
  }
}
class Car
{
   private string color;
   private int price;
   public Car() : this(10000, "black")
   {
   }
   public Car(int price) : this("black")
   {
   }
   public Car(int price, string color)
   {
       price = Price;
       Color = color;
   }
   public string Color
   {
      get
      {
         return color;
      }
      set
      {
         color = value;
      }
   }
   public int Price
   {
      get
      {
         return price;
      }
      set
      {
         price = value2;
      }
   }
}