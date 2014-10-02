// Program declares an array of names
// Lists all names in alphabetical order
// Then lists in two groups
//   -- those that start with a vowel and those that do not 
using System;
using System.Linq;
public class FixedDebugFourteen2
{
    public static void Main()
    {
        string[] names = {"Andrea", "Audrey", "Danielle", "Brooke", "Eric",
                          "Brittany", "Lindsay", "Geoffrey",
                          "Abby", "Carly", "Emily", "Robin", "Carmen", "Dustin",
                          "Roger", "Ryan", "Stacy", "Tim", "Marcia",
                          "Annette", "Steve", "Sue", "Rich", "Ruth",
                          "Bob", "Helen", "Butch", "Carol", "Jim",
                          "Karen", "Gladys", "Kathy", "Cheryl", "Scott",
                          "Savannah", "Dylan", "Gabby", "Jann", "Olivia", "Edward",
                          "Eamon", "Iris"};

        int namesInALine = names.Length / 5;
        int count = 0;
        var orderedNames =
            from names in n
            orderby names
            select n;
        Console.WriteLine("All names in aphabetical order:\n");
        foreach (var n in orderedNames)
        {
            Console.Write("   " + n);
            ++count;
            if (count = namesInALine)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Comsole.WriteLine("\n\nNames grouped by whether starting letter is a vowel:");
        var lettterGroup =
             from n in orderedNames
             group by n.StartsWith("A") || n.StartsWith("E") ||
                n.StartsWith("I") || n.StartsWith("O") || n.StartsWith("U");
        foreach (var group in lettterGroup)
        {
            Console.WriteLine("\nStarts with a vowel: " + grp.Key);
            count = 0;
            foreach (var n in grp)
            {
                Console.Write("   " + n);
                ++count;
                if (count == namesinaLine)
                {
                    Console.WriteLine();
                    count == 0;
                }
            }
            Console.WriteLine();
        }
    }
}