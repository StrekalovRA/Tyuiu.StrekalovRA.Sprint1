using Tyuiu.StrekalovRA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #1
                Тема: Работа со строками класс String
                Задание #6
                Вариант #16
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу: пользователь вводит текст.
                Проверить, что в строке есть восклицание (!) и вопрос (?).
                
                ВХОДНОЙ: строка
                ВЫХОДНОЙ: true, если оба есть, else: false
             */

            Console.WriteLine("Строка: ");
            string A = Console.ReadLine();

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.CheckSpecSymbols(A));
            Console.ReadKey();
        }
    }
}