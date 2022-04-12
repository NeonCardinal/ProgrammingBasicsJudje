using System;

public class Flowers
{
    static void Main()
    {
        int hrizantemiCounter = int.Parse(Console.ReadLine());
        int rosesCounter = int.Parse(Console.ReadLine());
        int laletaCounter = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string hollyday = Console.ReadLine();

        double bouquetPrice = 0.0;

        if(season == "Spring" || season == "Summer")
        {
            bouquetPrice = hrizantemiCounter * 2.00 + rosesCounter * 4.10 + laletaCounter * 2.50;
        }
        else if(season == "Autumn" || season == "Winter")
        {
            bouquetPrice = hrizantemiCounter * 3.75 + rosesCounter * 4.50 + laletaCounter * 4.15;
        }

        if(hollyday == "Y")
        {
            double add = bouquetPrice * 0.15;
            bouquetPrice += add;
        }

        if(laletaCounter > 7 && season == "Spring")
        {
            bouquetPrice *= 0.95;
        }
        if(rosesCounter >= 10 && season == "Winter")
        {
            bouquetPrice *= 0.90;
        }
        if((hrizantemiCounter + rosesCounter + laletaCounter) > 20)
        {
            bouquetPrice *= 0.80;
        }

        bouquetPrice += 2;

        Console.WriteLine($"{bouquetPrice:F2}");
    }
}