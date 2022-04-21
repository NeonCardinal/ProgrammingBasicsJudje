using System;

public class SumOfTwoNumbers
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int counter = 0;
        int first = 0;
        int second = 0;
        bool isFound = false;

        for(int i = start; i <= end; i++)
        {
            for(int j = start; j <= end; j++)
            {
                counter++;

                if(i + j == magicNumber)
                {
                    isFound = true;
                    first = i;
                    second = j;
                    break;
                }
            }

            if(isFound)
            {
                break;
            }
        }

        if(isFound)
        {
            Console.WriteLine($"Combination N:{counter} ({first} + {second} = {magicNumber})");
        }
        else
        {
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}