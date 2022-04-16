using System;

public class Graduation
{
    static void Main()
    {
        string name = Console.ReadLine();

        int counter = 0;
        int expCnt = 0;
        double sum = 0;

        while(counter < 12)
        {
            double grade = double.Parse(Console.ReadLine());

            if(grade < 4.00)
            {
                expCnt++;
            }
            else if(grade >= 4.00)
            {
                sum += grade;
            }

            if(expCnt > 1)
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade");
                return;
            }

            counter++;
        }

        double averaGrade = sum / 12;

        Console.WriteLine($"{name} graduated. Average grade: {averaGrade:F2}");
    }
}