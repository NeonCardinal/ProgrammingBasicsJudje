using System;

public class ToyShop
{
    static void Main()
    {
        double vacantionPrice = double.Parse(Console.ReadLine());
        int puzzleCounter = int.Parse(Console.ReadLine());
        int mupetCounter = int.Parse(Console.ReadLine());
        int taddyBearCounter = int.Parse(Console.ReadLine());
        int minionsCounter = int.Parse(Console.ReadLine());
        int trucksCounter = int.Parse(Console.ReadLine());

        int toysCounter = puzzleCounter + mupetCounter + taddyBearCounter + minionsCounter + trucksCounter;
        double money = (puzzleCounter * 2.60)
            + (mupetCounter * 3.00)
            + (taddyBearCounter * 4.10)
            + (minionsCounter * 8.20)
            + (trucksCounter * 2.00);
        double discount = 0.0;
        double rent = 0.0;

        if(toysCounter >= 50)
        {
            discount = money * 0.25;
            money -= discount;
        }

        rent = money * 0.10;
        money -= rent;

        if(money >= vacantionPrice)
        {
            Console.WriteLine($"Yes! {(money - vacantionPrice):F2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {(vacantionPrice - money):F2} lv needed.");
        }
    }
}