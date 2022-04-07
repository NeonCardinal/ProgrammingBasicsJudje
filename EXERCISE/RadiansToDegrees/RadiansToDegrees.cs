using System;

public class RadiansToDegrees
{
    static void Main()
    {
        double radians = double.Parse(Console.ReadLine());

        double deg = radians * 180 / Math.PI;

        Console.WriteLine(deg);
    }
}