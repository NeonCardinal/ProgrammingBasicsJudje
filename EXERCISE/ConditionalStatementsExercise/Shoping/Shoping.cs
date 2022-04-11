using System;

public class Shoping
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int vgaCounter = int.Parse(Console.ReadLine());
        int cpuCounter = int.Parse(Console.ReadLine());
        int ramCounter = int.Parse(Console.ReadLine());

        double vgaCosts = vgaCounter * 250;
        double cpuPrice = vgaCosts * 0.35;
        double ramPrice = vgaCosts * 0.10;
        double cpuCosts = cpuPrice * cpuCounter;
        double ramCosts = ramPrice * ramCounter;
        double totalCosts = vgaCosts + cpuCosts + ramCosts;
        double discount = 0.0;

        if(vgaCounter > cpuCounter)
        {
            discount = totalCosts * 0.15;
            totalCosts -= discount;
        }

        if(totalCosts <= budget)
        {
            Console.WriteLine($"You have {(budget - totalCosts):F2} leva left!");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {(totalCosts - budget):F2} leva more!");
        }
    }
}