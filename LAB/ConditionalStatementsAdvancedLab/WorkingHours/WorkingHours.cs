using System;

public class WorkingHours
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();
        bool isOpen = hours >= 10 && hours <= 18;

        if(day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
        {
            if(isOpen)
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
        else if(day == "Sunday")
        {
            Console.WriteLine("closed");
        }
    }
}