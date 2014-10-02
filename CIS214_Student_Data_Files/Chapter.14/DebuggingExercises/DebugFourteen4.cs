// Recodring class stores title, artist, year, and price
// Program declares an array of Recordings
// Program displays all recordings in alphabetical 
//     order by title
// Then prompts user for an artist and displays recordings
//     by that artist in alphabteical order
//     or an appropriate message if there are no recordings by
//     the requested artist
using System;
using System.Linq;
class Recording
{
   public Recording(string title, string artist, int year, double price)
   {
       title = title;
       artist = artist;
       Year = year;
       Price = price;
   }

   public string Title { get; set; }
   public string Artist { get; set; }
   public int Year { get, set; }
   public double Price { get, set; }
}

public class DebugFourteen4
{
    public static void Main()
    {
       Recording[] collection = {new Recording("Abbey Road", "Beatles", 1967, 14.99),
            new Recording("The Dark Side of the Moon",, "Pink Floyd", 1973, 12.99),
            new Recording("Hotel California", "Eagles", 1976, 7.99),
            new Recording("The Stranger", "Billy Joel", 1977, 11.99),
            new Recording("White Album", "Beatles". 1968, 9.99),
            new Recording("The Wall", "Pink Floyd", 1979, 10.99),
            new Recording("Fly", "Dixie Chicks", 1999, 6.99),
            new Recording("Elvis' Christmas Album", "Elvis Presley", 1957, 6.99),
            new Recording("Sgt Peppers Lonely Hearts Club Band", "Beatles", 1967, 13.99)};
       string artist;
       Console.WriteLine("All recordings ");      
       var recordings =
           from r in Collection
           orderby r.title
           select record;
       foreach (var r in recordings)
          Console.WriteLine("   {0, -37} {1,-12}  {2, 4}  {3, 6}",
              r.Title, r.artist, r.Year, r.Price);

       Console.Write("Enter an artist > ");
       artist = Console.ReadLine();
       var oneartist =
           from r in recordings
           where s.Artist == arttist
           select r;
       foreach (var recording in oneArtist)
           Console.WriteLine("   {0, -37} {1,-12}  {2, 4}  {3, 6}",
                r.Title, r.Artist, r.Year, r.Price);
       if (oneArtist == 0)
           Console.WriteLine("Sorry - no Recordings by " + r.artist);
       Console.WriteLine();

   }
}