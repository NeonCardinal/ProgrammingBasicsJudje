using System;

public class BackToThePast
{
    static void Main()
    {
        double legacy = double.Parse(Console.ReadLine());
        int ages = int.Parse(Console.ReadLine());

        int livedAges = 0;
        double neededMoney = 0.0;

        for(int i = 1800; i <= ages; i++)
        {
            if(i % 2 == 0)
            {
                neededMoney += 12000;
            }
            else
            {
                neededMoney += 12000 + 50 * (18 + livedAges);
            }

            livedAges++;
        }

        if(neededMoney <= legacy)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {(legacy - neededMoney):F2} dollars left.");
        }
        else
        {
            Console.WriteLine($"He will need {(neededMoney - legacy):F2} dollars to survive.");
        }
    }
}