using System;

public class TrainingLab
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double widthInCm = w * 100;
        double heightInCm = (h * 100) - 100;

        int row = (int)(widthInCm / 120);
        int col = (int)(heightInCm / 70);
        int result = row * col - 3;

        Console.WriteLine(result);
    }
}