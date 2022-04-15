using System;

public class Logistics
{
    static void Main()
    {
        int tons = int.Parse(Console.ReadLine());

        int sumOfTons = 0;
        double sum = 0.0;
        double bus = 0.0;
        double truck = 0.0;
        double train = 0.0;

        for (int i = 0; i < tons; i++)
        {
            int ton = int.Parse(Console.ReadLine());

            sumOfTons += ton;

            if (ton <= 3)
            {
                bus += ton;
            }
            else if (ton > 3 && ton <= 11)
            {
                truck += ton;
            }
            else if (ton > 11)
            {
                train += ton;
            }
        }

        sum = ((bus * 200) + (truck * 175) + (train * 120)) / sumOfTons;
        double busPercent = bus / sumOfTons * 100;
        double truckPercent = truck / sumOfTons * 100;
        double trainPercent = train / sumOfTons * 100;

        Console.WriteLine($"{sum:F2}");
        Console.WriteLine($"{busPercent:F2}%");
        Console.WriteLine($"{truckPercent:F2}%");
        Console.WriteLine($"{trainPercent:F2}%");
    }
}