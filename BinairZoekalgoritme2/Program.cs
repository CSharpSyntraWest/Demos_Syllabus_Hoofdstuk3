using System;

namespace BinairZoekalgoritme2
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

                int index = Array.BinarySearch(postcodes, opTeZoekenPostcode);
                bool gevonden = (index >= 0);

                if (gevonden)
                    Console.WriteLine($"Stad: {steden[index]}");
                else
                    Console.WriteLine("Geen stad teruggevonden met deze postcode.");

                Console.WriteLine();
            } while (true);
        }

    }
}
