
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint4.Task7.V16.Lib;
namespace Tyuiu.GluhovaUA.Sprint4.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "382976421897948";
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Глухова У. А. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Глухова У. А. | ПИНб-26-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"382976421897948\".                  *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.Write($"{value[index]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых = 5:  ");
            int res = ds.Calculate(n,m,value);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
 