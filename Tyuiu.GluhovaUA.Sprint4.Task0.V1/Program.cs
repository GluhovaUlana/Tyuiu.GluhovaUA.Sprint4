using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint4.Task0.V1.Lib;
namespace Tyuiu.GluhovaUA.Sprint4.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Глухова У. А.| ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("*Выполнила: Глухова У. А.| ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("  статическими значениями в диапазоне от 0 до 9. Подсчитать сумму         *");
            Console.WriteLine("  четных элементов массива. {6 ,4 ,3 ,2 ,1 ,0 ,9 ,8 ,7 ,5}                *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] array = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            Console.WriteLine("Исходный массив: ");
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    {
                        s += array[i];
                    }

                }

            }
            Console.WriteLine(s);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}