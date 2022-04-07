using System;

public class CircleAreaAndPerimeter
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * r * r;
        double circlePeremeter = 2 * Math.PI * r;

        Console.WriteLine($"{circleArea:F2}");
        Console.WriteLine($"{circlePeremeter:F2}");
    }
}