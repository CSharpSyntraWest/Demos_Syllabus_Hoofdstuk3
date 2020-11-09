using System;

namespace TabellenInstantieringHerinstantieren
{
    class Program
    {
        static void Main()
        {
            string[] namen = { "Piet", "Bert" };

            do
            {
                Console.WriteLine($"({namen.Length} namen): ");
                foreach (string naam in namen)
                    Console.WriteLine("-> " + naam);

                Console.Write("Nieuwe naam?: ");
                string nieuweNaam = Console.ReadLine();
                Console.WriteLine();

                int nieuweCapaciteit = namen.Length + 1;
                Array.Resize(ref namen, nieuweCapaciteit);

                namen[nieuweCapaciteit - 1] = nieuweNaam;

            } while (true);
        }

    }
}
