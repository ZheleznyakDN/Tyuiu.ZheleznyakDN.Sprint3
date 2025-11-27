using Tyuiu.ZheleznyakDN.Sprint3.Task5.V4.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* y = ∑∑(x/cos(k)) для i от 1 до 3, k от 1 до 13 при X=5                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"i от {startValue1} до {stopValue1}");
            Console.WriteLine($"k от {startValue2} до {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"Сумма y = {result}");

            Console.ReadKey();
        }
    }
}
