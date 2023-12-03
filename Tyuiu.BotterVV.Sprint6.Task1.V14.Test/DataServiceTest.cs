using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint6.Task1.V14.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -14.27;
            valueWaitArray[1] = -12.29;
            valueWaitArray[2] = -10.50;
            valueWaitArray[3] = -9.48;
            valueWaitArray[4] = -18.05;
            valueWaitArray[5] = 3;
            valueWaitArray[6] = 2.90;
            valueWaitArray[7] = 4.79;
            valueWaitArray[8] = 5.99;
            valueWaitArray[9] = 6.79;
            valueWaitArray[10] = 8.14;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
