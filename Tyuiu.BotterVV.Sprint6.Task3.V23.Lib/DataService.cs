using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BotterVV.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] array = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i] = matrix[i, 1];
                }
            }

            Array.Sort(array);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, 1] = array[i];
                }
            }
            return matrix;
        }
    }
}
