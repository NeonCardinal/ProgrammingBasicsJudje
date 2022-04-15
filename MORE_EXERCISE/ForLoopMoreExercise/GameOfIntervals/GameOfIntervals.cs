using System;

public class GameOfIntervals
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int n1Cnt = 0;
        int n2Cnt = 0;
        int n3Cnt = 0;
        int n4Cnt = 0;
        int n5Cnt = 0;
        int n6Cnt = 0;
        double score = 0.0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            double points = 0;

            if(number >= 0 && number <= 9)
            {
                n1Cnt++;
                points = number * 0.20;
            }
            else if(number >= 10 && number <= 19)
            {
                n2Cnt++;
                points = number * 0.30;
            }
            else if(number >= 20 && number <= 29)
            {
                n3Cnt++;
                points = number * 0.40;
            }
            else if(number >= 30 && number <= 39)
            {
                n4Cnt++;
                points = 50;
            }
            else if(number >= 40 && number <= 50)
            {
                n5Cnt++;
                points = 100;
            }
            else if(number < 0 || number > 50)
            {
                n6Cnt++;
                score /= 2;
            }
            score += points;
        }

        double n1Percent = n1Cnt * 1.0 / n * 100;
        double n2Percent = n2Cnt * 1.0 / n * 100;
        double n3Percent = n3Cnt * 1.0 / n * 100;
        double n4Percent = n4Cnt * 1.0 / n * 100;
        double n5Percent = n5Cnt * 1.0 / n * 100;
        double n6Percent = n6Cnt * 1.0 / n * 100;

        Console.WriteLine($"{score:F2}");
        Console.WriteLine($"From 0 to 9: {n1Percent:F2}%");
        Console.WriteLine($"From 10 to 19: {n2Percent:F2}%");
        Console.WriteLine($"From 20 to 29: {n3Percent:F2}%");
        Console.WriteLine($"From 30 to 39: {n4Percent:F2}%");
        Console.WriteLine($"From 40 to 50: {n5Percent:F2}%");
        Console.WriteLine($"Invalid numbers: {n6Percent:F2}%");
    }
}