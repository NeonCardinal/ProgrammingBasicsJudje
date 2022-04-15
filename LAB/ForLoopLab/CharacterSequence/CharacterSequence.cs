using System;

public class CharacterSequence
{
    static void Main()
    {
        string str = Console.ReadLine();

        for(int i = 0; i < str.Length; i++)
        {
            Console.WriteLine(str[i]);
        }
    }
}