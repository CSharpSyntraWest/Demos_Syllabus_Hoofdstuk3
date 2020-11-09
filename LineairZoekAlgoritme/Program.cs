using System;

namespace LineairZoekAlgoritme
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] postcodes = { 1000, 2000, 3500, 8000, 8500, 9000 };
            string[] steden = { "Brussel", "Antwerpen", "Hasselt", "Brugge", "Kortrijk", "Gent" };

            do
            {
                Console.Write("Stad?: ");
                string opTeZoekenStad = Console.ReadLine();

                int index = -1;
                bool gevonden = false;
                while (!gevonden && index < steden.Length - 1)
                {
                    index = index + 1;
                    gevonden = (steden[index] == opTeZoekenStad);
                }

                if (gevonden)
                    Console.WriteLine($"Postcode: {postcodes[index]}");
                else
                    Console.WriteLine("Geen postcode teruggevonden voor deze stad.");

                Console.WriteLine();
            } while (true);
        }

    }
}
