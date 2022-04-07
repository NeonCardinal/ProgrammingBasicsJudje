using System;

public class WeatherForecast
{
    static void Main()
    {
        string weather = Console.ReadLine().ToLower();

        if (weather == "sunny")
        {
            Console.WriteLine("It's warm outside!");
        }
        else
        {
            Console.WriteLine("It's cold outside!");
        }
    }
}