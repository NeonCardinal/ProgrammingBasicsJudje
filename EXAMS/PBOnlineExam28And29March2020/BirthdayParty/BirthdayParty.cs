using System;

public class BirthdayParty
{
    static void Main()
    {
        double rent = double.Parse(Console.ReadLine());

        double cakePrice = rent * 0.20;
        double drinksPrice = cakePrice - (cakePrice * 0.45);
        double animatorPrice = rent * 1 / 3;
        double total = rent + cakePrice + drinksPrice + animatorPrice;

        Console.WriteLine(total);
    }
}