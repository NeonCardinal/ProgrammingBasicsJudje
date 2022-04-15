﻿using System;

public class Salary
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int salary = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            string web = Console.ReadLine();

            if(web == "Facebook")
            {
                salary -= 150;
            }
            else if(web == "Instagram")
            {
                salary -= 100;
            }
            else if(web == "Reddit")
            {
                salary -= 50;
            }

            if(salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
                break;
            }
        }

        if(salary > 0)
        {
            Console.WriteLine(salary);
        }
    }
}