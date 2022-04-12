using System;

public class TradeCommissions
{
    static void Main()
    {
        string town = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());

        double commision = -1.0;

        if (town == "sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                commision = 0.05;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commision = 0.07;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commision = 0.08;
            }
            else if (sales > 10000)
            {
                commision = 0.12;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town == "varna")
        {
            if (sales >= 0 && sales <= 500)
            {
                commision = 0.045;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commision = 0.075;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commision = 0.10;
            }
            else if (sales > 10000)
            {
                commision = 0.13;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (town == "plovdiv")
        {
            if (sales >= 0 && sales <= 500)
            {
                commision = 0.055;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commision = 0.08;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commision = 0.12;
            }
            else if (sales > 10000)
            {
                commision = 0.145;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }

        if (commision >= 0)
        {
            Console.WriteLine($"{(commision * sales):F2}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}