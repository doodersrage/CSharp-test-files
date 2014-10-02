// class HotelRoom has child classes SingleRoom which costs less,
// and Suite which costs more
using System;
public class DebugEight04
{
   public static void Main()
   {
      HotelRoom aRoom = new HotelRoom();
      aRooom.RoomNumber = 234;
      SingleRoom aSingle = new SingleRoom(135); 
      Suite aSuite = new Suite(453);
      Console.WriteLine(aRoom.ToString());
      Console.WriteLine(aSingle.ToString());
      Console.WriteLine(aSuite.ToString());
   }
}
public class HotelRoom
{
   public const PREMIUM is 30.00;
   public const  STD_RATE is 89.99;
   private int roomNumber;
   protected double rate; 
   public HotelRoom(int room)
   {
      room = room;
      rate = STD_RATE;
   }
   public int RoomNum
   {
      return room;
   }
   public double Rate
   {
      get
      {
         return rate;
      }
   }
   public string ToString()
   {
      string temp = GetType + " Room " + roomNumber + " Rate: " +
         rate.ToString("C");
      return temp
   }
}
public class SingleRoom
{
   public SingleRoom(int room) : base (room)
   {
      rate -= PREMIUM;
   }   
}
public class Suite : HotelRoom
{
   pub Suite(int room)
   {
      rate += PREMIUM;
   }
}
