using System;

namespace Palidromy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sprawdzenie spr = new Sprawdzenie();

            Console.WriteLine("PALIDROMY");
            Console.WriteLine("Podaj słowo do sprawdzenia: ");

            string slowo = Console.ReadLine().ToUpper();

            var czyPalidrom = spr.zamianaLiter(slowo);

            if (czyPalidrom)
                Console.WriteLine($"Podane słowo: {slowo}, jest palidromem!");
            else
                Console.WriteLine($"Podane słowo: {slowo}, nie jest palidromem");
        }
    }
}
