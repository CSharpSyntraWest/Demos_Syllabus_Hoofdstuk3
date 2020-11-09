using System;

namespace TabellenIteratieveBenadering
{
    class Program
    {
        static void Main()
        {
            string[] zenders = new string[4];
            zenders[0] = "mozaïek";
            zenders[1] = "Eén";
            zenders[2] = "Canvas/Ketnet";
            zenders[3] = "VTM";

            for (int index = 0; index < zenders.Length; index++)
            {
                Console.WriteLine(zenders[index]);
            }

        }

    }
}
