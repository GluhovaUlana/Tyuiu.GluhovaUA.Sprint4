using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint4.Task2.V10.Lib;
namespace Tyuiu.GluhovaUA.Sprint4.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Глухова У. А.| ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("*Выполнила: Глухова У. А.| ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("  случайными в диапазоне от 1 до 6. Подсчитать произведение               *");
            Console.WriteLine("  нечетных элементов массива.                                             *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
               
                array[i] = rnd.Next(1,6);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(array[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Сумма нечётных элементов массива в диапозоне от 1 до 6: "+res);
            Console.ReadKey();
        }
    }
}