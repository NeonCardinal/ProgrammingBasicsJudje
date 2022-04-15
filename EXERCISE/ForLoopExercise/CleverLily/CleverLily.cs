using System;

public class CleverLily
{
    static void Main()
    {
        int lilysAge = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());

        int toysCounter = 0;
        int sum = 0;
        int money = 0;

        for(int i = 1; i <= lilysAge; i++)
        {
            if(i % 2 == 0)
            {
                sum += 10;
                money += sum;
            }
            else
            {
                toysCounter++;
            }
        }

        money = money - (lilysAge / 2);
        double incomeFromToys = toysCounter * toyPrice;
        double availableMoney = money + incomeFromToys;

        if(availableMoney >= washingMachinePrice)
        {
            Console.WriteLine($"Yes! {(availableMoney - washingMachinePrice):F2}");
        }
        else
        {
            Console.WriteLine($"No! {(washingMachinePrice - availableMoney):F2}");
        }
    }
}