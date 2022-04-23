using System;

public class CarNumber
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for(int i = start; i <= end; i++)
        {
            for(int j = start; j <= end; j++)
            {
                for(int k = start; k <= end; k++)
                {
                    for(int p = start; p <= end; p++)
                    {
                        bool isFirstGreater = i > p;
                        bool isEven = i % 2 == 0;
                        bool isSumIsEven = (j + k) % 2 == 0;
                        bool lastDigit = p % 2 == 0;
                        
                        if(isEven)
                        {
                            if(isFirstGreater && isSumIsEven && lastDigit == false)
                            {
                                Console.Write($"{i}{j}{k}{p} ");
                            }
                        }
                        else
                        {
                            if (isFirstGreater && isSumIsEven && lastDigit)
                            {
                                Console.Write($"{i}{j}{k}{p} ");
                            }
                        }
                    }
                }
            }
        }
    }
}