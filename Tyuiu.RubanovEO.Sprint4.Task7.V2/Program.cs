using Tyuiu.RubanovEO.Sprint4.Task7.V2.Lib;

namespace Tyuiu.RubanovEO.Sprint4.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнил: Рубанов Е. О. | ПКТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Рубанов Егор Олегович | ПКТБ-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"597643158942\". Преобразуйте ее в   *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            string value = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(n,m,value));
            Console.ReadKey();

        }
    }
}
