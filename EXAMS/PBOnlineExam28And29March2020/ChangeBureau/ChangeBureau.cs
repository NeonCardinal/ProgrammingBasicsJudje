using System;

public class ChangeBureau
{
    static void Main()
    {
        int bitcoins = int.Parse(Console.ReadLine());
        double yoans = double.Parse(Console.ReadLine());
        double commision = double.Parse(Console.ReadLine());

        double leveFromBitcoins = bitcoins * 1168;
        double dollars = yoans * 0.15;
        double leva = leveFromBitcoins + (dollars * 1.76);
        double euros = leva / 1.95;
        double comm = euros * (commision / 100);
        euros -= comm;

        Console.WriteLine($"{euros:F2}");
    }
}