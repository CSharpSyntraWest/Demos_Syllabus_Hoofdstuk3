using System;

namespace TabellenOpvullen
{
    class Program
    {
        static void Main()
        {
            int[] veelvouden = new int[10];
            int veelvoud = 5;

            // opvullen:
            for (int index = 0; index < veelvouden.Length; index++)
            {
                veelvouden[index] = veelvoud;
                veelvoud = veelvoud + 5;
            }

            // afdrukken:
            for (int index = 0; index < veelvouden.Length; index++)
                Console.Write(veelvouden[index] + " ");

        }

    }
}
