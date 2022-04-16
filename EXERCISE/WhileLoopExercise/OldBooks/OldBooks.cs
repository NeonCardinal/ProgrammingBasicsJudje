using System;

public class OldBooks
{
    static void Main()
    {
        string book = Console.ReadLine();

        int bookCnt = 0;
        bool isFound = false;

        string nextBook = Console.ReadLine();

        while(nextBook != "No More Books")
        {
            if(nextBook == book)
            {
                isFound = true;
                break;
            }

            bookCnt++;

            nextBook = Console.ReadLine();
        }

        if(isFound)
        {
            Console.WriteLine($"You checked {bookCnt} books and found it.");
        }
        else
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {bookCnt} books.");
        }
    }
}