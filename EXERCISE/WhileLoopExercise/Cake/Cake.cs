using System;

public class Cake
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int len = int.Parse(Console.ReadLine());

        int pieces = width * len;

        while(pieces > 0)
        {
            string command = Console.ReadLine();

            if(command == "STOP")
            {
                if(pieces > 0)
                {
                    Console.WriteLine($"{pieces} pieces are left.");
                }
                break;
            }

            int takenPieces = int.Parse(command);

            pieces -= takenPieces;

            if(pieces <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                break;
            }
        }
    }
}