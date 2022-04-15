using System;

public class Grades
{
    static void Main()
    {
        int studentsCounter = int.Parse(Console.ReadLine());

        int exellentCnt = 0;
        int veryGoodCnt = 0;
        int goodCnt = 0;
        int failCnt = 0;
        double averageGrade = 0.0;

        for(int i = 0; i < studentsCounter; i++)
        {
            double grade = double.Parse(Console.ReadLine());

            if(grade < 3.00)
            {
                failCnt++;
            }
            else if(grade >= 3.00 && grade <= 3.99)
            {
                goodCnt++;
            }
            else if(grade >= 4.00 && grade <= 4.99)
            {
                veryGoodCnt++;
            }
            else if(grade >= 5.00)
            {
                exellentCnt++;
            }

            averageGrade += grade;
        }

        averageGrade /= studentsCounter;
        double failPercent = failCnt * 1.0 / studentsCounter * 100;
        double goodPercent = goodCnt * 1.0 / studentsCounter * 100;
        double veryGoodPercent = veryGoodCnt * 1.0 / studentsCounter * 100;
        double exellentPercent = exellentCnt * 1.0 / studentsCounter * 100;

        Console.WriteLine($"Top students: {exellentPercent:F2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {veryGoodPercent:F2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {goodPercent:F2}%");
        Console.WriteLine($"Fail: {failPercent:F2}%");
        Console.WriteLine($"Average: {averageGrade:F2}");
    }
}