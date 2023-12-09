using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BotterVV.Sprint6.Task6.V6.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint6\Tyuiu.BotterVV.Sprint6.Task6.V6\bin\Debug\InPutFileTask6V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
