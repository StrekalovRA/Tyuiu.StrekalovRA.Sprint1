using Tyuiu.StrekalovRA.Sprint1.Task2.V17.Lib;

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
                Задание #2
                Вариант #17
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая вычисляет выражение 2 * 4 / 4 / 2 + 1
                и печатает результат на экране.
             */

            Int32 Mins;
            Console.WriteLine("Минуты: ");
            Mins = Convert.ToInt32(Console.ReadLine());

            DataService DS= new DataService();
           var HourZ = DS.ConvertMinutesToHours(Mins);
            Console.WriteLine("РЕЗУЛЬТАТ: " + HourZ);
            Console.ReadKey();
        }
    }
}