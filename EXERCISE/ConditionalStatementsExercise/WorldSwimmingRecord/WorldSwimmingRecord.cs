using System;

public class WorldSwimmingRecord
{
    static void Main()
    {
        decimal record = decimal.Parse(Console.ReadLine());
        decimal destination = decimal.Parse(Console.ReadLine());
        decimal timePerMeter = decimal.Parse(Console.ReadLine());

        decimal time = destination * timePerMeter;
        decimal addedSeconds = Math.Floor((destination / 15)) * 12.5m;
        decimal totalTime = time + addedSeconds;

        if(totalTime < record)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
        }
        else
        {
            Console.WriteLine($"No, he failed! He was {(totalTime - record):F2} seconds slower.");
        }
    }
}