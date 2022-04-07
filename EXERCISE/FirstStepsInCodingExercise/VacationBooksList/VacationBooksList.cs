using System;

public class VacationBooksList
{
    static void Main()
    {
        int pages = int.Parse(Console.ReadLine());
        int pagesPerHour = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int neededDays = pages / pagesPerHour / days;

        Console.WriteLine(neededDays);
    }
}