namespace CollectiesListCapacity
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            List<string> zin = new List<string>();
            Console.WriteLine($"{zin.Count} elementen van de {zin.Capacity} opgevuld");

            zin.Add("Dit ");
            Console.WriteLine($"{zin.Count} elementen van de {zin.Capacity} opgevuld");

            zin.Add("is ");
            Console.WriteLine($"{zin.Count} elementen van de {zin.Capacity} opgevuld");

            zin.Add("een ");
            Console.WriteLine($"{zin.Count} elementen van de {zin.Capacity} opgevuld");

            zin.Add("test");
            Console.WriteLine($"{zin.Count} elementen van de {zin.Capacity} opgevuld");

            zin.Add(".");
            Console.WriteLine($"{zin.Count} elementen van de {zin.Capacity} opgevuld");

            Console.ReadLine();
        }
    }

}
