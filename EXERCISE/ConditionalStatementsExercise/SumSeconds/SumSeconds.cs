using System;

public class SumSeconds
{
    static void Main()
    {
        int firstTime = int.Parse(Console.ReadLine());
        int secondTime = int.Parse(Console.ReadLine());
        int thirdTime = int.Parse(Console.ReadLine());

        int minutes = 0;
        int seconds = firstTime + secondTime + thirdTime;

        if(seconds > 59)
        {
            minutes++;
            seconds -= 60;
        }
        if(seconds > 59)
        {
            minutes++;
            seconds -= 60;
        }

        if(seconds < 10)
        {
            Console.WriteLine($"{minutes}:0{seconds}");
        }
        else
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}