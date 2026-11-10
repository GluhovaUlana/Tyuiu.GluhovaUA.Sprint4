using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GluhovaUA.Sprint4.Task2.V10.Lib
{
    public class DataService : ISprint4Task2V10
    {
        public int Calculate(int[] array)
        {
            int s = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 1 && array[i] % 2 == 1 && array[i] <= 6)
                {
                    s = s * array[i];
                }
            }
            return s;
        }
    }
}
