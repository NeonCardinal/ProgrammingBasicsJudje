using System;

public class EnergyBooster
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string type = Console.ReadLine();
        int counts = int.Parse(Console.ReadLine());

        double price = 0.0;
        double pricePerSet = 0.0;
        double total = 0.0;

        if(fruit == "Watermelon")
        {
            if(type == "small")
            {
                pricePerSet = 2 * 56;
                price = counts * pricePerSet;
            }
            else if(type == "big")
            {
                pricePerSet = 5 * 28.70;
                price = counts * pricePerSet;
            }
        }
        else if(fruit == "Mango")
        {
            if (type == "small")
            {
                pricePerSet = 2 * 36.66;
                price = counts * pricePerSet;
            }
            else if (type == "big")
            {
                pricePerSet = 5 * 19.60;
                price = counts * pricePerSet;
            }
        }
        else if(fruit == "Pineapple")
        {
            if (type == "small")
            {
                pricePerSet = 2 * 42.10;
                price = counts * pricePerSet;
            }
            else if (type == "big")
            {
                pricePerSet = 5 * 24.80;
                price = counts * pricePerSet; 
            }
        }
        else if(fruit == "Raspberry")
        {
            if (type == "small")
            {
                pricePerSet = 2 * 20;
                price = counts * pricePerSet;
            }
            else if (type == "big")
            {
                pricePerSet = 5 * 15.20;
                price = counts * pricePerSet;
            }
        }

        if(price >= 400 && price <= 1000)
        {
            double discount = price * 0.15;
            price -= discount;
        }
        else if(price > 1000)
        {
            double discount = price * 0.50;
            price -= discount;
        }

        Console.WriteLine($"{price:F2} lv.");
    }
}