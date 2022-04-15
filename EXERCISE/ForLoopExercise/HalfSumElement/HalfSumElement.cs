using System;

public class HalfSumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int greater = int.MinValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            sum += number;

            if(number > greater)
            {
                greater = number;
            }
        }

        if((sum - greater) == greater)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {greater}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(greater - (sum - greater))}");
        }
    }
}