using System;
using System.Collections.Generic;

namespace PraktikaMIAPO2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            uint num;
            List<uint> arrayBilets = new List<uint>();
            List<uint> happyBilets = new List<uint>();
            uint choice;
            
            Console.WriteLine("Сколько билетов хотите ввести?");
            uint size = Convert.ToUInt32(Console.ReadLine());
            while (arrayBilets.Count < size)
            {
                Console.WriteLine("Введите билет, состоящий из 6 цифр:");
                try
                {
                    num = Convert.ToUInt32(Console.ReadLine());
                    if (num <= 999999 && num >= 100000)
                    {
                        arrayBilets.Add(num);
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Не является числом!");
                }
            }
            Console.WriteLine("Список билетов заполнен!");
            
            FirstFunction.CheckBilets(arrayBilets,happyBilets);
            
            exit:
            Console.WriteLine("Выберите действие:" +
                              "\n1 - Проверка на четность" +
                              "\n2 - Проверка на квадраты и кубы" +
                              "\n3 - Проверка на простое число" +
                              "\n4 - Выход");
            
            choice = Convert.ToUInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SecondFunction.ParityOrNot(happyBilets);
                    goto exit;
                case 2:
                    ThirdFunction.SquareOrCube(happyBilets);
                    goto exit;
                case 3:
                    FourthFunction.PrimeNumber(happyBilets);
                    goto exit;
                case 4:
                    return; 
                default:
                    throw new Exception("Цифра введена неверно!");
            }
            
        }
    }
}