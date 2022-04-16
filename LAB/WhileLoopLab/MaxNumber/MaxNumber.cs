using System;

public class MaxNumber
{
    static void Main()
    {
        string input = Console.ReadLine();

        int greater = int.MinValue;

        while(input != "Stop")
        {
            int number = int.Parse(input);

            if(number > greater)
            {
                greater = number;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(greater);
    }
}