/*
Банковская задача
Входные
Выходные
 */
using System;

namespace ConsoleBank
{
    internal class Program
    {
        static Random Rand = new Random(); //Создать объект датчика случайных чисел (ДСЧ)
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double summa,percentBank,bonusInDay,bonusInPeriod;
            int period;
            string temp;

            Console.Title = "Банковская задача";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();

            //Блок ввода данных
            Console.SetCursorPosition(10,0);
            Console.WriteLine("Введите сумму вклада ->");
            temp = Console.ReadLine();
            summa = Convert.ToDouble(temp);

            Console.CursorLeft = 10;
            Console.WriteLine("Введите срок вклада ->");
            temp = Console.ReadLine();
            period = Convert.ToInt32(temp);
            
            //Блок формирования сл. числа
            percentBank = 5.25 + Rand.NextDouble() * 11.61;
            Console.WriteLine("Ваш назначенный банковский % = {0:F2}",percentBank);
            
            //Расчётный блок
            bonusInDay = percentBank / 100 / 365 * summa;
            Console.WriteLine("Ваш ежедневный доход = " + bonusInDay.ToString("F2"));
            bonusInPeriod = bonusInDay * period;
            Console.WriteLine($"Ваш доход за период = {bonusInPeriod:F2}");

            summa += bonusInPeriod;
            
            //Вывод результата
            Console.WriteLine("Ваша сумма на счету в конце периода вклада = {0:F2} доход {1:F2}", summa, bonusInPeriod);


            Console.ReadKey();
        }
    }
}
