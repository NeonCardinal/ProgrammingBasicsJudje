using System;

public class TrainTheTrainers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        double averageGrade = 0.0;

        while(true)
        {
            double gradeSum = 0.0;
            string str = Console.ReadLine();

            if(str == "Finish")
            {
                break;
            }

            for(int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeSum += grade;
                counter++;
            }

            Console.WriteLine($"{str} - {(gradeSum / n):F2}.");

            averageGrade += gradeSum;
        }

        Console.WriteLine($"Student's final assessment is {(averageGrade / counter):F2}.");
    }
}