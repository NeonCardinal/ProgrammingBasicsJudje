using System;

public class Journey
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        if(budget <= 100)
        {
            if(season == "summer")
            {
                Console.WriteLine($"Somewhere in Bulgaria");
                Console.WriteLine($"Camp - {(budget *= 0.30):F2}");
            }
            else if(season == "winter")
            {
                Console.WriteLine($"Somewhere in Bulgaria");
                Console.WriteLine($"Hotel - {(budget *= 0.70):F2}");
            }
        }
        else if(budget > 100 && budget <= 1000)
        {
            if (season == "summer")
            {
                Console.WriteLine($"Somewhere in Balkans");
                Console.WriteLine($"Camp - {(budget *= 0.40):F2}");
            }
            else if (season == "winter")
            {
                Console.WriteLine($"Somewhere in Balkans");
                Console.WriteLine($"Hotel - {(budget *= 0.80):F2}");
            }
        }
        else if(budget > 1000)
        {
            Console.WriteLine($"Somewhere in Europe");
            Console.WriteLine($"Hotel - {(budget *= 0.90):F2}");
        }
    }
}