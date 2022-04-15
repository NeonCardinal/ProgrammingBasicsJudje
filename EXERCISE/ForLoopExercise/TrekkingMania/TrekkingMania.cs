using System;

public class TrekkingMania
{
    static void Main()
    {
        int groupsCounter = int.Parse(Console.ReadLine());

        int firstGroupCnt = 0;
        int secondGroupCnt = 0;
        int thirdGroupCnt = 0;
        int fourthGroupCnt = 0;
        int fifthGroupCnt = 0;
        int totalPeople = 0;

        for(int i = 0; i < groupsCounter; i++)
        {
            int peopleCounter = int.Parse(Console.ReadLine());

            totalPeople += peopleCounter;

            if(peopleCounter <= 5)
            {
                firstGroupCnt += peopleCounter;
            }
            else if(peopleCounter >= 6 && peopleCounter <= 12)
            {
                secondGroupCnt += peopleCounter;
            }
            else if(peopleCounter >= 13 && peopleCounter <= 25)
            {
                thirdGroupCnt += peopleCounter;
            }
            else if(peopleCounter >= 26 && peopleCounter <= 40)
            {
                fourthGroupCnt += peopleCounter;
            }
            else if(peopleCounter >= 41)
            {
                fifthGroupCnt += peopleCounter;
            }
        }

        double musalaPercent = firstGroupCnt * 1.0 / totalPeople * 100;
        double monblanPercent = secondGroupCnt * 1.0 / totalPeople * 100;
        double kilimanPercent = thirdGroupCnt * 1.0 / totalPeople * 100;
        double kTwoPercent = fourthGroupCnt * 1.0 / totalPeople * 100;
        double everestPercent = fifthGroupCnt * 1.0 / totalPeople * 100;

        Console.WriteLine($"{musalaPercent:F2}%");
        Console.WriteLine($"{monblanPercent:F2}%");
        Console.WriteLine($"{kilimanPercent:F2}%");
        Console.WriteLine($"{kTwoPercent:F2}%");
        Console.WriteLine($"{everestPercent:F2}%");
    }
}