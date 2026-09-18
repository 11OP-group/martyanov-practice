using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank
{
    internal class Program
    {
        public static double RandomDoublePercent(Random random, double min, double max)
        {
            // NextDouble() возвращает значение в диапазоне [0.0, 1.0)
            double randomValue = random.NextDouble();

            // Масштабируем и сдвигаем результат в нужный диапазон
            double range = max - min;
            double scaledValue = randomValue * range;
            double result = scaledValue + min;
            result = Math.Round(result, 3);

            return result;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double summ, perc, dayPerc, val;
            int time;

            Console.Write("Введите сумму вклада: ");  //Ввод суммы вклада
            summ = Convert.ToDouble(Console.ReadLine());
            summ = Math.Round(summ, 2);     //Округляем сумму до 2-х знаков
            Console.Write("Введите срок вклада: ");  //Ввод срока вклада
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            perc = RandomDoublePercent(new Random(), 5.25, 15.86);   // Получение ставки процента
            Console.WriteLine("Годовая ставка: {0}%", perc);
            dayPerc = Math.Round((perc / 365), 3);       // Получение % в день
            Console.WriteLine("Ставка в день: {0}%", dayPerc);

            val = summ * (dayPerc * time) / 100;   // Получение суммы, которая будет добавлена к вкладу
            val = Math.Round(val, 2);
            Console.WriteLine("Сумма от процентов: {0}", val.ToString("C", new CultureInfo("ru-RU")));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Итоговая сумма на вкладе: {0}", Math.Round((summ + val), 2).ToString("C", new CultureInfo("ru-RU")));
            Console.ResetColor();

            Console.Write("Нажмите <Enter> для выхода...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
