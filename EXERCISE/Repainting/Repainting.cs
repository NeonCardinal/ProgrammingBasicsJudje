using System;

public class Repainting
{
    static void Main()
    {
        int nylon = int.Parse(Console.ReadLine());
        int dye = int.Parse(Console.ReadLine());
        int litters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());

        nylon += 2;
        double extraDye = dye + (dye * 0.10);
        double priceForDye = extraDye * 14.50;
        double priceForNylon = nylon * 1.50;
        double priceForLitters = litters * 5.00;
        double totalPrice = priceForDye + priceForLitters + priceForNylon + 0.40;
        double priceForWork = (totalPrice * 0.30) * hours;
        double total = totalPrice + priceForWork;

        Console.WriteLine(total);
    }
}