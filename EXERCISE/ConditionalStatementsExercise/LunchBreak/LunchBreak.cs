using System;

public class LunchBreak
{
    static void Main()
    {
        string serialName = Console.ReadLine();
        int serialLen = int.Parse(Console.ReadLine());
        int lunchLen = int.Parse(Console.ReadLine());

        double lunchTime = lunchLen * 1 / 8.0;
        double breakLen = lunchLen * 1 / 4.0;
        double freeTime = lunchLen - lunchTime - breakLen;

        if(freeTime >= serialLen)
        {
            Console.WriteLine($"You have enough time to watch {serialName} and left with {(int)Math.Ceiling((freeTime - serialLen))} minutes free time.");
        }
        else
        {
            Console.WriteLine($"You don't have enough time to watch {serialName}, you need {(int)Math.Ceiling((serialLen - freeTime))} more minutes.");
        }
    }
}