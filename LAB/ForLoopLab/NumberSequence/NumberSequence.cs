using System;

public class NumberSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int greater = int.MinValue;
        int smaller = int.MaxValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > greater)
            {
                greater = number;
            }
            if(number < smaller)
            {
                smaller = number;
            }
        }

        Console.WriteLine($"Max number: {greater}");
        Console.WriteLine($"Min number: {smaller}");
    }
}