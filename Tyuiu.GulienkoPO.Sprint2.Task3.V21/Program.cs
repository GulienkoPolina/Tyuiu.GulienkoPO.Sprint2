using Tyuiu.GulienkoPO.Sprint2.Task3.V21.Lib;

namespace Tyuiu.GulienkoPO.Sprint2.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Cпринт #2 | Выполнила: Гулиенко П. О. | ИСТНб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #21                                                              *");
            Console.WriteLine("* Выполнил: Гулиенко П. О. | ИСТНб-24-1                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y       *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит     *");
            Console.WriteLine("* значение переменной X с клавиатуры.                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Введите x =                                                              *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            double res = ds.Calculate(x);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }

}