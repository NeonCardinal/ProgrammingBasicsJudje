using System;

public class ExamPreparation
{
    static void Main()
    {
        int failedTask = int.Parse(Console.ReadLine());

        int failedTaskCnt = 0;
        int problemsCnt = 0;
        double sum = 0.0;
        bool isFailed = true;
        string lastProblem = string.Empty;

        while(failedTaskCnt < failedTask)
        {
            string problem = Console.ReadLine();

            if(problem == "Enough")
            {
                isFailed = false;
                break;
            }

            int grade = int.Parse(Console.ReadLine());

            if(grade <= 4)
            {
                failedTaskCnt++;
            }

            sum += grade;
            problemsCnt++;
            lastProblem = problem;
        }

        if(isFailed)
        {
            Console.WriteLine($"You need a break, {failedTask} poor grades.");
        }
        else
        {
            Console.WriteLine($"Average score: {(sum / problemsCnt):F2}");
            Console.WriteLine($"Number of problems: {problemsCnt}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}