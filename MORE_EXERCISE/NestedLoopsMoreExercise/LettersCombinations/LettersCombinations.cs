using System;

public class LettersCombinations
{
    static void Main()
    {
        char start = char.Parse(Console.ReadLine());
        char end = char.Parse(Console.ReadLine());
        char expelledLetter = char.Parse(Console.ReadLine());

        int counter = 0;

        for(char ch = start; ch <= end; ch++)
        {
            for(char ch2 = start; ch2 <= end; ch2++)
            {
                for(char ch3 = start; ch3 <= end; ch3++)
                {
                    if(ch != expelledLetter && ch2 != expelledLetter && ch3 != expelledLetter)
                    {
                        counter++;
                        Console.Write($"{ch}{ch2}{ch3} ");
                    }
                }
            }
        }

        Console.WriteLine(counter);
    }
}