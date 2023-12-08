using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BotterVV.Sprint6.Task4.V30.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint6\Tyuiu.BotterVV.Sprint6.Task4.V30\bin\Debug\OutPutFileTask4V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
