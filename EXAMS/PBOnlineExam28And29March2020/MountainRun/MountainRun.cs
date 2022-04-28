using System;

public class MountainRun
{
    static void Main()
    {
        decimal recordInSeconds = decimal.Parse(Console.ReadLine());
        decimal distance = decimal.Parse(Console.ReadLine());
        decimal secondsPerMeter = decimal.Parse(Console.ReadLine());

        decimal secondsPerDistance = distance * secondsPerMeter;
        decimal addSeconds = Math.Floor((distance / 50)) * 30;
        decimal totalSeconds = secondsPerDistance + addSeconds;

        if(totalSeconds < recordInSeconds)
        {
            Console.WriteLine($"Yes! The new record is {totalSeconds:F2} seconds.");
        }
        else
        {
            Console.WriteLine($"No! He was {Math.Abs(totalSeconds - recordInSeconds):F2} seconds slower.");
        }
    }
}