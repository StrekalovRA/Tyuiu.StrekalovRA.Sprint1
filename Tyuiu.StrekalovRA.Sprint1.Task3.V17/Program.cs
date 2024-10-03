using Tyuiu.StrekalovRA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #1
                Тема: Операторы составного присваивания
                Задание #3
                Вариант #17
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая определяет, есть ли среди первых трех
                цифр из дробной части заданного вещественного числа цифра 0.

                ВЫХОДНАЯ ДАННАЯ: Значение bool (true / false).
             */

            double Entered_Num;
            Console.WriteLine("Число: ");
            Entered_Num = Convert.ToDouble(Console.ReadLine());

            DataService dataService = new DataService();
            bool Q = dataService.ZeroCheck(Entered_Num);
            Console.WriteLine("РЕЗУЛЬТАТ: " + Q);
            Console.ReadKey();
        }
    }
}