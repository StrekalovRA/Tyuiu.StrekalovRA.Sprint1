using Tyuiu.StrekalovRA.Sprint1.Task4.V17.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #1
                Тема: Class Math
                Задание #4
                Вариант #17
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по
                формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.
                Формула: 1 / sqrt ( x - 5y ).
             */

            double x, y;
            Console.WriteLine("X = ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Y = ");
            y = Convert.ToDouble(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.Calculate(x, y));
            Console.ReadKey();
        }
    }
}