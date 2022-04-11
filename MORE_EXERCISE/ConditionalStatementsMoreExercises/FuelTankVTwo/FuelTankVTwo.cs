using System;

public class FuelTankVTwo
{
    static void Main()
    {
        string fuelType = Console.ReadLine().ToLower();
        double litters = double.Parse(Console.ReadLine());
        string card = Console.ReadLine().ToLower();

        double price = 0.0;

        if(card == "yes")
        {
            if(fuelType == "gasoline")
            {
                price = litters * (2.22 - 0.18); 
            }
            else if(fuelType == "diesel")
            {
                price = litters * (2.33 - 0.12);
            }
            else if(fuelType == "gas")
            {
                price = litters * (0.93 - 0.08);
            }
        }
        else
        {
            if (fuelType == "gasoline")
            {
                price = litters * 2.22;
            }
            else if (fuelType == "diesel")
            {
                price = litters * 2.33;
            }
            else if (fuelType == "gas")
            {
                price = litters * 0.93;
            }
        }

        if(litters >= 20 && litters <= 25)
        {
            double discount = price * 0.08;
            price -= discount;
        }
        else if(litters > 25)
        {
            double discount = price * 0.10;
            price -= discount;
        }

        Console.WriteLine($"{price:F2} lv.");
    }
}