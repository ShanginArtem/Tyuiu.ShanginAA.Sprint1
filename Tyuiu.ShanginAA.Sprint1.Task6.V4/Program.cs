using Tyuiu.ShanginAA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.ShanginAA.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Шангин А. А. | ИСП6-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Шангин Артём Александрович | ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать               *");
            Console.WriteLine("* все слова, содержащие удвоенное н (нн).                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string a;

            Console.WriteLine("Введите текст: ");
            a = Convert.ToString(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.CheckDoubleN(a);
            Console.WriteLine("Все слова, содержащие удвоенное н (нн): " + result);

            Console.ReadKey();


        }
    }
}