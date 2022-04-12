using System;

public class NewHouse
{
    static void Main()
    {
        string flower = Console.ReadLine();
        int flowersCounter = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        double discount = 0.0;
        double add = 0.0;
        double totalSum = 0.0;

        if(flower == "Roses")
        {
            if(flowersCounter > 80)
            {
                discount = (flowersCounter * 5.00) * 0.10;
                totalSum = flowersCounter * 5.00 - discount;
            }
            else
            {
                totalSum = flowersCounter * 5.00;
            }
        }
        else if(flower == "Dahlias")
        {
            if(flowersCounter > 90)
            {
                discount = (flowersCounter * 3.80) * 0.15;
                totalSum = flowersCounter * 3.80 - discount;
            }
            else
            {
                totalSum = flowersCounter * 3.80;
            }
        }
        else if (flower == "Tulips")
        {
            if (flowersCounter > 80)
            {
                discount = (flowersCounter * 2.80) * 0.15;
                totalSum = flowersCounter * 2.80 - discount;
            }
            else
            {
                totalSum = flowersCounter * 2.80;
            }
        }
        else if (flower == "Narcissus")
        {
            if (flowersCounter < 120)
            {
                add = (flowersCounter * 3.00) * 0.15;
                totalSum = flowersCounter * 3.00 + add;
            }
            else
            {
                totalSum = flowersCounter * 3.00;
            }
        }
        else if (flower == "Gladiolus")
        {
            if (flowersCounter < 80)
            {
                add = (flowersCounter * 2.50) * 0.20;
                totalSum = flowersCounter * 2.50 + add;
            }
            else
            {
                totalSum = flowersCounter * 2.50;
            }
        }

        if(totalSum <= budget)
        {
            Console.WriteLine($"Hey, you have a great garden with {flowersCounter} {flower} and {(budget - totalSum):F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {(totalSum - budget):F2} leva more.");
        }
    }
}