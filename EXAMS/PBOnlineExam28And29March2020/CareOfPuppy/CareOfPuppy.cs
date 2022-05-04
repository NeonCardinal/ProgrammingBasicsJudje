using System;

public class CareOfPuppy
{
    static void Main()
    {
        int food = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        int availableFoodInGrams = food * 1000;
        int eatenFood = 0;

        while(true)
        {
            if(command == "Adopted")
            {
                break;
            }

            int foodPerDay = int.Parse(command);
            eatenFood += foodPerDay;

            command = Console.ReadLine();
        }

        if(eatenFood <= availableFoodInGrams)
        {
            Console.WriteLine($"Food is enough! Leftovers: {availableFoodInGrams - eatenFood} grams.");
        }
        else
        {
            Console.WriteLine($"Food is not enough. You need {eatenFood - availableFoodInGrams} grams more.");
        }
    }
}