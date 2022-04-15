using System;

public class VowelsSum
{
    static void Main()
    {
        string str = Console.ReadLine().ToLower();

        int sum = 0;

        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] == 'a')
            {
                sum += 1;
            }
            else if(str[i] == 'e')
            {
                sum += 2;
            }
            else if(str[i] == 'i')
            {
                sum += 3;
            }
            else if(str[i] == 'o')
            {
                sum += 4;
            }
            else if(str[i] == 'u')
            {
                sum += 5;
            }
        }

        Console.WriteLine(sum);
    }
}