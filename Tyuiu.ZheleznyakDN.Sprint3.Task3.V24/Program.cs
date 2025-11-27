using Tyuiu.ZheleznyakDN.Sprint3.Task3.V24.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint3.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл foreach                                                      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы g на * в строке: gft hggt ntg     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            string str = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';

            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Заменяемый символ: {replaceable}");
            Console.WriteLine($"Заменяющий символ: {replacement}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            string result = ds.ReplaceCharInString(str, replaceable, replacement);
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}
