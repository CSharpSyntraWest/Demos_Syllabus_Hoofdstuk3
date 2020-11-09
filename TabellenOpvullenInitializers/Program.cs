using System;

namespace TabellenOpvullenInitializers
{
    class Program
    {
        static void Main()
        {
            // In plaats van:
            // string[] zenders = new string[4];
            // zenders[0] = "mozaïek";
            // zenders[1] = "Eén";
            // zenders[2] = "Canvas/Ketnet";
            // zenders[3] = "VTM";

            // Kunnen we ook met array initializers werken:
            string[] zenders = new string[]
                     { "mozaïek", "Eén", "Canvas/Ketnet", "VTM" };

            for (int index = 0; index < zenders.Length; index++)
                Console.WriteLine(zenders[index]);
            DateTime[] datums = { new DateTime(2020, 01, 01), new DateTime(2020, 04, 16),
                new DateTime(2020, 04, 17), new DateTime(2020, 05, 01),
                new DateTime(2020, 05, 27), new DateTime(2020, 06, 04),
                new DateTime(2020, 06, 05), new DateTime(2020, 07, 21),
                new DateTime(2020, 08, 15), new DateTime(2020, 11, 01),
                new DateTime(2020, 11, 11), new DateTime(2020, 12, 25)};
        string[] seizoenen = new string[]
               { "winter", "herfst", "zomer", "lengte" };
        int[] dagen = new int[]
               { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    }
}
}
