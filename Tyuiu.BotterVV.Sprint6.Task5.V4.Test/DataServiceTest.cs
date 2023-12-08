using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BotterVV.Sprint6.Task5.V4.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint6\Tyuiu.BotterVV.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
