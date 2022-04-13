using System;

public class SchoolCamp
{
    static void Main()
    {
        string season = Console.ReadLine();
        string groupType = Console.ReadLine();
        int peopleCounter = int.Parse(Console.ReadLine());
        int nightsCounter = int.Parse(Console.ReadLine());

        string sport = string.Empty;
        double price = 0.0;

        if(season == "Spring")
        {
            if(groupType == "boys")
            {
                price = peopleCounter * 7.20 * nightsCounter;
                sport = "Tennis";
            }
            else if(groupType == "girls")
            {
                price = peopleCounter * 7.20 * nightsCounter;
                sport = "Athletics";
            }
            else if(groupType == "mixed")
            {
                price = peopleCounter * 9.50 * nightsCounter;
                sport = "Cycling";
            }
        }
        else if(season == "Summer")
        {
            if (groupType == "boys")
            {
                price = peopleCounter * 15.0 * nightsCounter;
                sport = "Football";
            }
            else if (groupType == "girls")
            {
                price = peopleCounter * 15.0 * nightsCounter;
                sport = "Volleyball";
            }
            else if (groupType == "mixed")
            {
                price = peopleCounter * 20.0 * nightsCounter;
                sport = "Swimming";
            }
        }
        else if(season == "Winter")
        {
            if (groupType == "boys")
            {
                price = peopleCounter * 9.60 * nightsCounter;
                sport = "Judo";
            }
            else if (groupType == "girls")
            {
                price = peopleCounter * 9.60 * nightsCounter;
                sport = "Gymnastics";
            }
            else if (groupType == "mixed")
            {
                price = peopleCounter * 10.0 * nightsCounter;
                sport = "Ski";
            }
        }

        if(peopleCounter >= 10 && peopleCounter < 20)
        {
            price *= 0.95;
        }
        else if(peopleCounter >= 20 && peopleCounter < 50)
        {
            price *= 0.85;
        }
        else if(peopleCounter >= 50)
        {
            price *= 0.50;
        }

        Console.WriteLine($"{sport} {price:F2} lv.");
    }
}