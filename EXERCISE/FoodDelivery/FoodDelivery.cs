using System;

public class FoodDelivery
{
    static void Main()
    {
        int chiken = int.Parse(Console.ReadLine());
        int fish = int.Parse(Console.ReadLine());
        int vegetable = int.Parse(Console.ReadLine());

        double menuPrice = (chiken * 10.35) + (fish * 12.40) + (vegetable * 8.15);
        double desertPrice = menuPrice * 0.20;
        double total = menuPrice + desertPrice + 2.50;

        Console.WriteLine(total);
    }
}