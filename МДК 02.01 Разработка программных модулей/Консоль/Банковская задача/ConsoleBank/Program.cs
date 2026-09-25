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

            double summ, perc, dayPerc, itogo;
            int time;

            //Ввод суммы вклада
            Console.Write("Введите сумму вклада: ");
            summ = Convert.ToDouble(Console.ReadLine());
            summ = Math.Round(summ, 2);     //Округляем сумму до 2-х знаков

            //Ввод срока вклада
            Console.Write("Введите срок вклада: ");
            time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // Получение ставки процента
            perc = RandomDoublePercent(new Random(), 5.25, 15.86);
            Console.WriteLine("Годовая ставка: {0}%", perc);

            // Получение % в день
            dayPerc = Math.Round((perc / 365), 3);
            Console.WriteLine("Ставка в день: {0}%", dayPerc);

            // Получение суммы, которая будет добавлена к вкладу
            itogo = summ * (dayPerc * time) / 100;
            itogo = Math.Round(itogo, 2);
            Console.WriteLine("Сумма от процентов: {0}", itogo.ToString("C", new CultureInfo("ru-RU")));

            //Вывод итоговой суммы на вкладе
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Итоговая сумма на вкладе: {0}", Math.Round((summ + itogo), 2).ToString("C", new CultureInfo("ru-RU")));
            Console.ResetColor();

            Console.Write("Нажмите <Enter> для выхода...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
