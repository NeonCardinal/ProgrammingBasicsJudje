using System;

public class Moving
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int len = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int volume = width * len * height;

        while(true)
        {
            string command = Console.ReadLine();

            if(command == "Done")
            {
                if(volume > 0)
                {
                    Console.WriteLine($"{volume} Cubic meters left.");
                }
                break;
            }

            int boxArea = int.Parse(command);

            volume -= boxArea;

            if(volume <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                break;
            }
        }
    }
}