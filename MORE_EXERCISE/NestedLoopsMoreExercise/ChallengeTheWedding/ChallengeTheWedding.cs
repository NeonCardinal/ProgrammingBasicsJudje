using System;

public class ChallengeTheWedding
{
    static void Main()
    {
        int menCounter = int.Parse(Console.ReadLine());
        int womenCounter = int.Parse(Console.ReadLine());
        int freeTables = int.Parse(Console.ReadLine());

        int counter = 0;

        for(int i = 1; i <= menCounter; i++)
        {
            for(int j = 1; j <= womenCounter; j++)
            {
                counter++;
                Console.Write($"({i} <-> {j}) ");

                if(counter == freeTables)
                {
                    break;
                }
            }

            if (counter == freeTables)
            {
                break;
            }
        }
    }
}