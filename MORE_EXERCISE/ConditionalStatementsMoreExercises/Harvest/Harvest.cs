using System;

public class Harvest
{
    static void Main()
    {
        int vineYardArea = int.Parse(Console.ReadLine());
        double grapesPerSquare = double.Parse(Console.ReadLine());
        int neededVine = int.Parse(Console.ReadLine());
        int workersCount = int.Parse(Console.ReadLine());

        double totalGrapes = vineYardArea * grapesPerSquare;
        double grapesForVine = totalGrapes * 0.40;
        double littersVine = (grapesForVine / 2.5);

        if(littersVine >= neededVine)
        {
            double leftVine = littersVine - neededVine;
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(littersVine)} liters.");
            Console.WriteLine($"{Math.Ceiling(leftVine)} liters left -> {Math.Ceiling(leftVine / workersCount)} liters per person.");
        }
        else
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededVine - littersVine)} liters wine needed.");
        }
    }
}