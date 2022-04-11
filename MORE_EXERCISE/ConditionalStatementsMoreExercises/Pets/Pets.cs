using System;

public class Pets
{
    static void Main()
    {
        int holydays = int.Parse(Console.ReadLine());
        double food = double.Parse(Console.ReadLine());
        double dogFoodPerDay = double.Parse(Console.ReadLine());
        double catFoodPerday = double.Parse(Console.ReadLine());
        double turtleFoodPerDay = double.Parse(Console.ReadLine());

        double neededFood = dogFoodPerDay * holydays + catFoodPerday * holydays + ((turtleFoodPerDay * holydays) / 1000);

        if(neededFood <= food)
        {
            Console.WriteLine($"{Math.Floor(food - neededFood)} kilos of food left.");
        }
        else
        {
            Console.WriteLine($"{Math.Ceiling(neededFood - food)} more kilos of food are needed.");
        }
    }
}