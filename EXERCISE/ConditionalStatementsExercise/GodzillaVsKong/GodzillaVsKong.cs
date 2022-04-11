using System;

public class GodzillaVsKong
{
    static void Main()
    {
        double movieBudget = double.Parse(Console.ReadLine());
        int players = int.Parse(Console.ReadLine());
        double clothesPerPlayer = double.Parse(Console.ReadLine());

        double dekorPrice = movieBudget * 0.10;
        double clothesPrice = players * clothesPerPlayer;
        double discount = 0.0;

        if(players > 150)
        {
            discount = clothesPrice * 0.10;
            clothesPrice -= discount;
        }

        double totalCost = dekorPrice + clothesPrice;

        if(totalCost <= movieBudget)
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {(movieBudget - totalCost):F2} leva left.");
        }
        else
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {(totalCost - movieBudget):F2} leva more.");
        }
    }
}