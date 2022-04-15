using System;

public class Bills
{
    static void Main()
    {
        int months = int.Parse(Console.ReadLine());

        double electricity = 0.0;
        double water = 0.0;
        double internet = 0.0;
        double others = 0.0;
        double average = 0.0;

        for(int i = 0; i < months; i++)
        {
            double elect = double.Parse(Console.ReadLine());

            electricity += elect;
            water += 20;
            internet += 15;
            double percent = (elect + 20 + 15) * 0.20;
            others += elect + 20 + 15 + percent;
        }

        average = (electricity + water + internet + others) / months;

        Console.WriteLine($"Electricity: {electricity:F2} lv");
        Console.WriteLine($"Water: {water:F2} lv");
        Console.WriteLine($"Internet: {internet:F2} lv");
        Console.WriteLine($"Other: {others:F2} lv");
        Console.WriteLine($"Average: {average:F2} lv");
    }
}