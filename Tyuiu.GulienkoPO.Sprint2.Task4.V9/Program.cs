using Tyuiu.GulienkoPO.Sprint2.Task4.V9.Lib;

namespace Tyuiu.GulienkoPO.Sprint2.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Cпринт #2 | Выполнила: Гулиенко П. О. | ИСТНб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Гулиенко П. О. | ИСТНб-24-1                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c использованием*");
            Console.WriteLine("* теранарного оператора, где пользователь вводит значение х, у с клавиатуры*");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine("Введите значение переменной X");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();

        }
    }
}