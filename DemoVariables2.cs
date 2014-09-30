using System;

public class DemoVariables2
{
	public static void Main()
	{
        int value1 = 43, value2 = 10, sum, diff, product, quotient, remainder;

        sum = value1 + value2;
        diff = value1 - value2;
        product = value1 * value2;
        quotient = value1 / value2;
        remainder = value1 % value2;

        Console.WriteLine("The sum of {0} and {1} is {2}", value1, value2, sum);
        Console.WriteLine("The difference of {0} and {1} is {2}", value1, value2, diff);
        Console.WriteLine("The product of {0} and {1} is {2}", value1, value2, product);
        Console.WriteLine("The divided of {0} and {1} is {2}", value1, value2, quotient);
        Console.WriteLine("The remainder of {0} and {1} is {2}", value1, value2, remainder);
	}
}
