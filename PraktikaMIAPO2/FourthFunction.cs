using System;
using System.Collections.Generic;

namespace PraktikaMIAPO2
{
    public class FourthFunction
    {
        public static void PrimeNumber(List<uint> happybilets)
        {
            uint AmountPrime = 0;
            bool Prime = false;
            uint AmountDivider = 0;

            for (int i = 0; i < happybilets.Count; i++)
            {
                uint Bilet = happybilets[i];

                for (int j = 2; j < Bilet - 1; j++)
                {
                    if (Bilet % j == 0)
                    {
                        AmountDivider = AmountDivider + 1;
                    }
                }
                if (AmountDivider == 0)
                {
                    Console.WriteLine(happybilets[i] + " - Билет простой");
                    AmountPrime = AmountPrime + 1;
                }
                else
                {
                    Console.WriteLine(happybilets + " - Билет непростой");
                }
            }
            Console.WriteLine("Всего простых билетов: " + AmountPrime);
        }
    }
}