using System;
using System.Collections.Generic;

namespace PraktikaMIAPO2
{
    public class ThirdFunction
    {
        public static void SquareOrCube(List<uint> happybilets)
        {
            uint AmountSquare = 0;
            uint AmountCube = 0;

            for (int i = 0; i < happybilets.Count; i++)
            {
                uint Bilet = happybilets[i];
                if (Math.Sqrt(Bilet) % 1 == 0)
                {
                    Console.WriteLine(happybilets[i] + " - Билет квадрат");
                    AmountSquare = AmountSquare + 1;
                }

                if (Math.Pow(Bilet, 0.33) % 1 == 0)
                {
                    Console.WriteLine(happybilets[i] + " - Билет куб");
                    AmountCube = AmountCube + 1;
                }
                
                Console.WriteLine("Всего квадратов: " + AmountSquare);
                Console.WriteLine("Всего квадратов: " + AmountCube);
            }
        }
    }
}