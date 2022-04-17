using System;

public class ReportSystem
{
    static void Main()
    {
        int neededMoney = int.Parse(Console.ReadLine());

        int cnt = 0;
        int cashCnt = 0;
        int cardCnt = 0;
        double cashSum = 0;
        double cardSum = 0;
        double totalSum = 0.0;

        while(true)
        {
            cnt++;
            string command = Console.ReadLine();

            if(command == "End")
            {
                break;
            }

            int money = int.Parse(command);

            if(cnt % 2 != 0)
            {
                if(money > 100)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    cashSum += money;
                    cashCnt++;
                    totalSum += money;
                    Console.WriteLine("Product sold!");
                }
            }
            else
            {
                if(money < 10)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    cardSum += money;
                    cardCnt++;
                    totalSum += money;
                    Console.WriteLine("Product sold!");
                }
            }

            if(totalSum >= neededMoney)
            {
                break;
            }
        }

        if(totalSum >= neededMoney)
        {
            Console.WriteLine($"Average CS: {(cashSum / cashCnt):F2}");
            Console.WriteLine($"Average CC: {(cardSum / cardCnt):F2}");
        }
        else
        {
            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}