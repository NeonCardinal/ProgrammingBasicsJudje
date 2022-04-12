using System;

public class OnTimeForTheExam
{
    static void Main()
    {
        int examHours = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        int arrivalHours = int.Parse(Console.ReadLine());
        int arrivalMinutes = int.Parse(Console.ReadLine());

        int examTime = (examHours * 60) + examMinutes;
        int arrivalTime = (arrivalHours * 60) + arrivalMinutes;

        int diffTimes = arrivalTime - examTime;

        string studentArrival = "Late";

        if (diffTimes < -30)
        {
            studentArrival = "Early";
        }
        else if (diffTimes >= -30 && diffTimes <= 0)
        {
            studentArrival = "On time";
        }

        string result = string.Empty;

        if (diffTimes != 0)
        {
            int hoursDiff = Math.Abs(diffTimes / 60);
            int minutesDiff = Math.Abs(diffTimes % 60);

            if (hoursDiff > 0)
            {
                result = string.Format("{0}:{1:00} hours", hoursDiff, minutesDiff);
            }
            else
            {
                result = minutesDiff + " minutes";
            }

            if (diffTimes < 0)
            {
                result += " before the start";
            }
            else
            {
                result += " after the start";
            }
        }

        Console.WriteLine(studentArrival);

        if (!string.IsNullOrEmpty(result))
        {
            Console.WriteLine(result);
        }
    }
}