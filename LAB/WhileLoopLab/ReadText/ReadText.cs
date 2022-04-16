using System;

public class ReadText
{
    static void Main()
    {

        while(true)
        {
            string input = Console.ReadLine();

            if(input == "Stop")
            {
                break;
            }

            Console.WriteLine(input);
        }
    }
}