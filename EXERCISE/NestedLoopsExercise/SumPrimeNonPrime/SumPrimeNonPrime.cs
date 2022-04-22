using System;

public class SumPrimeNonPrime
{
    static void Main()
    {
        int primeSum = 0;
        int nonPrimeSum = 0;

        while(true)
        {
            string str = Console.ReadLine();

            if(str == "stop")
            {
                break;
            }

            int n = int.Parse(str);

            bool isPrime = true;

            while(n < 0)
            {
                Console.WriteLine("Number is negative.");
                str = Console.ReadLine();
                n = int.Parse(str);
            }

            if(n >= 0 && n < 2)
            {
                isPrime = false;
            }

            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if(isPrime)
            {
                primeSum += n;
            }
            else
            {
                nonPrimeSum += n;
            }
        }

        Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
    }
}