using System;

public class Dishwasher
{
    static void Main()
    {
        int bottles = int.Parse(Console.ReadLine());

        int quantity = bottles * 750;
        int cnt = 0;
        int washedDishes = 0;
        int washedPots = 0;

        while(true)
        {
            string command = Console.ReadLine();

            cnt++;

            if(command == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{washedDishes} dishes and {washedPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {quantity} ml.");
                break;
            }

            if(cnt % 3 == 0)
            {
                int pots = int.Parse(command);
                washedPots += pots;
                quantity -= pots * 15;
            }
            else
            {
                int dishes = int.Parse(command);
                washedDishes += dishes;
                quantity -= dishes * 5;
            }

            if(quantity <= 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(quantity)} ml. more necessary!");
                break;
            }
        }
    }
}