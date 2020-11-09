using System;

namespace BinairZoekAlgoritme
{
    class Program
    {
        static void Main()
        {
            int[] postcodes = { 1000, 2000, 3500, 8000, 8500, 9000 };
            string[] steden = { "Brussel", "Antwerpen", "Hasselt", "Brugge", "Kortrijk", "Gent" };

            do
            {
                Console.Write("Postcode?: ");
                int opTeZoekenPostcode = int.Parse(Console.ReadLine());

                int index = 0;
                int lowerbound = 0;                         //ondergrens van het zoekbereik
                int upperbound = steden.Length - 1;         //bovengrens van het zoekbereik
                bool gevonden = false;
                while (!gevonden && lowerbound <= upperbound)
                {
                    index = (lowerbound + upperbound) / 2;  //middelste element
                    if (postcodes[index] == opTeZoekenPostcode)
                        gevonden = true;
                    else if (postcodes[index] < opTeZoekenPostcode)
                        lowerbound = index + 1;             //verder gaan met het rechterdeel
                    else //if (postcodes[index] > opTeZoekenPostcode)
                        upperbound = index - 1;             //verder gaan met het linkerdeel
                }

                if (gevonden)
                    Console.WriteLine($"Stad: {steden[index]}");
                else
                    Console.WriteLine("Geen stad teruggevonden met deze postcode.");

                Console.WriteLine();
            } while (true);
        }

    }
}
