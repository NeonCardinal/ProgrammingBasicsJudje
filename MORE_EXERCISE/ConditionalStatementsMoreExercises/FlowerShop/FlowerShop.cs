using System;

public class FlowerShop
{
    static void Main()
    {
        int magnolii = int.Parse(Console.ReadLine());
        int zumbuli = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int kaktusi = int.Parse(Console.ReadLine());
        double giftPrice = double.Parse(Console.ReadLine());

        double totalIncome = (magnolii * 3.25) + (zumbuli * 4.00) + (roses * 3.50) + (kaktusi * 8.00);
        double vat = totalIncome * 0.05;
        totalIncome -= vat;

        if(totalIncome >= giftPrice)
        {
            Console.WriteLine($"She is left with {Math.Floor(totalIncome - giftPrice)} leva.");
        }
        else
        {
            Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalIncome)} leva.");
        }
    }
}