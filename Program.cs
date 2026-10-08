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
        const double BANKTHREEMONTH = 11.50; //3 месяца
        const double BANKSIXMONTH = 11.75; //6 месяцев
        const double BANKYEAR = 12.50; //год
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
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Введите сумму вклада ->");
            temp = Console.ReadLine();
            summa = Convert.ToDouble(temp);
            //Валидация ввода срока
            rep:  Console.CursorLeft = 10;
            Console.WriteLine("Введите срок вклада ->");
            temp = Console.ReadLine();
            period = Convert.ToInt32(temp);
            if (period != 91 && period != 181 && period != 365)
            {
                Console.WriteLine("Вы ошиблись со сроком вклада. Повторите ещё раз");
                goto rep;
            }
            //Выбор банковского % в зависимости от срока
            if (period == 91)
            {
                percentBank = BANKTHREEMONTH;
            }
            else
            {
                if (period == 181)
                {
                    percentBank = BANKSIXMONTH;
                }
            }
            Console.CursorLeft = 10;
            Console.WriteLine("Ваш назначенный банковский % = {0:F2}",percentBank);
            
            //Расчётный блок
            bonusInDay = percentBank / 100 / 365 * summa;
            Console.CursorLeft = 10;
            Console.WriteLine("Ваш ежедневный доход = " + bonusInDay.ToString("F2"));
            bonusInPeriod = bonusInDay * period;
            Console.CursorLeft = 10;
            Console.WriteLine($"Ваш доход за период = {bonusInPeriod:F2}");

            summa += bonusInPeriod;
            
            //Вывод результата
            Console.WriteLine("Ваша сумма на счету в конце периода вклада = {0:F2} доход {1:F2}", summa, bonusInPeriod);


            Console.ReadKey();
        }
    }
}
