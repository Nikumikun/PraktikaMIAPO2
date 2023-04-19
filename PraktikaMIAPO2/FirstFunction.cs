using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace PraktikaMIAPO2
{
    public class FirstFunction
    {
        public static void CheckBilets(List<uint> bilets, List<uint> happybilets)
        {
            for (int i = 0; i < bilets.Count; i++)
            {
                uint Half1 = 0;
                uint Half2 = 0;
                uint HalfSum1 = 0;
                uint HalfSum2 = 0;
                uint num1 = 0;
                uint num2 = 0;
                
                Half1 = bilets[i] % 1000;
                Half2 = bilets[i] / 1000;
                
                for (int j = 0; j < 3; j++)
                {
                    num1 = Half1 % 10;
                    HalfSum1 = HalfSum1 + num1;
                    Half1 = Half1 / 10;
                    num2 = Half2 % 10;
                    HalfSum2 = HalfSum2 + num2;
                    Half2 = Half2 / 10;
                }

                if (HalfSum1 == HalfSum2)
                {
                    Console.WriteLine(bilets[i] + " - Счастливый билет");
                    happybilets.Add(bilets[i]);
                }
                else
                {
                    Console.WriteLine(bilets[i] + " - Несчастливый билет");
                }
            }
            
            Console.WriteLine("Всего счастливых билетов: " + happybilets.Count);
        }
    }
}