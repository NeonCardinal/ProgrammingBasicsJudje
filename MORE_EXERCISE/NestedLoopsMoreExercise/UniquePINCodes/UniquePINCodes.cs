using System;

public class UniquePINCodes
{
    static void Main()
    {
        int firstDigitMax = int.Parse(Console.ReadLine());
        int secondDigitMax = int.Parse(Console.ReadLine());
        int thirdDigitMax = int.Parse(Console.ReadLine());

        for(int i = 1; i <= firstDigitMax; i++)
        {
            for(int j = 1; j <= secondDigitMax; j++)
            {
                for(int k = 1; k <= thirdDigitMax; k++)
                {
                    if(i % 2 == 0 && (j == 2 || j == 3 || j == 5 ||
                        j == 7) && k % 2 == 0)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
}