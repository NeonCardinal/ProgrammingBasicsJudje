using System;

public class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        double income = 0.0;

        if(type == "Premiere")
        {
            income = (rows * cols) * 12.00;
            Console.WriteLine($"{income:F2} leva");
        }
        else if(type == "Normal")
        {
            income = (rows * cols) * 7.50;
            Console.WriteLine($"{income:F2} leva");
        }
        else if(type == "Discount")
        {
            income = (rows * cols) * 5.00;
            Console.WriteLine($"{income:F2} leva");
        }
    }
}