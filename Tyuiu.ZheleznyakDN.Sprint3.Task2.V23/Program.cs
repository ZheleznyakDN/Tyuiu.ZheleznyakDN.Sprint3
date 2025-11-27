using Tyuiu.ZheleznyakDN.Sprint3.Task2.V23.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while,                           *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при a=1,5                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            double a = 1.5;
            int startValue = 1;
            int stopValue = 13;

            Console.WriteLine($"Значение a = {a}");
            Console.WriteLine($"Стартовое значение k = {startValue}");
            Console.WriteLine($"Конечное значение k = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(a, startValue, stopValue);
            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}
