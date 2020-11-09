using System;

namespace ForEachEnkelVoorUitlezen
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] getallen = { 1, 2, 3, 4, 5 };

            // Inhoud aanpassen kan niet met een foreach:

            //foreach (int getal in getallen)
            //    getal = getal * 2;  // compilefout

            // Kan wel met een for:

            for (int index = 0; index < getallen.Length; index++)
                getallen[index] = getallen[index] * 2;

            // Of met een while:

            // int index = 0;
            // while (index < getallen.Length)
            // {
            //     getallen[index] = getallen[index] * 2;
            //     index++;
            // }

            foreach (int getal in getallen)
                Console.Write(getal + " ");

        }

    }
}
