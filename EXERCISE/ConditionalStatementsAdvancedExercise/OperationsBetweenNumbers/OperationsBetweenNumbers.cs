using System;

public class OperationsBetweenNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();

        if(symbol == "+")
        {
            int sum = firstNumber + secondNumber;

            if(sum % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {sum} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {sum} - odd");
            }
        }
        else if(symbol == "-")
        {
            int sum = firstNumber - secondNumber;

            if (sum % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = {sum} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = {sum} - odd");
            }
        }
        else if (symbol == "*")
        {
            int sum = firstNumber * secondNumber;

            if (sum % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {sum} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {sum} - odd");
            }
        }
        else if(symbol == "/")
        {
            if(secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }
            else
            {
                double result = firstNumber / (secondNumber * 1.0);
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result:F2}");
            }
        }
        else if(symbol == "%")
        {
            if (secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }
            else
            {
                double resutl = firstNumber % secondNumber;
                Console.WriteLine($"{firstNumber} % {secondNumber} = {resutl}");
            }
        }
    }
}