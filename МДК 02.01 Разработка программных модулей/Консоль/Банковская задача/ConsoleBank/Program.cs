using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank
{
    internal class Program
    {
        /// <summary>
        /// Рассчитывает проценты по вкладу
        /// </summary>
        /// <param name="random">Объект типа Random</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <returns>Возвращает случайное число в заданном диапазоне</returns>
        //public static double randomdoublepercent(random random, double min, double max)
        //{
        //    // nextdouble() возвращает значение в диапазоне [0.0, 1.0)
        //    double randomvalue = random.nextdouble();

        //    // масштабируем и сдвигаем результат в нужный диапазон
        //    double range = max - min;
        //    double scaledvalue = randomvalue * range;
        //    double result = scaledvalue + min;
        //    result = math.round(result, 3);

        //    return result;
        //}

        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            const double BANKTHREEMONTH = 11.5;
            const double BANKHALFYEAR = 11.75;
            const double BANKYEAR = 12.5;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double summ, perc, monthPerc;
            int time;

            Console.Title = "Банковская задача";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

        //Этап ввода данных
        Input: {
                try
                {
                    //Ввод суммы вклада
                    Console.Write("Введите сумму вклада: ");
                    summ = Convert.ToDouble(Console.ReadLine());
                    summ = Math.Round(summ, 2);     //Округляем сумму до 2-х знаков

                    //Ввод срока вклада
                    Console.Write("Введите срок вклада: ");
                    time = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введены не числа!");
                    goto Input;     //Возврат к вводу
                }
        }

            switch (time)
            {
                case 91:
                    perc = BANKTHREEMONTH;
                    break;
                case 181:
                    perc = BANKHALFYEAR;
                    break;
                case 365:
                    perc = BANKYEAR;
                    break;
                default:
                    Console.WriteLine("Недопустимый срок вклада!");
                    goto Input;     //Возврат к вводу
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ваш процент составляет {0}%", perc);

            // Получение ставки процента
            //perc = RandomDoublePercent(new Random(), 5.25, 15.86);
            //Console.WriteLine("Годовая ставка: {0}%", perc);

            // Получение % в месяц
            monthPerc = Math.Round((perc / 12), 3);
            Console.WriteLine("Ставка в месяц: {0}%", monthPerc);

            double addition = 0;

            for (int i = 1; i <= time / 30; i++)
            {
                addition = summ * (monthPerc / 100);
                summ += addition;
                summ = Math.Round(summ, 2);
                Console.WriteLine("{1}) Сумма на вкладе: {0} |{2}|", summ.ToString("C", new CultureInfo("ru-RU")), i, addition.ToString("C", new CultureInfo("ru-RU")));
            }

            //Вывод итоговой суммы на вкладе
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Итоговая сумма на вкладе: {0}", Math.Round((summ), 2).ToString("C", new CultureInfo("ru-RU")));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Write("Нажмите <Enter> для выхода...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
