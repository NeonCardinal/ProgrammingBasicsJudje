using System;

public class Hospital
{
    static void Main()
    {
        int period = int.Parse(Console.ReadLine());

        int treatedPatients = 0;
        int untreatedPatients = 0;
        int doctorsCounter = 7;

        for (int i = 1; i <= period; i++)
        {
            int currentPatients = int.Parse(Console.ReadLine());

            if ((i % 3 == 0) && (untreatedPatients > treatedPatients))
            {
                doctorsCounter++;
            }

            if (currentPatients > doctorsCounter)
            {
                treatedPatients += doctorsCounter;
                untreatedPatients += currentPatients - doctorsCounter;
            }
            else
            {
                treatedPatients += currentPatients;
            }
        }

        Console.WriteLine($"Treated patients: {treatedPatients}.");
        Console.WriteLine($"Untreated patients: {untreatedPatients}.");
    }
}