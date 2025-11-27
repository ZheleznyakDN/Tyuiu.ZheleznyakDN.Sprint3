using Tyuiu.ZheleznyakDN.Sprint3.Task0.V15.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму          *");
            Console.WriteLine("* ряда по формуле, при t = 0,7                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            double t = 0.7;
            int startK = 1;
            int stopK = 10;

            Console.WriteLine($"Значение t = {t}");
            Console.WriteLine($"Начальное значение k = {startK}");
            Console.WriteLine($"Конечное значение k = {stopK}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(t, startK, stopK);
            Console.WriteLine($"Сумма ряда S = {result}");

            Console.ReadKey();
        }
    }
}
