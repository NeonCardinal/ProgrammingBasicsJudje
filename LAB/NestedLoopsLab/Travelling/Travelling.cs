using System;

public class Travelling
{
    static void Main()
    {
        while(true)
        {
            string destination = Console.ReadLine();

            if(destination == "End")
            {
                break;
            }

            double vacantionPrice = double.Parse(Console.ReadLine());

            double sum = 0;

            while(true)
            {
                double save = double.Parse(Console.ReadLine());

                sum += save;

                if(sum >= vacantionPrice)
                {
                    Console.WriteLine($"Going to {destination}!");
                    break;
                }
            }
        }
    }
}