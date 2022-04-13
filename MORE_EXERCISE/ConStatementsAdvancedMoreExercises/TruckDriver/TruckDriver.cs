using System;

public class TruckDriver
{
    static void Main()
    {
        string season = Console.ReadLine();
        double kilometers = double.Parse(Console.ReadLine());

        double income = 0.0;

        if(kilometers <= 5000)
        {
            if(season == "Spring" || season == "Autumn")
            {
                income = (kilometers * 4) * 0.75;
            }
            else if(season == "Summer")
            {
                income = (kilometers * 4) * 0.90;
            }
            else if(season == "Winter")
            {
                income = (kilometers * 4) * 1.05;
            }
        }
        else if(kilometers > 5000 && kilometers <= 10000)
        {
            if(season == "Spring" || season == "Autumn")
            {
                income = (kilometers * 4) * 0.95;
            }
            else if(season == "Summer")
            {
                income = (kilometers * 4) * 1.10;
            }
            else if(season == "Winter")
            {
                income = (kilometers * 4) * 1.25;
            }
        }
        else if(kilometers > 10000 && kilometers <= 20000)
        {
            income = (kilometers * 4) * 1.45;
        }

        income *= 0.90;

        Console.WriteLine($"{income:F2}");
    }
}