using Tyuiu.ZheleznyakDN.Sprint3.Task7.V17.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = (x + x^2)/x - cos(x)*4x - 6 на диапазоне [-5; 5] с шагом 1       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("|{0,5}     | {1,8:f2} |", startValue + i, result[i]);
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}
