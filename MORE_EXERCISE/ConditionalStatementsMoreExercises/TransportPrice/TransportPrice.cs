using System;

public class TransportPrice
{
    static void Main()
    {
        int kilometers = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();
        double price = 0.0;

        if(kilometers < 20)
        {
            if(time == "day")
            {
                price = kilometers * 0.79 + 0.70;
            }
            else
            {
                price = kilometers * 0.90 + 0.70;
            }
        }
        else if(kilometers >= 20 && kilometers < 100)
        {
            price = kilometers * 0.09;
        }
        else if(kilometers >= 100)
        {
            price = kilometers * 0.06;
        }

        Console.WriteLine($"{price:F2}");
    }
}