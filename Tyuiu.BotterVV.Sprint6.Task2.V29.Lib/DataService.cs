using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BotterVV.Sprint6.Task2.V29.Lib
{
    public class DataService : ISprint6Task2V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3;
                valueArray[count] = Math.Round(y, 2);
                count++;
                if ((2*x - 1) == 0)
                {
                    valueArray[count] = 0;
                }
            }
            return valueArray;
        }
    }
}
