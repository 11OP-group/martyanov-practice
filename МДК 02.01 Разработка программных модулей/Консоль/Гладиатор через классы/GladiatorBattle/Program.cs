using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorBattle
{
    public class Gladiator
    {
        public double health, armor;
        public int strength;
        public string name;
        public bool isDead = false;

        internal void createWarrior(double health, double armor, string name)
        {
            this.health = health;
            this.armor = armor;
            this.name = name;
            Random rnd = new Random();
            this.strength = 125 + rnd.Next(-10, 20);
        }
        internal void takeDamage(double strength, string damageDealer)
        {
            Console.WriteLine($"{damageDealer} наносит удар...");
            double armorTookDamage = strength / 100 * this.armor;
            if (this.armor - armorTookDamage >= 0) this.armor -= armorTookDamage;
            else this.armor = 0;
            if (this.health - (strength - armorTookDamage) > 0) this.health -= (strength - armorTookDamage);
            else
            {
                this.health = 0;
                this.isDead = true;
            }
        }

    }
    internal class Program
    {
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
            Gladiator warrior1 = new Gladiator();
            Gladiator warrior2 = new Gladiator();

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
                    warrior1.createWarrior(Math.Round(double.Parse(input[0]), 2), double.Parse(input[1]), "Давид");
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
                    warrior2.createWarrior(Math.Round(double.Parse(input[0]), 2), double.Parse(input[1]), "Голиаф");
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

            Console.WriteLine($"Гладиатор {warrior1.name} имеет {warrior1.strength} силы...");
            Console.WriteLine($"Гладиатор {warrior2.name} имеет {warrior2.strength} силы...");

            textOutput("БОЙ НАЧИНАЕТСЯ!");

            System.Threading.Thread.Sleep(1000);

            warrior1.takeDamage(warrior2.strength, warrior2.name);
            Console.WriteLine($"У {warrior1.name} осталось {warrior1.health}HP и {warrior1.armor} брони");

            System.Threading.Thread.Sleep(1000);

            warrior2.takeDamage(warrior1.strength, warrior1.name);
            Console.WriteLine($"У {warrior2.name} осталось {warrior2.health}HP и {warrior2.armor} брони");

            System.Threading.Thread.Sleep(1500);

            if (warrior1.health > warrior2.health)
            {
                Console.WriteLine($"Победил {warrior1.name}!");
            }
            else if (warrior1.health < warrior2.health)
            {
                Console.WriteLine($"Победил {warrior2.name}!");
            }
            else
            {
                Console.WriteLine($"У нас ничья!");
            }
            Console.Write("Нажмите <Enter> для выхода...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
