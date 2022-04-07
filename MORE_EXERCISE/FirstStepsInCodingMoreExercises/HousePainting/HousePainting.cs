using System;

public class HousePainting
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double backSideArea = x * x;
        double frontSideArea = x * x - (1.2 * 2.0);
        double wallSide = x * y - (1.5 * 1.5);
        double roofRectangleArea = x * y;
        double roofTriangle = x * h / 2;
        double wallsArea = backSideArea + frontSideArea + (2 * wallSide);
        double roofArea = 2 * (roofRectangleArea) + (2 * roofTriangle);
        double redDye = roofArea / 4.3;
        double greenDye = wallsArea / 3.4;

        Console.WriteLine($"{greenDye:F2}");
        Console.WriteLine($"{redDye:F2}");
    }
}