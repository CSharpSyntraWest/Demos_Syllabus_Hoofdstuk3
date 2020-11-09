using System;

namespace TabellenOpvullen2
{
    class Program
    {
        static void Main()
        {
            int[] veelvouden = new int[10];

            // opvullen:
            for (int index = 0; index < veelvouden.Length; index++)
                veelvouden[index] = 5 * (index + 1);

            // afdrukken:
            for (int index = 0; index < veelvouden.Length; index++)
                Console.Write(veelvouden[index] + " ");
        }

    }
}
