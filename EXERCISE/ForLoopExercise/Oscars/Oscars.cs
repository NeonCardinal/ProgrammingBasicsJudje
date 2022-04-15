using System;

public class Oscars
{
    static void Main()
    {
        string actior = Console.ReadLine();
        double score = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        double addedPoints = 0.0;

        for(int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());

            addedPoints = name.Length * (points / 2);
            score += addedPoints;

            if(score > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actior} got a nominee for leading role with {score:F1}!");
                break;
            }
        }

        if(score < 1250.5)
        {
            Console.WriteLine($"Sorry, {actior} you need {(1250.5 - score):F1} more!");
        }
    }
}