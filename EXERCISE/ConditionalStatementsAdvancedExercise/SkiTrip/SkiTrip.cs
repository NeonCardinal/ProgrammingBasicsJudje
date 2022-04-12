using System;

public class SkiTrip
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        string place = Console.ReadLine();
        string feedBack = Console.ReadLine();

        double discount = 0.0;
        double extra = 0.0;
        double expence = 0.0;
        days--;

        if(place == "room for one person")
        {
            expence = days * 18.00;
        }
        else if(place == "apartment")
        {
            expence = days * 25.00;

            if (days > 0 && days <= 10)
            {
                //expence = days * 25.00;
                expence *= 0.70;
            }
            else if(days > 10 && expence <= 15)
            {
                //expence = days * 25.00;
                expence *= 0.65;
            }
            else if(days > 15)
            {
                //expence = days * 25.00;
                expence *= 0.50;
            }
        }
        else if(place == "president apartment")
        {
            expence = days * 35.00;

            if (days > 0 && days <= 10)
            {
                //expence = days * 35.00;
                expence *= 0.90;
            }
            else if (days > 10 && days <= 15)
            {
                //expence = days * 35.00;
                expence *= 0.85;
            }
            else if (days > 15)
            {
                //expence = days * 35.00;
                expence *= 0.80;
            }
        }

        if(feedBack == "positive")
        {
            extra = expence * 0.25;
            expence += extra;
        }
        else if(feedBack == "negative")
        {
            discount = expence * 0.10;
            expence -= discount;
        }

            Console.WriteLine($"{expence:F2}");
    }
}