using System;

public class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int currentNumber = 1;
        bool isBigger = false;

        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if(currentNumber > n)
                {
                    break;
                }

                Console.Write($"{currentNumber} ");
                currentNumber++;
            }

            if(isBigger)
            {
                break;
            }

            Console.WriteLine();
        }
    }
}