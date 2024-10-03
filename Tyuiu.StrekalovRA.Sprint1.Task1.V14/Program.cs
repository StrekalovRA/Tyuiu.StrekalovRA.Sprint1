using Tyuiu.StrekalovRA.Sprint1.Task1.V14.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #1
                Тема: Организация ввода\вывода в консольных приложениях
                Задание #1
                Вариант #14
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая запрашивает у пользователя исходные данные,
                вычисляет результат по формуле a*b/c+(a/(b+c)) и печатает его на экране.
             */

            double A, B, C;
            Console.WriteLine("A = ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B = ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("C = ");
            C = Convert.ToDouble(Console.ReadLine());

            DataService DS = new DataService();
            var Res_ = DS.Calculate(A, B, C);
            Console.WriteLine("РЕЗУЛЬТАТ: " + Res_);
            Console.ReadKey();
        }
    }
}