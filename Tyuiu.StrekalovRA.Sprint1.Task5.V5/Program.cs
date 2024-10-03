using Tyuiu.StrekalovRA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #1
                Тема: Преобразование типов и класс Convert
                Задание #5
                Вариант #5
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая решает следующую задачу:
                Присвоить целой переменной d первую цифру из дробной части положительного
                вещественного числа x (так, если x=32.597, то d=5).
             */

            double Num;
            Console.WriteLine("Число: ");
            Num = Convert.ToDouble(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.Calculate(Num));
        }
    }
}