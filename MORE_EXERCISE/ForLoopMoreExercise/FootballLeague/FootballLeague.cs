using System;

public class FootballLeague
{
    static void Main()
    {
        int stadiumCapacity = int.Parse(Console.ReadLine());
        int fensCounter = int.Parse(Console.ReadLine());

        int aCnt = 0;
        int bCnt = 0;
        int vCnt = 0;
        int gCnt = 0;

        for(int i = 0; i < fensCounter; i++)
        {
            string sektor = Console.ReadLine();

            if(sektor == "A")
            {
                aCnt++;
            }
            else if(sektor == "B")
            {
                bCnt++;
            }
            else if(sektor == "V")
            {
                vCnt++;
            }
            else if(sektor == "G")
            {
                gCnt++;
            }
        }

        double aPercent = aCnt * 1.0 / fensCounter * 100;
        double bPercent = bCnt * 1.0 / fensCounter * 100;
        double vPercent = vCnt * 1.0 / fensCounter * 100;
        double gPercent = gCnt * 1.0 / fensCounter * 100;
        double allFensPercent = fensCounter * 1.0 / stadiumCapacity * 100;

        Console.WriteLine($"{aPercent:F2}%");
        Console.WriteLine($"{bPercent:F2}%");
        Console.WriteLine($"{vPercent:F2}%");
        Console.WriteLine($"{gPercent:F2}%");
        Console.WriteLine($"{allFensPercent:F2}%");
    }
}