using System;

public class MatchTickets
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int peopleCounter = int.Parse(Console.ReadLine());

        double transportPrice = 0.0;
        double ticketPrice = 0.0;

        if(peopleCounter >= 1 && peopleCounter <= 4)
        {
            transportPrice = budget * 0.75;
        }
        else if(peopleCounter >=5 && peopleCounter <= 9)
        {
            transportPrice = budget * 0.60;
        }
        else if(peopleCounter >= 10 && peopleCounter <= 24)
        {
            transportPrice = budget * 0.50;
        }
        else if(peopleCounter >= 25 && peopleCounter <= 49)
        {
            transportPrice = budget * 0.40;
        }
        else if(peopleCounter >= 50)
        {
            transportPrice = budget * 0.25;
        }

        if(category == "Normal")
        {
            ticketPrice = 249.99;
        }
        else if(category == "VIP")
        {
            ticketPrice = 499.99;
        }

        double expenses = transportPrice + (peopleCounter * ticketPrice);

        if(expenses <= budget)
        {
            Console.WriteLine($"Yes! You have {(budget - expenses):F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {(expenses - budget):F} leva.");
        }
    }
}