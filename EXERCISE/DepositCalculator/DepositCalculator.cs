using System;

public class DepositCalculator
{
    static void Main()
    {
        double deposit = double.Parse(Console.ReadLine());
        int months = int.Parse(Console.ReadLine());
        double increase = double.Parse(Console.ReadLine());

        double total = deposit + months * ((deposit * (increase / 100)) / 12);

        Console.WriteLine(total);
    }
}