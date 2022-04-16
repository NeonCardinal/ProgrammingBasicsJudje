using System;

public class AccountBalance
{
    static void Main()
    {
        string input = Console.ReadLine();

        double totalSum = 0.0;

        while(input != "NoMoreMoney")
        {
            double sum = double.Parse(input);

            if(sum <= 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }

            Console.WriteLine($"Increase: {sum:F2}");
            totalSum += sum;

            input = Console.ReadLine();
        }

        Console.WriteLine($"Total: {totalSum:F2}");
    }
}