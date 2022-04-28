using System;

public class CatWalking
{
    static void Main()
    {
        int minutes = int.Parse(Console.ReadLine());
        int walkCounter = int.Parse(Console.ReadLine());
        int calories = int.Parse(Console.ReadLine());

        int minutesPerDay = minutes * walkCounter;
        int burnedCalories = minutesPerDay * 5;
        int needCaloriesToBurn = (int)(calories * 0.50);

        if(burnedCalories >= needCaloriesToBurn)
        {
            Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
        }
        else
        {
            Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
        }
    }
}