using System;

public class PasswordGuess
{
    static void Main()
    {
        string password = "s3cr3t!P@ssw0rd";
        string str = Console.ReadLine();

        if(str == password)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}