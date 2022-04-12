using System;

public class BikeRace
{
    static void Main()
    {
        int juniorsCounter = int.Parse(Console.ReadLine());
        int seniorsCounter = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();

        double income = 0.0;
        double discount = 0.0;

        if(type == "trail")
        {
            income = juniorsCounter * 5.50 + seniorsCounter * 7.00;
        }
        else if(type == "cross-country")
        {
            int peopleCounter = juniorsCounter + seniorsCounter;
            income = juniorsCounter * 8.00 + seniorsCounter * 9.50;

            if(peopleCounter >= 50)
            {
                discount = income * 0.25;
                income -= discount;
            }
        }
        else if(type == "downhill")
        {
            income = juniorsCounter * 12.25 + seniorsCounter * 13.75;
        }
        else if(type == "road")
        {
            income = juniorsCounter * 20.00 + seniorsCounter * 21.50;
        }

        income *= 0.95;

        Console.WriteLine($"{income:F2}");
    }
}