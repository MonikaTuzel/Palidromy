using System;

namespace Palidromy
{
    internal class Sprawdzenie
    {
        public bool zamianaLiter(string slowo)
        {
            var podaneSlowo = slowo.ToCharArray();

            char[] palidrom = new char[podaneSlowo.Length];

            int iloscLiter = podaneSlowo.Length;

            bool czyPalidrom = false;

            foreach (var c in podaneSlowo)
            {
                palidrom[iloscLiter - 1] = c;
                iloscLiter--;
            }            

            if (new string(podaneSlowo) == new string(palidrom))
                czyPalidrom=true;
            else
                czyPalidrom=false;

            return czyPalidrom;
        }
    }
}
