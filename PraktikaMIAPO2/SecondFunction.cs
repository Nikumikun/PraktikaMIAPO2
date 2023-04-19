using System;
using System.Collections.Generic;

namespace PraktikaMIAPO2
{
    public class SecondFunction
    {
        public static void ParityOrNot(List<uint> happybilets)
        {
            uint AmountParity = 0;
            uint AmountUnparity = 0;

            for (int i = 0; i < happybilets.Count; i++)
            {
                uint Bilet = happybilets[i];
                if (Bilet % 2 == 0)
                {
                    Console.WriteLine(happybilets[i] + " - Билет четный");
                    AmountParity = AmountParity + 1;
                }
                else
                {
                    Console.WriteLine(happybilets[i] + " - Билет нечетный");
                    AmountUnparity = AmountUnparity + 1;
                }
            }
            Console.WriteLine("Всего счастливых четных билетов: " + AmountParity);
            Console.WriteLine("Всего счастливых нечетных билетов: " + AmountUnparity);
        }
    }
}