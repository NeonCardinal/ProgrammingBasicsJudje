using System;

public class Coins
{
    static void Main()
    {
        decimal sum = decimal.Parse(Console.ReadLine());

        int coins = 0;

        while(true)
        {
            if (sum >= 2)
            {
                sum -= 2.0m;
                coins++;
            }
            else if (sum >= 1 && sum < 2)
            {
                sum -= 1.0m;
                coins++;
            }
            else if (sum >= 0.50m && sum < 1)
            {
                sum -= 0.50m;
                coins++;
            }
            else if (sum >= 0.20m && sum < 0.50m)
            {
                sum -= 0.20m;
                coins++;
            }
            else if (sum >= 0.10m && sum < 0.20m)
            {
                sum -= 0.10m;
                coins++;
            }
            else if(sum >= 0.05m && sum < 0.10m)
            {
                sum -= 0.05m;
                coins++;
            }
            else if(sum >= 0.02m && sum < 0.05m)
            {
                sum -= 0.02m;
                coins++;
            }
            else if(sum >= 0.01m && sum < 0.02m)
            {
                sum -= 0.01m;
                coins++;
            }

            if(sum == 0.0m)
            {
                break;
            }
        }

        Console.WriteLine(coins);
    }
}