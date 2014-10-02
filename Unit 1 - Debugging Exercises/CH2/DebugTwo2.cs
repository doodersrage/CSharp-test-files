// This program greets the user and multiplies two entered values
using System;
public class DebugTwo2{
    public static void Main()
    {
        string name;
        string firstString, secondString;
        int first, second, product;
        Console.WriteLine("Enter your name");
        name = Console.ReadLine();
        Console.WriteLine("Hello {0}! Enter an integer", name);
        firstString = Console.ReadLine();
        first = Convert.ToInt32(firstString);
        Console.WriteLine("Enter another integer");
        secondString = Console.ReadLine();
        second = Convert.ToInt32(secondString);
        product = first * second;
        Console.WriteLine("Thank you {0}. The product of {1} and {2} is {3}", name, first, second, product);
    }
}

