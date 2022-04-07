using System;

public class VegetableMarket
{
    static void Main()
    {
        double priceForVegetables = double.Parse(Console.ReadLine());
        double priceForFruids = double.Parse(Console.ReadLine());
        int vegetablesKillos = int.Parse(Console.ReadLine());
        int fruidsKillos = int.Parse(Console.ReadLine());

        double sum = priceForVegetables * vegetablesKillos + priceForFruids * fruidsKillos;
        double sumInEuro = sum / 1.94;

        Console.WriteLine($"{sumInEuro:F2}");
    }
}