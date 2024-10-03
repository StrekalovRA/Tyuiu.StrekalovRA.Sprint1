using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.StrekalovRA.Sprint1.Task0.V24.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #1 
                Тема: Базовые навыки в C#
                Задание #0
                Вариант #24
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая вычисляет выражение 2 * 4 / 4 / 2 + 1
                и печатает результат на экране.
             */

            DataService dataService = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + dataService.Calculate());
            Console.ReadKey();
        }
    }
}