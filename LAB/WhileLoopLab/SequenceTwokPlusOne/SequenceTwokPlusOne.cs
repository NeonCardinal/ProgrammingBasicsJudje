using System;

public class SequenceTwokPlusOne
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int k = 1;

        while(k <= n)
        {
            Console.WriteLine(k);
            k = k * 2 + 1;
        }
    }
}