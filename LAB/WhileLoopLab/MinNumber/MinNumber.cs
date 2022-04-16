using System;

public class MinNumber
{
    static void Main()
    {
        string input = Console.ReadLine();

        int smaller = int.MaxValue;

        while(input != "Stop")
        {
            int number = int.Parse(input);

            if(number < smaller)
            {
                smaller = number;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(smaller);
    }
}