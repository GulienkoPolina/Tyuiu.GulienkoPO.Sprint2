using Tyuiu.GulienkoPO.Sprint2.Task6.V11.Lib;

namespace Tyuiu.GulienkoPO.Sprint2.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Гулиенко П. О. | ИСТНб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
            Console.WriteLine("* Задание #6                                                           *");
            Console.WriteLine("* Вариант #11                                                          *");
            Console.WriteLine("* Выполнил: Гулиенко Полина Олеговна | ИСТНб-24-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи      *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат. *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int n = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string res;

            if ((m < 1) || (m > 12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это месяц" + ds.FindDateOfNextDay(g, m, n);
            }
                Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");


            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}