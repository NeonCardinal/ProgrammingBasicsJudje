using System;

public class FishingBoat
{
    static void Main()
    {
        int budged = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int fishermanCounter = int.Parse(Console.ReadLine());

        double expense = 0.0;
        double priceForShip = 0.0;

        if(season == "Spring")
        {
            priceForShip = 3000;
        }
        else if (season == "Summer")
        {
            priceForShip = 4200;
        }
        else if (season == "Autumn")
        {
            priceForShip = 4200;
        }
        else if (season == "Winter")
        {
            priceForShip = 2600;
        }

        if(fishermanCounter <= 6)
        {
            priceForShip *= 0.90;
        }
        else if(fishermanCounter >=7 && fishermanCounter <= 11)
        {
            priceForShip *= 0.85;
        }
        else if(fishermanCounter >= 12)
        {
            priceForShip *= 0.75;
        }

        if (fishermanCounter % 2 == 0 && season != "Autumn")
        {
            priceForShip *= 0.95;
        }

        expense = priceForShip;

        if (expense <= budged)
        {
            Console.WriteLine($"Yes! You have {(budged - expense):F2} leva left.");
        }
        else if(expense > budged)
        {
            Console.WriteLine($"Not enough money! You need {(expense - budged):F2} leva.");
        }
    }
}