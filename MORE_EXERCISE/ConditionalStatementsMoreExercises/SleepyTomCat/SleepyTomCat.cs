using System;

public class SleepyTomCat
{
    static void Main()
    {
        int holydays = int.Parse(Console.ReadLine());

        int workingDays = 365 - holydays;
        int totalTime = workingDays * 63 + holydays * 127;
        int playTime = Math.Abs(30000 - totalTime);
        int hours = playTime / 60;
        int minutes = playTime % 60;

        if(totalTime <= 30000)
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
        }
        else
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
        }
    }
}