using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorBattle
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="random">Объект типа Random</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <returns>Возвращает случайное число в заданном диапазоне</returns>
        public static double RandomDoubleArmor(Random random, double min, double max)
        {
            // NextDouble() возвращает значение в диапазоне [0.0, 1.0)
            double randomValue = random.NextDouble();

            // Масштабируем и сдвигаем результат в нужный диапазон
            double range = max - min;
            double scaledValue = randomValue * range;
            double result = scaledValue + min;
            result = Math.Round(result, 2);

            return result;
        }

        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double health1, armor1;
            double health2, armor2;
            double withArmor;
            double attack;
            string[] input;

        Input:
            try
            {
                //Ввод здоровья и брони первого бойца
                Console.Write("Введите уровень здоровья и брони первого (через пробел): ");
                input = Console.ReadLine().Split(' ');
                health1 = double.Parse(input[0]);
                health1 = Math.Round(health1, 2);     //Округляем здоровье до 2-х знаков
                armor1 = double.Parse(input[1]);
                if (health1 < 0 || armor1 < 0)
                {
                    Console.WriteLine("Числа не могут быть отрицательными!");
                    goto Input;
                }

                input = Array.Empty<string>();

                //Ввод здоровья и брони второго бойца
                Console.Write("Введите уровень здоровья и брони второго (через пробел): ");
                input = Console.ReadLine().Split(' ');
                health2 = double.Parse(input[0]);
                health2 = Math.Round(health2, 2);     //Округляем здоровье до 2-х знаков
                armor2 = double.Parse(input[1]);
                if (health2 < 0 || armor2 < 0)
                {
                    Console.WriteLine("Числа не могут быть отрицательными!");
                    goto Input;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введён не тот разделитель!");
                goto Input;
            }
            catch
            {
                Console.WriteLine("Введены не числа!");
                goto Input;
            }

            Console.WriteLine();

            // Получение показателя удара по первому бойцу
            attack = RandomDoubleArmor(new Random(), 0, armor1);
            Console.WriteLine("Удар: {0}", attack);

            withArmor = attack * (armor1 / 100.0);   //Урон с учётом брони

            // Получение здоровья после удара по первому бойцу
            health1 = health1 - withArmor;
            health1 = Math.Round(health1, 2);
            Console.WriteLine("Здоровье после удара у первого: {0}", health1);

            // Получение брони после удара
            armor1 -= attack;
            Console.WriteLine("Остаток брони первого: {0}", armor1);

            // Получение показателя удара по второму бойцу
            attack = RandomDoubleArmor(new Random(), 0, armor2);
            Console.WriteLine("Удар: {0}", attack);

            withArmor = attack * (armor2 / 100.0);   //Урон с учётом брони

            // Получение здоровья после удара по второму бойцу
            health2 = health2 - withArmor;
            health2 = Math.Round(health2, 2);
            Console.WriteLine("Здоровье после удара у второго: {0}", health2);

            // Получение брони после удара
            armor2 -= attack;
            Console.WriteLine("Остаток брони второго: {0}", armor2);

            if (health1 > health2)
            {
                Console.WriteLine("Первый боец более здоровый! Он победил.");
            }
            else if (health1 < health2)
            {
                Console.WriteLine("Второй боец более здоровый! Он победил.");
            }
            else
            {
                Console.WriteLine("Что-то случилось... Тут ничья!");
            }

            Console.Write("Нажмите <Enter> для выхода...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
