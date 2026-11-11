using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GluhovaUA.Sprint4.Task3.V1.Lib
{
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int sum = 0;
            int l = columns - 1;
            for (int i=0; i<rows; i++)
            {
                if (array[i, l] > 0)
                {
                    sum += array[i, l];
                }
            }
            return sum;
        }
    }
}

