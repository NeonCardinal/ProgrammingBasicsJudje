using System;

public class SuppliesForSchool
{
    static void Main()
    {
        int pensCount = int.Parse(Console.ReadLine());
        int markersCount = int.Parse(Console.ReadLine());
        int litters = int.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        double priceForPens = pensCount * 5.80;
        double priceForMarkers = markersCount * 7.20;
        double priceForLitters = litters * 1.20;
        double neededMoney = priceForLitters + priceForMarkers + priceForPens;
        double percentDiscount = neededMoney * (discount / 100.0);
        double total = neededMoney - percentDiscount;

        Console.WriteLine(total);
    }
}