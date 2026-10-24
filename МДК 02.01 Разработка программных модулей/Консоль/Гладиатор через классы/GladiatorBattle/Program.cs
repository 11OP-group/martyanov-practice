using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorBattle
{
    /// <summary>
    /// Класс с данными бойца
    /// </summary>
    public class Gladiator
    {
        public double health, armor;
        public int strength, hitsDealt = 0;
        public string name;
        public bool isDead = false;

        /// <summary>
        /// Функция инициализации бойца по входным данным
        /// </summary>
        /// <param name="health">Здоровье бойца</param>
        /// <param name="armor">Броня бойца</param>
        /// <param name="name">Имя бойца</param>
        internal void createWarrior(double health, double armor, string name)
        {
            this.health = health;
            this.armor = armor;
            this.name = name;
            Random rnd = new Random();
            this.strength = 50 + rnd.Next(-5, 15);
        }

        /// <summary>
        /// Функция обработки входящего удара
        /// </summary>
        /// <param name="strength">Сила, с которой по бойцу нанесён удар</param>
        /// <param name="damageDealer">Имя того, кто удар нанёс</param>
        internal void takeDamage(double strength, string damageDealer)
        {
            Console.WriteLine($"{damageDealer} наносит удар...");
            double armorTookDamage = strength * 0.25;
            if (this.armor - armorTookDamage >= 0)
            {
                this.armor -= armorTookDamage;
                this.armor = Math.Round(this.armor, 1);
            }
            else this.armor = 0;
            if (this.health - (strength - this.armor) >= 0)
            {
                this.health -= (strength - this.armor);
                this.health = Math.Round(this.health, 1);
            }
            else
            {
                this.health = 0;
                this.isDead = true;
                Console.WriteLine($"{this.name} погиб!");
            }
        }

    }
    internal class Program
    {
        /// <summary>
        /// Функция для оформления текста в простую рамку
        /// и вывода в консоль
        /// </summary>
        /// <param name="text"></param>
        static void textOutput(string text)
        {
            Console.WriteLine(new string('—', 60));
            string begining = $"{text}";
            int totalWidth = 60;
            int spaces = (totalWidth - begining.Length) / 2;
            string centeredOutput = begining.PadLeft(spaces + begining.Length);
            Console.WriteLine(centeredOutput);
            Console.WriteLine(new string('—', 60));
        }
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] input;
            Gladiator David = new Gladiator();
            Gladiator Goliaf = new Gladiator();

            //Коды цветов
            string reset = "\u001b[0m";
            string red = "\u001b[31m";
            string green = "\u001b[32m";
            string gold = "\u001b[33m";

            textOutput("ВЫХОД БОЙЦОВ");

        Input:
            try
            {
                //Ввод здоровья и брони первого бойца
                Console.Write("Уровень здоровья и брони первого (через пробел): ");
                input = Console.ReadLine().Split(' ');

                if (double.Parse(input[0]) < 0 || double.Parse(input[1]) < 0)
                {
                    Console.WriteLine("Числа не могут быть отрицательными!");
                    goto Input;
                }
                else
                {
                    David.createWarrior(Math.Round(double.Parse(input[0]), 2), double.Parse(input[1]), "Давид");
                }

                input = Array.Empty<string>();

                //Ввод здоровья и брони второго бойца
                Console.Write("Уровень здоровья и брони второго (через пробел): ");
                input = Console.ReadLine().Split(' ');

                if (double.Parse(input[0]) < 0 || double.Parse(input[1]) < 0)
                {
                    Console.WriteLine("Числа не могут быть отрицательными!");
                    goto Input;
                }
                else
                { 
                    Goliaf.createWarrior(Math.Round(double.Parse(input[0]), 2), double.Parse(input[1]), "Голиаф");
                }
            }
            catch 
            {
                Console.WriteLine("Неправильный формат ввода!");
                goto Input;
            }

            Console.WriteLine($"Гладиатор {green}{David.name}{reset} имеет {David.strength} силы...");
            Console.WriteLine($"Гладиатор {red}{Goliaf.name}{reset} имеет {Goliaf.strength} силы...");

            textOutput("БОЙ НАЧИНАЕТСЯ!");

            System.Threading.Thread.Sleep(1000);

            //Бой продолжится, пока у обоих ещё есть здоровье
            while (David.health > 0 && Goliaf.health > 0) {
                David.takeDamage(Goliaf.strength, Goliaf.name);
                Goliaf.hitsDealt++;

                if (David.isDead) break;

                Console.WriteLine($"У {green}{David.name}а{reset} осталось {David.health}HP и {David.armor} брони");

                System.Threading.Thread.Sleep(1000);

                Goliaf.takeDamage(David.strength, David.name);
                David.hitsDealt++;

                if (Goliaf.isDead) break;

                Console.WriteLine($"У {red}{Goliaf.name}а{reset} осталось {Goliaf.health}HP и {Goliaf.armor} брони");

                Console.WriteLine(new string('—', 60));
            }

            System.Threading.Thread.Sleep(1500);

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (David.health > Goliaf.health)
            {
                Console.WriteLine($"Победил {David.name}, нанеся {David.hitsDealt} ударов!");
            }
            else if (David.health < Goliaf.health)
            {
                Console.WriteLine($"Победил {Goliaf.name}, нанеся {Goliaf.hitsDealt} ударов!");
            }
            else
            {
                Console.WriteLine($"У нас ничья!");
            }
            Console.ResetColor();

            Console.Write("Нажмите <Enter> для выхода...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
