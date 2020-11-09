using System;

namespace IntelligentVergroten
{
    class Program
    {
        static void Main()
        {
            string[] namen = { "Piet", "Bert" };
            int aantal = 2;

            do
            {
                Console.WriteLine($"(plaats voor {namen.Length} namen): ");
                for (int index = 0; index < aantal; index++)
                    Console.WriteLine("-> " + namen[index]);
                Console.WriteLine($":({aantal} opgevuld)");

                Console.Write("Nieuwe naam?: ");
                string nieuweNaam = Console.ReadLine();
                aantal = aantal + 1;
                Console.WriteLine();

                if (aantal > namen.Length)
                {
                    int nieuweCapaciteit = namen.Length * 2;
                    Array.Resize(ref namen, nieuweCapaciteit);
                }
                namen[aantal - 1] = nieuweNaam;

            } while (true);
        }

    }
}
