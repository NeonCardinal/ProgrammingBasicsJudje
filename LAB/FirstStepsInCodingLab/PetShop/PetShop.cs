using System;

public class PetShop
{
    static void Main()
    {
        //Reading the input
        int packetsForDogs = int.Parse(Console.ReadLine());
        int packetsForCats = int.Parse(Console.ReadLine());

        //Some calculations
        double totalPrice = packetsForDogs * 2.50 + packetsForCats * 4.00;

        //Priting the result
        Console.WriteLine($"{totalPrice} lv.");
    }
}