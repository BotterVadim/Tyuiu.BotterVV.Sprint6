using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BotterVV.Sprint6.Task7.V14.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint6\Tyuiu.BotterVV.Sprint6.Task7.V14\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint6\Tyuiu.BotterVV.Sprint6.Task7.V14\bin\Debug\InPutFileTask7V14.csv";

            int[,] wait = {
                {-14, 8, -9, -2, 2, 20,  12, -12, 13, -17 },
                { 7, -20, -18, -2, -7, -19, -8,  3, -18, 1 },
                { 7, -5,  4, -11, -20, 12, 2, 12, -14, 2 },
                { -9, -5, -3, 17, 1, 5, 15, 15, 18, -9 },
                { -3, 11, 6, -4, 8, -19, 4, -12, -8, 14 },
                { 14, -6, 18, -16, 19, -12, -10, 13, -11, -17 },
                { -16, 1, -13, 16,  19, -17, -1, -11, -4, 18 },
                { 18, -12, 0, -17, 0, -7, 11, 7, 19, -2 },
                { 16, 11, -20, 19, -1, -18, 20, -13, -10, -8 },
                { -5, 1, -9, 0, 20, 7, 1, -8, -6, 15 }
            };

            int[,] res = ds.GetMatrix(path);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
