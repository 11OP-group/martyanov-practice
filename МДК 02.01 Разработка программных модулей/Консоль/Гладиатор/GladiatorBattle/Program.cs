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
            double health, attack, aftAttHealth;
            double armor, withArmor;

            //Ввод здоровья
            Console.Write("Введите уровень здоровья: ");
            health = Convert.ToDouble(Console.ReadLine());
            health = Math.Round(health, 2);     //Округляем здоровье до 2-х знаков

            //Ввод брони
            Console.Write("Введите показатель брони: ");
            armor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // Получение показателя удара
            attack = RandomDoubleArmor(new Random(), 0, armor);
            Console.WriteLine("Удар: {0}", attack);

            withArmor = attack * (armor / 100.0);   //Урон с учётом брони

            // Получение здоровья после удара
            aftAttHealth = health - withArmor;
            aftAttHealth = Math.Round(aftAttHealth, 2);
            Console.WriteLine("Здоровье после удара: {0}", aftAttHealth);

            // Получение брони после удара
            armor -= attack;
            Console.WriteLine("Остаток брони: {0}", armor);

            Console.Write("Нажмите <Enter> для выхода...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
