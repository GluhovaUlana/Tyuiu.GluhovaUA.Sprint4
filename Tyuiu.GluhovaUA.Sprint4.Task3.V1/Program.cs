using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint4.Task3.V1.Lib;
namespace Tyuiu.GluhovaUA.Sprint4.Task3.V1
{
    class Program
    {
        static void Main(string[] args)

        {
            int[,] array = new int[5, 5] { { 3, 4, 3, 4, 1 },
                                          { 8, 1, 6, 6, 9 },
                                          { 9, 8, 5, 1, 3 },
                                          { 1, 8, 7, 1, 2 },
                                          { 9, 9, 7, 5, 6 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Глухова У. А.| ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("*Выполнила: Глухова У. А.| ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("  статическими значениями в диапазоне от 1 до 9. Найдите сумму элементов  *");
            Console.WriteLine("  в последнем столбце массива.                                            *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
           
            Console.WriteLine("Массив: ");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{array[i, j]} \t ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Сумма элементов последней строки массива : " + res);
            Console.ReadKey();
        }
    }
}
