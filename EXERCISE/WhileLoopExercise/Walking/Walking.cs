using System;

public class Walking
{
    static void Main()
    {
        int steps = 0;

        while(true)
        {
            string command = Console.ReadLine();

            if(command == "Going home")
            {
                int toHome = int.Parse(Console.ReadLine());
                steps += toHome;
                if(steps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{steps - 10000} steps over the goal!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{10000 - steps} more steps to reach goal.");
                }
                break;
            }

            steps += int.Parse(command);

            if(steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
                break;
            }
        }
    }
}