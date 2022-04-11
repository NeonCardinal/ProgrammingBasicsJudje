using System;

public class PipesInPool
{
    static void Main()
    {
        int volume = int.Parse(Console.ReadLine());
        int pipeOne = int.Parse(Console.ReadLine());
        int pipeTwo = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double water = (pipeOne + pipeTwo) * hours;

        int volumePercent = (int)Math.Truncate(water / volume * 100);
        int pipeOnePercent = (int)(pipeOne * hours / water * 100);
        int pipeTwoPercent = (int)(pipeTwo * hours / water * 100);

        if (water <= volume)
        {
            Console.WriteLine($"The pool is {volumePercent}% full. " +
                $"Pipe 1: {pipeOnePercent}%. " +
                $"Pipe 2: {pipeTwoPercent}%.");
        }
        else
        {
            Console.WriteLine($"For {hours} hours the pool overflows with {(water - volume)} liters.");
        }
    }
}