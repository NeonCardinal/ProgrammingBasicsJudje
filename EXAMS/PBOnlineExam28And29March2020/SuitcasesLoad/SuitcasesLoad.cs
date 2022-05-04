using System;

public class SuitcasesLoad
{
    static void Main()
    {
        double volume = double.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        int caseesCounter = 0;
        double totalVolume = 0.0;

        while(true)
        {
            if(command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                break;
            }



            double caseVolume = double.Parse(command);

            if(caseesCounter % 3 == 0)
            {
                double add = caseVolume * 0.10;
                caseVolume += add;
            }

            totalVolume += caseVolume;

            if(totalVolume > volume)
            {
                Console.WriteLine($"No more space!");
                break;
            }

            caseesCounter++;
            command = Console.ReadLine();
        }

        Console.WriteLine($"Statistic: {caseesCounter} suitcases loaded.");
    }
}