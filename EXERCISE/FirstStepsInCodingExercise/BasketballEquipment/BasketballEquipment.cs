using System;

public class BasketballEquipment
{
    static void Main()
    {
        int pricePerYear = int.Parse(Console.ReadLine());

        double priceForShoes = pricePerYear * 0.60;
        double pricePerEquipe = priceForShoes * 0.80;
        double priceForBall = pricePerEquipe / 4;
        double priceForAcc = priceForBall / 5;

        double total = pricePerYear + priceForShoes + pricePerEquipe + priceForBall + priceForAcc;

        Console.WriteLine(total);
    }
}