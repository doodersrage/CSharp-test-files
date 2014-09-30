using System;

public class DemoVariables3
{
	public static void Main()
	{
        int value = 4;
        bool isSixMore = 6 > value;
        Console.WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);
        value = 35;
        isSixMore = 6 > value;
        Console.WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);
	}
}
