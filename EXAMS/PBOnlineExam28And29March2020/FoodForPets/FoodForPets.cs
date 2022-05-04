using System;

public class FoodForPets
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double food = double.Parse(Console.ReadLine());

        int totalDogsFood = 0;
        int totalCatsFood = 0;
        int totalFood = 0;
        int totalBisquits = 0;

        for(int i = 1; i <= days; i++)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            int catsFood = int.Parse(Console.ReadLine());
            int totalFoodPerDay = dogsFood + catsFood;

            if(i % 3 == 0)
            {
                int bisquits = (int)Math.Round(totalFoodPerDay * 0.10);
                totalBisquits = bisquits;
            }


            totalCatsFood += catsFood;
            totalDogsFood += dogsFood;
            totalFood += totalFoodPerDay;
        }

        double eatenFoodPercent = totalFood * 100.0 / food;
        double catsFoodPercent = totalCatsFood * 100.0 / totalFood;
        double dogsFoodPercent = totalDogsFood * 100.0 / totalFood;

        Console.WriteLine($"Total eaten biscuits: {totalBisquits}gr.");
        Console.WriteLine($"{eatenFoodPercent:F2}% of the food has been eaten.");
        Console.WriteLine($"{dogsFoodPercent:F2}% eaten from the dog.");
        Console.WriteLine($"{catsFoodPercent:F2}% eaten from the cat.");
    }
}