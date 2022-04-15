using System;

public class TennisRanklist
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int score = int.Parse(Console.ReadLine());

        int addedScore = 0;
        int wins = 0;

        for(int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();

            if(str == "W")
            {
                addedScore += 2000;
                wins++;
            }
            else if(str == "F")
            {
                addedScore += 1200;
            }
            else if(str == "SF")
            {
                addedScore += 720;
            }
        }

        double averagePoints = addedScore * 1.0 / n;
        double winsPercent = wins * 1.0 / n * 100;
        double finalPoints = score + addedScore;

        Console.WriteLine($"Final points: {finalPoints}");
        Console.WriteLine($"Average points: {(Math.Floor(averagePoints))}");
        Console.WriteLine($"{winsPercent:F2}%");
    }
}