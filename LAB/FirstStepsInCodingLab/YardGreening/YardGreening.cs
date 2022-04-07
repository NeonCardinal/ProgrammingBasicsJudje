using System;

public class YardGreening
{
    static void Main()
    {
        //Reading the input
        double area = double.Parse(Console.ReadLine());

        //Some calculations
        double priceForArea = area * 7.61;
        double discount = priceForArea * 0.18;
        double finalPrice = priceForArea - discount;

        //Printing the result on the console
        Console.WriteLine($"The final price is: {finalPrice} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}