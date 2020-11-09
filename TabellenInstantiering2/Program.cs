using System;

namespace TabellenInstantiering2
{
    class Program
    {
        static void Main()
        {
            decimal leenbedrag = 120000m;
            Console.Write("Aantal jaar?: ");
            int aantalJaar = int.Parse(Console.ReadLine());
            int aantalMaandelijkseAfbetalingen = aantalJaar * 12;
            decimal maandelijkseAfbetaling = leenbedrag / aantalMaandelijkseAfbetalingen;

            decimal[] maandelijkseAfbetalingen = new decimal[aantalMaandelijkseAfbetalingen];

            for (int index = 0; index < maandelijkseAfbetalingen.Length; index++)
                maandelijkseAfbetalingen[index] = maandelijkseAfbetaling;

            Console.Write("Aantal maandelijkse afbetalingen: " + maandelijkseAfbetalingen.Length);

        }

    }
}
