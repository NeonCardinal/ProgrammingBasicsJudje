using System;

public class InvalidNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isInvalid = (number < 100 || number > 200) && number != 0;

        if(isInvalid)
        {
            Console.WriteLine("invalid");
        }
    }
}