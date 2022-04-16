using System;

public class Vacation
{
    static void Main()
    {
        double neededMoney = double.Parse(Console.ReadLine());
        double availableMoney = double.Parse(Console.ReadLine());

        int daysCnt = 0;
        int totalDays = 0;
        double savedMoney = 0.0;

        while(true)
        {
            string command = Console.ReadLine();
            double spendOrSaveMoney = double.Parse(Console.ReadLine());

            totalDays++;

            if (command == "spend")
            {
                daysCnt++;
                if(spendOrSaveMoney > availableMoney)
                {
                    availableMoney -= availableMoney;
                }
                else
                {
                    availableMoney -= spendOrSaveMoney;
                }
            }
            else if(command == "save")
            {
                if (availableMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {totalDays} days.");
                    return;
                }
                daysCnt--;
                availableMoney += spendOrSaveMoney;
            }

            if(daysCnt == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{totalDays}");
                break;
            }
            if(availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
                break;
            }
        }
    }
}