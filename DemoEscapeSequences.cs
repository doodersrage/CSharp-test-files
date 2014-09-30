using System;

public class DemoEscapeSequences
{
    public static void Main()
	{
        Console.WriteLine("This line\tcontains two\ttabs");
        Console.WriteLine("This statement\ncontains a new line");
        Console.WriteLine("This statement sounds " + "three alerts\a\a\a");
	}
}
