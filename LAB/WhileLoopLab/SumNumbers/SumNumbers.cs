﻿using System;

public class SumNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        while(number > sum)
        {
            int n = int.Parse(Console.ReadLine());

            sum += n;
        }

        Console.WriteLine(sum);
    }
}