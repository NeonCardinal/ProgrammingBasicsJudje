using System;

public class FuelTank
{
    static void Main()
    {
        string fuelType = Console.ReadLine().ToLower();
        double litters = double.Parse(Console.ReadLine());

        if(litters < 25)
        {
            if(fuelType == "diesel")
            {
                Console.WriteLine($"Fill your tank with {fuelType}!");
            }
            else if(fuelType == "gasoline")
            {
                Console.WriteLine($"Fill your tank with {fuelType}!");
            }
            else if(fuelType == "gas")
            {
                Console.WriteLine($"Fill your tank with {fuelType}!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
        else if(litters >= 25)
        {
            if(fuelType == "diesel")
            {
                Console.WriteLine($"You have enough {fuelType}.");
            }
            else if(fuelType == "gasoline")
            {
                Console.WriteLine($"You have enough {fuelType}.");
            }
            else if(fuelType == "gas")
            {
                Console.WriteLine($"You have enough {fuelType}.");
            }
            else
            {
                Console.WriteLine($"Invalid fuel!");
            }
        }
    }
}