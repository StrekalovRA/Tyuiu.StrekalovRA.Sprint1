using Tyuiu.StrekalovRA.Sprint1.Task7.V10.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #1
                Тема: Добавление к решению итоговых проектов по спринту
                Задание #7
                Вариант #10
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая вычисляет математическое выражение по исходным значениям данных,
                вводимых пользователем. Ответ округлите до 3 знаков после запятой.
                z = 2ctg(3x)-(ln(cosx)/ln(1+x**2))
             */

            double Num;
            Console.WriteLine("Число: ");
            Num = Convert.ToDouble(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.Calculate(Num));
            Console.ReadKey();
        }
    }
}