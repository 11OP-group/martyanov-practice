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
        static void Main(string[] args)
        {
            double health, attack, val;
            double armor;

            Console.Write("Введите уровень здоровья: ");  //Ввод здоровья
            health = Convert.ToDouble(Console.ReadLine());
            health = Math.Round(health, 2);     //Округляем здоровье до 2-х знаков
            Console.Write("Введите показатель брони: ");  //Ввод брони
            armor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            attack = RandomDoubleArmor(new Random(), 0, armor);   // Получение показателя удара
            Console.WriteLine("Удар: {0}", attack);

            double with_armor = attack * (armor / 100.0);   //Урон с учётом брони
            val = health - with_armor;   // Получение здоровья после удара
            val = Math.Round(val, 2);
            Console.WriteLine("Здоровье после удара: {0}", val);
            armor -= attack;
            Console.WriteLine("Остаток брони: {0}", armor);

            Console.Write("Нажмите <Enter> для выхода...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
