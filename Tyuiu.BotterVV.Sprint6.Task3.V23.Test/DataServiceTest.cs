using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint6.Task3.V23.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();

            int[,] mtrx1 = new int[5, 5] { {0, -19, 25, 34, 0 },
                                           {-19, -16, 1, -5, 34 },
                                           {1, 13, -5, -17, -5 },
                                           {3, -9, -15, -1, 0 },
                                           {1, 20, 15, -5, 31 } };

            int[,] mtrx2 = new int[5, 5] { {0, -19, 25, 34, 0 },
                                           {-19, -16, 1, -5, 34 },
                                           {1, -9, -5, -17, -5 },
                                           {3, 13, -15, -1, 0 },
                                           {1, 20, 15, -5, 31 } };

            CollectionAssert.AreEqual(mtrx2, mtrx1);
        }
    }
}
