using System;

public class StreamOfLetters
{
    static void Main()
    {
        int c = 0;
        int o = 0;
        int n = 0;
        string word = string.Empty;

        while(true)
        {
            string symbol = Console.ReadLine();

            if(symbol == "End")
            {
                break;
            }

            char ch = char.Parse(symbol);

            if(char.IsLetter(ch))
            {
                if(ch == 'c')
                {
                    if(c > 0)
                    {
                        word += ch;
                    }
                    c++;
                }
                else if(ch == 'o')
                {
                    if(o > 0)
                    {                   
                        word += ch;
                    }
                    o++;
                }
                else if(ch == 'n')
                {
                    if(n > 0)
                    {
                        word += ch;
                    }
                    n++;
                }
                else
                {
                    word += ch;
                }

                if(c > 0 && o > 0 && n > 0)
                {
                    Console.Write($"{word} ");
                    c = 0;
                    o = 0;
                    n = 0;
                    word = string.Empty;
                }
            }
        }
    }
}