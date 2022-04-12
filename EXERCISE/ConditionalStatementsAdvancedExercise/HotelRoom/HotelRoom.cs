using System;

public class HotelRoom
{
    static void Main()
    {
        string month = Console.ReadLine().ToLower();
        int days = int.Parse(Console.ReadLine());

        double studioResult = 0.0;
        double apartamentResult = 0.0;
        double discount = 0.0;

        if (month == "may" || month == "october")
        {
            if (days >= 7 && days < 14)
            {
                discount = (days * 50.00) * 0.05;
                studioResult = days * 50 - discount;
                apartamentResult = days * 65.00;
            }
            else if (days > 14)
            {
                discount = (days * 50.00) * 0.30;
                studioResult = days * 50 - discount;
                discount = (days * 65.00) * 0.10;
                apartamentResult = days * 65 - discount;
            }
            else
            {
                studioResult = days * 50;
                apartamentResult = days * 65.00;
            }
        }
        else if (month == "june" || month == "september")
        {
            if (days >= 7 && days < 14)
            {
                //discount = (days * 75.20) * 0.05;
                studioResult = days * 75.20 - discount;
                apartamentResult = days * 68.70;
            }
            else if (days > 14)
            {
                discount = (days * 75.20) * 0.20;
                studioResult = days * 75.20 - discount;
                discount = (days * 68.70) * 0.10;
                apartamentResult = days * 68.70 - discount;
            }
            else
            {
                studioResult = days * 75.20;
                apartamentResult = days * 68.70;
            }
        }
        else if (month == "july" || month == "august")
        {
            if (days > 14)
            {
                discount = (days * 77.00) * 0.10;
                apartamentResult = days * 77.00 - discount;
            }
            else
            {
                apartamentResult = days * 77.00;
            }
            studioResult = days * 76.00;
        }

        Console.WriteLine($"Apartment: {apartamentResult:F2} lv.");
        Console.WriteLine($"Studio: {studioResult:F2} lv.");
    }
}